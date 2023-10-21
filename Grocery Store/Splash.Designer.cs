namespace Grocery_Store
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Percentage = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            MyProgress = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(578, 244);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(12, 312);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 2;
            label1.Text = "Loading........";
            label1.Click += label1_Click;
            // 
            // Percentage
            // 
            Percentage.AutoSize = true;
            Percentage.Font = new Font("Century", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Percentage.ForeColor = Color.DarkCyan;
            Percentage.Location = new Point(111, 312);
            Percentage.Name = "Percentage";
            Percentage.Size = new Size(22, 20);
            Percentage.TabIndex = 3;
            Percentage.Text = "%";
            Percentage.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(212, 18);
            label3.Name = "label3";
            label3.Size = new Size(134, 22);
            label3.TabIndex = 4;
            label3.Text = "Grocery Shop";
            label3.Click += label3_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // MyProgress
            // 
            MyProgress.Location = new Point(12, 335);
            MyProgress.Name = "MyProgress";
            MyProgress.Size = new Size(578, 6);
            MyProgress.TabIndex = 5;
            MyProgress.Click += MyProgress_Click;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(602, 367);
            Controls.Add(MyProgress);
            Controls.Add(label3);
            Controls.Add(Percentage);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Splash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label Percentage;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar MyProgress;
        //private Bunifu.Framework.UI.BunifuTrackbar MyProgress;
    }
}