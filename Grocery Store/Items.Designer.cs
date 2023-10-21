namespace Grocery_Store
{
    partial class Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items));
            panel1 = new Panel();
            label8 = new Label();
            ItemDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            CatCb = new ComboBox();
            ClearBtn = new Button();
            DeleteBtn = new Button();
            EditBtn = new Button();
            SaveBtn = new Button();
            ItPriceTb = new TextBox();
            ItQtyTb = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            ItNameTb = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemDGV).BeginInit();
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
            panel1.Controls.Add(ItemDGV);
            panel1.Controls.Add(CatCb);
            panel1.Controls.Add(ClearBtn);
            panel1.Controls.Add(DeleteBtn);
            panel1.Controls.Add(EditBtn);
            panel1.Controls.Add(SaveBtn);
            panel1.Controls.Add(ItPriceTb);
            panel1.Controls.Add(ItQtyTb);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(ItNameTb);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(28, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(876, 490);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.ForestGreen;
            label8.Location = new Point(805, 451);
            label8.Name = "label8";
            label8.Size = new Size(71, 23);
            label8.TabIndex = 8;
            label8.Text = "LogOut";
            label8.Click += label8_Click;
            // 
            // ItemDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            ItemDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ItemDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ItemDGV.ColumnHeadersHeight = 25;
            ItemDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ItemDGV.DefaultCellStyle = dataGridViewCellStyle3;
            ItemDGV.GridColor = Color.FromArgb(231, 229, 255);
            ItemDGV.Location = new Point(109, 214);
            ItemDGV.Name = "ItemDGV";
            ItemDGV.RowHeadersVisible = false;
            ItemDGV.RowTemplate.Height = 25;
            ItemDGV.Size = new Size(662, 260);
            ItemDGV.TabIndex = 31;
            ItemDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ItemDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            ItemDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ItemDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ItemDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ItemDGV.ThemeStyle.BackColor = Color.White;
            ItemDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            ItemDGV.ThemeStyle.HeaderStyle.BackColor = Color.MediumVioletRed;
            ItemDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ItemDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ItemDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ItemDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ItemDGV.ThemeStyle.HeaderStyle.Height = 25;
            ItemDGV.ThemeStyle.ReadOnly = false;
            ItemDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            ItemDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ItemDGV.ThemeStyle.RowsStyle.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ItemDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ItemDGV.ThemeStyle.RowsStyle.Height = 25;
            ItemDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ItemDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            ItemDGV.CellContentClick += ItemDGV_CellContentClick_1;
            // 
            // CatCb
            // 
            CatCb.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            CatCb.ForeColor = Color.DarkCyan;
            CatCb.FormattingEnabled = true;
            CatCb.Items.AddRange(new object[] { "FISH", "FRUIT", "VEGETABLE", "MEAT" });
            CatCb.Location = new Point(666, 114);
            CatCb.Name = "CatCb";
            CatCb.Size = new Size(174, 27);
            CatCb.TabIndex = 3;
            CatCb.Text = "Select Category";
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
            // ItPriceTb
            // 
            ItPriceTb.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            ItPriceTb.Location = new Point(456, 114);
            ItPriceTb.Name = "ItPriceTb";
            ItPriceTb.Size = new Size(188, 27);
            ItPriceTb.TabIndex = 2;
            // 
            // ItQtyTb
            // 
            ItQtyTb.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            ItQtyTb.Location = new Point(236, 114);
            ItQtyTb.Name = "ItQtyTb";
            ItQtyTb.Size = new Size(188, 27);
            ItQtyTb.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkCyan;
            label7.Location = new Point(676, 89);
            label7.Name = "label7";
            label7.Size = new Size(112, 22);
            label7.TabIndex = 17;
            label7.Text = "Categories";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkCyan;
            label6.Location = new Point(456, 89);
            label6.Name = "label6";
            label6.Size = new Size(55, 22);
            label6.TabIndex = 15;
            label6.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(236, 89);
            label5.Name = "label5";
            label5.Size = new Size(91, 22);
            label5.TabIndex = 13;
            label5.Text = "Quantity";
            // 
            // ItNameTb
            // 
            ItNameTb.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            ItNameTb.Location = new Point(14, 114);
            ItNameTb.Name = "ItNameTb";
            ItNameTb.Size = new Size(188, 27);
            ItNameTb.TabIndex = 0;
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
            // panel3
            // 
            panel3.BackColor = Color.ForestGreen;
            panel3.Location = new Point(496, 47);
            panel3.Name = "panel3";
            panel3.Size = new Size(80, 2);
            panel3.TabIndex = 10;
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(268, 18);
            label1.Name = "label1";
            label1.Size = new Size(149, 26);
            label1.TabIndex = 9;
            label1.Text = "Employees";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.AntiqueWhite;
            label3.Location = new Point(363, 5);
            label3.Name = "label3";
            label3.Size = new Size(187, 33);
            label3.TabIndex = 7;
            label3.Text = "Grocery Shop";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(236, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(466, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // Items
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(927, 543);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Items";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Items";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ItemDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button ClearBtn;
        private Button DeleteBtn;
        private Button EditBtn;
        private Button SaveBtn;
        private TextBox ItPriceTb;
        private TextBox ItQtyTb;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox ItNameTb;
        private Label label4;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox CatCb;
        private Guna.UI2.WinForms.Guna2DataGridView ItemDGV;
        private Label label8;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}