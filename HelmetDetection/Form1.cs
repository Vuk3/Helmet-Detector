using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Transforms.Image;
using System.Windows.Forms;
using static HelmetDetection.HelmetDetection;

namespace HelmetDetection;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnOpenImage_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox.Tag = openFileDialog.FileName;
            }
        }
    }

    private void btnFindHelmet_Click(object sender, EventArgs e)
    {
        #region Process image
        if (pictureBox.Image == null)
        {
            MessageBox.Show("Please load the image first.");
            return;
        }

        var inputImage = new Bitmap(pictureBox.Tag.ToString());
        var input = new ModelInput
        {
            Image = MLImage.CreateFromFile(pictureBox.Tag.ToString())
        };

        var output = Predict(input);

        if (output.PredictedBoundingBoxes == null || output.PredictedBoundingBoxes.Length == 0)
        {
            MessageBox.Show("No helmets found.");
            return;
        }
        #endregion

        #region Draw Bounding Boxes
        using (Graphics g = Graphics.FromImage(pictureBox.Image))
        {
            for (int i = 0; i < output.PredictedBoundingBoxes.Length; i += 4)
            {
                float xTop = output.PredictedBoundingBoxes[i];
                float yTop = output.PredictedBoundingBoxes[i + 1];
                float xBottom = output.PredictedBoundingBoxes[i + 2];
                float yBottom = output.PredictedBoundingBoxes[i + 3];
                float score = output.Score[i / 4];

                var rect = new Rectangle((int)xTop, (int)yTop, (int)(xBottom - xTop), (int)(yBottom - yTop));
                g.DrawRectangle(new Pen(Color.Red, 2), rect);
                g.DrawString($"{score:F2}", new Font("Arial", 6), Brushes.Blue, new PointF(xTop, yTop));
            }
        }

        pictureBox.Invalidate();
        #endregion
    }
}

