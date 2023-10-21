namespace Grocery_Store
{
    partial class Employees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            panel1 = new Panel();
            label8 = new Label();
            EmployeesDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            ClearBtn = new Button();
            DeleteBtn = new Button();
            EditBtn = new Button();
            SaveBtn = new Button();
            EmpAddTb = new TextBox();
            EmpPassTb = new TextBox();
            EmpPhoneTb = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            EmpNameTb = new TextBox();
            label4 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            label3 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeesDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(EmployeesDGV);
            panel1.Controls.Add(ClearBtn);
            panel1.Controls.Add(DeleteBtn);
            panel1.Controls.Add(EditBtn);
            panel1.Controls.Add(SaveBtn);
            panel1.Controls.Add(EmpAddTb);
            panel1.Controls.Add(EmpPassTb);
            panel1.Controls.Add(EmpPhoneTb);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(EmpNameTb);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(24, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(876, 490);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.ForestGreen;
            label8.Location = new Point(805, 452);
            label8.Name = "label8";
            label8.Size = new Size(71, 23);
            label8.TabIndex = 8;
            label8.Text = "LogOut";
            label8.Click += label8_Click;
            // 
            // EmployeesDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            EmployeesDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            EmployeesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            EmployeesDGV.ColumnHeadersHeight = 25;
            EmployeesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            EmployeesDGV.DefaultCellStyle = dataGridViewCellStyle3;
            EmployeesDGV.GridColor = Color.FromArgb(231, 229, 255);
            EmployeesDGV.Location = new Point(118, 223);
            EmployeesDGV.Name = "EmployeesDGV";
            EmployeesDGV.RowHeadersVisible = false;
            EmployeesDGV.RowTemplate.Height = 25;
            EmployeesDGV.Size = new Size(662, 252);
            EmployeesDGV.TabIndex = 27;
            EmployeesDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            EmployeesDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            EmployeesDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            EmployeesDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            EmployeesDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            EmployeesDGV.ThemeStyle.BackColor = Color.White;
            EmployeesDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            EmployeesDGV.ThemeStyle.HeaderStyle.BackColor = Color.MediumVioletRed;
            EmployeesDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            EmployeesDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeesDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            EmployeesDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            EmployeesDGV.ThemeStyle.HeaderStyle.Height = 25;
            EmployeesDGV.ThemeStyle.ReadOnly = false;
            EmployeesDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            EmployeesDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            EmployeesDGV.ThemeStyle.RowsStyle.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeesDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            EmployeesDGV.ThemeStyle.RowsStyle.Height = 25;
            EmployeesDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            EmployeesDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            EmployeesDGV.CellContentClick += EmployeesDGV_CellContentClick;
            // 
            // ClearBtn
            // 
            ClearBtn.BackColor = Color.ForestGreen;
            ClearBtn.FlatStyle = FlatStyle.Flat;
            ClearBtn.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ClearBtn.ForeColor = Color.White;
            ClearBtn.Location = new Point(626, 174);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(119, 34);
            ClearBtn.TabIndex = 7;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.ForestGreen;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(466, 174);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(119, 34);
            DeleteBtn.TabIndex = 6;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.ForestGreen;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            EditBtn.ForeColor = Color.White;
            EditBtn.Location = new Point(304, 174);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(119, 34);
            EditBtn.TabIndex = 5;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.ForestGreen;
            SaveBtn.FlatStyle = FlatStyle.Flat;
            SaveBtn.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(143, 174);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(119, 34);
            SaveBtn.TabIndex = 4;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // EmpAddTb
            // 
            EmpAddTb.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            EmpAddTb.Location = new Point(456, 114);
            EmpAddTb.Name = "EmpAddTb";
            EmpAddTb.Size = new Size(188, 27);
            EmpAddTb.TabIndex = 2;
            // 
            // EmpPassTb
            // 
            EmpPassTb.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            EmpPassTb.Location = new Point(676, 114);
            EmpPassTb.Name = "EmpPassTb";
            EmpPassTb.Size = new Size(188, 27);
            EmpPassTb.TabIndex = 3;
            // 
            // EmpPhoneTb
            // 
            EmpPhoneTb.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            EmpPhoneTb.Location = new Point(236, 114);
            EmpPhoneTb.Name = "EmpPhoneTb";
            EmpPhoneTb.Size = new Size(188, 27);
            EmpPhoneTb.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkCyan;
            label7.Location = new Point(676, 89);
            label7.Name = "label7";
            label7.Size = new Size(94, 22);
            label7.TabIndex = 17;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkCyan;
            label6.Location = new Point(456, 89);
            label6.Name = "label6";
            label6.Size = new Size(82, 22);
            label6.TabIndex = 15;
            label6.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(236, 89);
            label5.Name = "label5";
            label5.Size = new Size(69, 22);
            label5.TabIndex = 13;
            label5.Text = "Phone";
            label5.Click += label5_Click;
            // 
            // EmpNameTb
            // 
            EmpNameTb.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            EmpNameTb.Location = new Point(14, 114);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(188, 27);
            EmpNameTb.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(14, 89);
            label4.Name = "label4";
            label4.Size = new Size(67, 22);
            label4.TabIndex = 11;
            label4.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(496, 18);
            label2.Name = "label2";
            label2.Size = new Size(80, 26);
            label2.TabIndex = 9;
            label2.Text = "Items";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.ForestGreen;
            panel2.Location = new Point(268, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 2);
            panel2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(268, 18);
            label1.Name = "label1";
            label1.Size = new Size(149, 26);
            label1.TabIndex = 7;
            label1.Text = "Employees";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.AntiqueWhite;
            label3.Location = new Point(342, 5);
            label3.Name = "label3";
            label3.Size = new Size(187, 33);
            label3.TabIndex = 6;
            label3.Text = "Grocery Shop";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(236, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(466, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(927, 543);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employees";
            Load += Employees_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeesDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox EmpNameTb;
        private Label label7;
        private Label label6;
        private TextBox EmpAddTb;
        private TextBox EmpPassTb;
        private TextBox EmpPhoneTb;
        private Button EditBtn;
        private Button SaveBtn;
        private Button ClearBtn;
        private Button DeleteBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2DataGridView EmployeesDGV;
        private Label label8;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}