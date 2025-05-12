namespace HelmetDetection;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        pictureBox = new PictureBox();
        btnOpenImage = new Button();
        btnFindHelmet = new Button();
        label1 = new Label();
        ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
        SuspendLayout();
        // 
        // pictureBox
        // 
        pictureBox.Anchor = AnchorStyles.None;
        pictureBox.BackColor = Color.White;
        pictureBox.BorderStyle = BorderStyle.FixedSingle;
        pictureBox.Location = new Point(417, 89);
        pictureBox.Name = "pictureBox";
        pictureBox.Size = new Size(1144, 807);
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox.TabIndex = 1;
        pictureBox.TabStop = false;
        // 
        // btnOpenImage
        // 
        btnOpenImage.Location = new Point(108, 252);
        btnOpenImage.Name = "btnOpenImage";
        btnOpenImage.Size = new Size(251, 111);
        btnOpenImage.TabIndex = 2;
        btnOpenImage.Text = "Choose picture";
        btnOpenImage.UseVisualStyleBackColor = true;
        btnOpenImage.Click += btnOpenImage_Click;
        // 
        // btnFindHelmet
        // 
        btnFindHelmet.Location = new Point(100, 534);
        btnFindHelmet.Name = "btnFindHelmet";
        btnFindHelmet.Size = new Size(259, 111);
        btnFindHelmet.TabIndex = 3;
        btnFindHelmet.Text = "Find helmets";
        btnFindHelmet.UseVisualStyleBackColor = true;
        btnFindHelmet.Click += btnFindHelmet_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 14.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(929, 24);
        label1.Name = "label1";
        label1.Size = new Size(170, 62);
        label1.TabIndex = 4;
        label1.Text = "Picture";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(17F, 41F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1664, 970);
        Controls.Add(label1);
        Controls.Add(btnFindHelmet);
        Controls.Add(btnOpenImage);
        Controls.Add(pictureBox);
        Name = "Form1";
        Text = "Helmet Detection";
        ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private PictureBox pictureBox;
    private Button btnOpenImage;
    private Button btnFindHelmet;
    private Label label1;
}
