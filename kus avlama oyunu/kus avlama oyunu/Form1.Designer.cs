namespace kus_avlama_oyunu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            leftBird1 = new PictureBox();
            leftBird2 = new PictureBox();
            rightBird1 = new PictureBox();
            rightBird2 = new PictureBox();
            leftBird3 = new PictureBox();
            rightBird3 = new PictureBox();
            btnStart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            lblScore = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftBird1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftBird2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightBird1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightBird2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftBird3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightBird3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-85, 531);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1224, 301);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // leftBird1
            // 
            leftBird1.BackColor = Color.Transparent;
            leftBird1.Image = (Image)resources.GetObject("leftBird1.Image");
            leftBird1.Location = new Point(12, 12);
            leftBird1.Name = "leftBird1";
            leftBird1.Size = new Size(57, 67);
            leftBird1.SizeMode = PictureBoxSizeMode.StretchImage;
            leftBird1.TabIndex = 1;
            leftBird1.TabStop = false;
            leftBird1.Click += LeftBirdClick;
            // 
            // leftBird2
            // 
            leftBird2.BackColor = Color.Transparent;
            leftBird2.Image = (Image)resources.GetObject("leftBird2.Image");
            leftBird2.Location = new Point(12, 85);
            leftBird2.Name = "leftBird2";
            leftBird2.Size = new Size(57, 67);
            leftBird2.SizeMode = PictureBoxSizeMode.StretchImage;
            leftBird2.TabIndex = 2;
            leftBird2.TabStop = false;
            leftBird2.Click += LeftBirdClick;
            // 
            // rightBird1
            // 
            rightBird1.BackColor = Color.Transparent;
            rightBird1.Image = (Image)resources.GetObject("rightBird1.Image");
            rightBird1.Location = new Point(1018, 52);
            rightBird1.Name = "rightBird1";
            rightBird1.Size = new Size(57, 67);
            rightBird1.SizeMode = PictureBoxSizeMode.StretchImage;
            rightBird1.TabIndex = 3;
            rightBird1.TabStop = false;
            rightBird1.Click += RightBirdClick;
            // 
            // rightBird2
            // 
            rightBird2.BackColor = Color.Transparent;
            rightBird2.Image = (Image)resources.GetObject("rightBird2.Image");
            rightBird2.Location = new Point(1018, 125);
            rightBird2.Name = "rightBird2";
            rightBird2.Size = new Size(57, 67);
            rightBird2.SizeMode = PictureBoxSizeMode.StretchImage;
            rightBird2.TabIndex = 4;
            rightBird2.TabStop = false;
            rightBird2.Click += RightBirdClick;
            // 
            // leftBird3
            // 
            leftBird3.BackColor = Color.Transparent;
            leftBird3.Image = (Image)resources.GetObject("leftBird3.Image");
            leftBird3.Location = new Point(12, 158);
            leftBird3.Name = "leftBird3";
            leftBird3.Size = new Size(57, 67);
            leftBird3.SizeMode = PictureBoxSizeMode.StretchImage;
            leftBird3.TabIndex = 5;
            leftBird3.TabStop = false;
            leftBird3.Click += LeftBirdClick;
            // 
            // rightBird3
            // 
            rightBird3.BackColor = Color.Transparent;
            rightBird3.Image = (Image)resources.GetObject("rightBird3.Image");
            rightBird3.Location = new Point(1018, 198);
            rightBird3.Name = "rightBird3";
            rightBird3.Size = new Size(57, 67);
            rightBird3.SizeMode = PictureBoxSizeMode.StretchImage;
            rightBird3.TabIndex = 6;
            rightBird3.TabStop = false;
            rightBird3.Click += RightBirdClick;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Green;
            btnStart.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.ForeColor = SystemColors.Control;
            btnStart.Location = new Point(415, 247);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(299, 100);
            btnStart.TabIndex = 7;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btn_Start_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = SystemColors.Control;
            lblScore.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblScore.Location = new Point(940, 12);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(118, 37);
            lblScore.TabIndex = 8;
            lblScore.Text = "Score: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1087, 680);
            Controls.Add(lblScore);
            Controls.Add(btnStart);
            Controls.Add(rightBird3);
            Controls.Add(leftBird3);
            Controls.Add(rightBird2);
            Controls.Add(rightBird1);
            Controls.Add(leftBird2);
            Controls.Add(leftBird1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftBird1).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftBird2).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightBird1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightBird2).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftBird3).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightBird3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox leftBird1;
        private PictureBox leftBird2;
        private PictureBox rightBird1;
        private PictureBox rightBird2;
        private PictureBox leftBird3;
        private PictureBox rightBird3;
        private Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Label lblScore;
    }
}