namespace LAB4
{
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
            btnLoad = new Button();
            pictureBox1 = new PictureBox();
            btnOnlyGreen = new Button();
            btnRotate = new Button();
            rbtn90 = new RadioButton();
            rbtn180 = new RadioButton();
            rbtn270 = new RadioButton();
            btnInvertColors = new Button();
            btnUpsideDown = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(27, 273);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(131, 39);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Location = new Point(192, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(496, 278);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnRotate
            // 
            btnRotate.BackColor = Color.FromArgb(255, 128, 128);
            btnRotate.Location = new Point(27, 112);
            btnRotate.Name = "btnRotate";
            btnRotate.Size = new Size(128, 29);
            btnRotate.TabIndex = 2;
            btnRotate.Text = "Rotate";
            btnRotate.UseVisualStyleBackColor = false;
            btnRotate.Click += btnRotate_Click;
            // 
            // rbtn90
            // 
            rbtn90.AutoSize = true;
            rbtn90.ForeColor = Color.FromArgb(255, 128, 128);
            rbtn90.Location = new Point(24, 22);
            rbtn90.Name = "rbtn90";
            rbtn90.Size = new Size(46, 24);
            rbtn90.TabIndex = 3;
            rbtn90.TabStop = true;
            rbtn90.Text = "90";
            rbtn90.UseVisualStyleBackColor = true;
            // 
            // rbtn180
            // 
            rbtn180.AutoSize = true;
            rbtn180.ForeColor = Color.FromArgb(255, 128, 128);
            rbtn180.Location = new Point(24, 52);
            rbtn180.Name = "rbtn180";
            rbtn180.Size = new Size(54, 24);
            rbtn180.TabIndex = 4;
            rbtn180.TabStop = true;
            rbtn180.Text = "180";
            rbtn180.UseVisualStyleBackColor = true;
            // 
            // rbtn270
            // 
            rbtn270.AutoSize = true;
            rbtn270.ForeColor = Color.FromArgb(255, 128, 128);
            rbtn270.Location = new Point(24, 82);
            rbtn270.Name = "rbtn270";
            rbtn270.Size = new Size(54, 24);
            rbtn270.TabIndex = 5;
            rbtn270.TabStop = true;
            rbtn270.Text = "270";
            rbtn270.UseVisualStyleBackColor = true;
            // 
            // btnInvertColors
            // 
            btnInvertColors.BackColor = SystemColors.ActiveCaption;
            btnInvertColors.Location = new Point(27, 147);
            btnInvertColors.Name = "btnInvertColors";
            btnInvertColors.Size = new Size(127, 29);
            btnInvertColors.TabIndex = 6;
            btnInvertColors.Text = "Invert Colors";
            btnInvertColors.UseVisualStyleBackColor = false;
            btnInvertColors.Click += btnInvertColors_Click;
            // 
            // btnUpsideDown
            // 
            btnUpsideDown.BackColor = SystemColors.ActiveCaption;
            btnUpsideDown.Location = new Point(27, 182);
            btnUpsideDown.Name = "btnUpsideDown";
            btnUpsideDown.Size = new Size(127, 29);
            btnUpsideDown.TabIndex = 7;
            btnUpsideDown.Text = "Upside Down";
            btnUpsideDown.UseVisualStyleBackColor = false;
            btnUpsideDown.Click += btnUpsideDown_Click;
            // 
            // btnOnlyGreen
            // 
            btnOnlyGreen.BackColor = Color.FromArgb(192, 255, 192);
            btnOnlyGreen.Location = new Point(24, 223);
            btnOnlyGreen.Name = "btnOnlyGreen";
            btnOnlyGreen.Size = new Size(131, 29);
            btnOnlyGreen.TabIndex = 2;
            btnOnlyGreen.Text = "OnlyGreen";
            btnOnlyGreen.UseVisualStyleBackColor = false;
            btnOnlyGreen.Click += btnOnlyGreen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 334);
            Controls.Add(btnUpsideDown);
            Controls.Add(btnInvertColors);
            Controls.Add(rbtn270);
            Controls.Add(rbtn180);
            Controls.Add(rbtn90);
            Controls.Add(btnRotate);
            ClientSize = new Size(696, 326);
            Controls.Add(btnOnlyGreen);
            Controls.Add(pictureBox1);
            Controls.Add(btnLoad);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private PictureBox pictureBox1;
        private Button btnRotate;
        private RadioButton rbtn90;
        private RadioButton rbtn180;
        private RadioButton rbtn270;
        private Button btnInvertColors;
        private Button btnUpsideDown;
        private Button btnOnlyGreen;
    }
}
