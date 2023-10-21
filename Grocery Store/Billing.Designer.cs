namespace Grocery_Store
{
    partial class Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label3 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            ItemDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            TotalBill = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            BillDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Clear = new Button();
            button4 = new Button();
            AddToBill = new Button();
            ItPriceTb = new TextBox();
            ItClNameTb = new TextBox();
            ItQtyTb = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            ItNameTb = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            User = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BillDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.AntiqueWhite;
            label3.Location = new Point(343, 8);
            label3.Name = "label3";
            label3.Size = new Size(187, 33);
            label3.TabIndex = 8;
            label3.Text = "Grocery Shop";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(ItemDGV);
            panel1.Controls.Add(TotalBill);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(BillDGV);
            panel1.Controls.Add(Clear);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(AddToBill);
            panel1.Controls.Add(ItPriceTb);
            panel1.Controls.Add(ItClNameTb);
            panel1.Controls.Add(ItQtyTb);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(ItNameTb);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(25, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(876, 490);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.ForestGreen;
            label8.Location = new Point(805, 458);
            label8.Name = "label8";
            label8.Size = new Size(71, 23);
            label8.TabIndex = 34;
            label8.Text = "LogOut";
            label8.Click += label8_Click_2;
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
            ItemDGV.Location = new Point(14, 289);
            ItemDGV.Name = "ItemDGV";
            ItemDGV.RowHeadersVisible = false;
            ItemDGV.RowTemplate.Height = 25;
            ItemDGV.Size = new Size(474, 192);
            ItemDGV.TabIndex = 32;
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
            ItemDGV.CellContentClick += ItemDGV_CellContentClick;
            // 
            // TotalBill
            // 
            TotalBill.AutoSize = true;
            TotalBill.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TotalBill.ForeColor = Color.Crimson;
            TotalBill.Location = new Point(686, 320);
            TotalBill.Name = "TotalBill";
            TotalBill.Size = new Size(59, 25);
            TotalBill.TabIndex = 30;
            TotalBill.Text = "Total";
            TotalBill.Click += label8_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(14, 89);
            label2.Name = "label2";
            label2.Size = new Size(127, 22);
            label2.TabIndex = 29;
            label2.Text = "Client Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(332, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // BillDGV
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            BillDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            BillDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            BillDGV.ColumnHeadersHeight = 25;
            BillDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            BillDGV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            BillDGV.DefaultCellStyle = dataGridViewCellStyle6;
            BillDGV.GridColor = Color.FromArgb(231, 229, 255);
            BillDGV.Location = new Point(541, 62);
            BillDGV.Name = "BillDGV";
            BillDGV.RowHeadersVisible = false;
            BillDGV.RowTemplate.Height = 25;
            BillDGV.Size = new Size(299, 249);
            BillDGV.TabIndex = 27;
            BillDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            BillDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            BillDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            BillDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            BillDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            BillDGV.ThemeStyle.BackColor = Color.White;
            BillDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            BillDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            BillDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            BillDGV.ThemeStyle.HeaderStyle.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BillDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            BillDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            BillDGV.ThemeStyle.HeaderStyle.Height = 25;
            BillDGV.ThemeStyle.ReadOnly = false;
            BillDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            BillDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            BillDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BillDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            BillDGV.ThemeStyle.RowsStyle.Height = 25;
            BillDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            BillDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Item";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Price";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Qty";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Total";
            Column5.Name = "Column5";
            // 
            // Clear
            // 
            Clear.BackColor = Color.ForestGreen;
            Clear.FlatStyle = FlatStyle.Flat;
            Clear.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Clear.ForeColor = Color.White;
            Clear.Location = new Point(260, 239);
            Clear.Name = "Clear";
            Clear.Size = new Size(119, 34);
            Clear.TabIndex = 26;
            Clear.Text = "Reset";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Reset_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.ForestGreen;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(652, 348);
            button4.Name = "button4";
            button4.Size = new Size(119, 34);
            button4.TabIndex = 24;
            button4.Text = "Print";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // AddToBill
            // 
            AddToBill.BackColor = Color.ForestGreen;
            AddToBill.FlatStyle = FlatStyle.Flat;
            AddToBill.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddToBill.ForeColor = Color.White;
            AddToBill.Location = new Point(118, 239);
            AddToBill.Name = "AddToBill";
            AddToBill.Size = new Size(119, 34);
            AddToBill.TabIndex = 21;
            AddToBill.Text = "Add to Bill";
            AddToBill.UseVisualStyleBackColor = false;
            AddToBill.Click += AddToBill_Click;
            // 
            // ItPriceTb
            // 
            ItPriceTb.Enabled = false;
            ItPriceTb.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            ItPriceTb.Location = new Point(14, 188);
            ItPriceTb.Name = "ItPriceTb";
            ItPriceTb.Size = new Size(188, 27);
            ItPriceTb.TabIndex = 20;
            // 
            // ItClNameTb
            // 
            ItClNameTb.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            ItClNameTb.Location = new Point(14, 114);
            ItClNameTb.Name = "ItClNameTb";
            ItClNameTb.Size = new Size(188, 27);
            ItClNameTb.TabIndex = 19;
            // 
            // ItQtyTb
            // 
            ItQtyTb.Enabled = false;
            ItQtyTb.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            ItQtyTb.Location = new Point(236, 114);
            ItQtyTb.Name = "ItQtyTb";
            ItQtyTb.Size = new Size(188, 27);
            ItQtyTb.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkCyan;
            label7.Location = new Point(236, 89);
            label7.Name = "label7";
            label7.Size = new Size(91, 22);
            label7.TabIndex = 17;
            label7.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkCyan;
            label6.Location = new Point(11, 163);
            label6.Name = "label6";
            label6.Size = new Size(55, 22);
            label6.TabIndex = 15;
            label6.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Orange;
            label5.Location = new Point(674, 32);
            label5.Name = "label5";
            label5.Size = new Size(33, 22);
            label5.TabIndex = 13;
            label5.Text = "Bill";
            // 
            // ItNameTb
            // 
            ItNameTb.Enabled = false;
            ItNameTb.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            ItNameTb.Location = new Point(236, 188);
            ItNameTb.Name = "ItNameTb";
            ItNameTb.Size = new Size(188, 27);
            ItNameTb.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(236, 163);
            label4.Name = "label4";
            label4.Size = new Size(52, 22);
            label4.TabIndex = 11;
            label4.Text = "Item";
            // 
            // panel2
            // 
            panel2.BackColor = Color.ForestGreen;
            panel2.Location = new Point(388, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(100, 2);
            panel2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(385, 18);
            label1.Name = "label1";
            label1.Size = new Size(103, 26);
            label1.TabIndex = 7;
            label1.Text = "Billing";
            // 
            // User
            // 
            User.AutoSize = true;
            User.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            User.ForeColor = Color.White;
            User.Location = new Point(48, 9);
            User.Name = "User";
            User.Size = new Size(46, 23);
            User.TabIndex = 33;
            User.Text = "User";
            User.Click += label8_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(886, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 33;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(927, 543);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(User);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Billing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing";
            Load += Billing_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ItemDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BillDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView BillDGV;
        private Button Clear;
        private Button button4;
        private Button AddToBill;
        private TextBox ItPriceTb;
        private TextBox ItClNameTb;
        private TextBox ItQtyTb;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox ItNameTb;
        private Label label4;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label TotalBill;
        private Guna.UI2.WinForms.Guna2DataGridView ItemDGV;
        private Label User;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label label8;
    }
}