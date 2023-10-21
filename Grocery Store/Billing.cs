using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_Store
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            populate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=MYSTERIOUS;Initial Catalog=""Grocery Shop"";Integrated Security=True");
        int stock = 0;

        private void populate()
        {
            Con.Open();
            string query = "select * from ItemTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        int n = 0, GrdTotal = 0, Amount;
        private void AddToBill_Click(object sender, EventArgs e)
        {
            // Check for empty fields
            if (string.IsNullOrWhiteSpace(ItQtyTb.Text) || string.IsNullOrWhiteSpace(ItPriceTb.Text) || string.IsNullOrWhiteSpace(ItNameTb.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
            }
            else
            {
                // Check if input is a valid number
                if (!int.TryParse(ItQtyTb.Text, out int quantity) || !int.TryParse(ItPriceTb.Text, out int price))
                {
                    MessageBox.Show("Please enter valid numeric values for Quantity and Price.");
                }
                else
                {
                    // Perform calculations and add to the DataGridView
                    int total = quantity * price;
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(BillDGV);
                    newRow.Cells[0].Value = n + 1;
                    newRow.Cells[1].Value = ItNameTb.Text;
                    newRow.Cells[2].Value = ItPriceTb.Text;
                    newRow.Cells[3].Value = ItQtyTb.Text;
                    newRow.Cells[4].Value = total;
                    BillDGV.Rows.Add(newRow);
                    GrdTotal = GrdTotal + total;
                    Amount = GrdTotal;
                    TotalBill.Text = "Rs. " + GrdTotal;
                    n++;
                    UpdateQty();
                    Reset();
                }
            }

        }
        private void UpdateQty()
        {
            try
            {
                int newQty = stock - Convert.ToInt32(ItQtyTb.Text);
                Con.Open();
                string query = "update ItemTbl set ItQty=" + newQty + "where ItId=" + key + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Updated Successfully");
                Con.Close();
                populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int key = 0;
        private void ItemDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ItNameTb.Text = ItemDGV.SelectedRows[0].Cells[1].Value.ToString();
            ItPriceTb.Text = ItemDGV.SelectedRows[0].Cells[3].Value.ToString();
            ItQtyTb.Text = ItemDGV.SelectedRows[0].Cells[2].Value.ToString();

            if (ItNameTb.Text == "")
            {
                stock = 0;
                key = 0;
            }
            else
            {
                stock = Convert.ToInt32(ItemDGV.SelectedRows[0].Cells[2].Value.ToString());
                key = Convert.ToInt32(ItemDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void Reset()
        {
            ItPriceTb.Text = "";
            ItQtyTb.Text = "";
            ItNameTb.Text = "";
            ItClNameTb.Text = "";
        }

        private void Reset_Click(object sender, EventArgs e)
        {

            BillDGV.Rows.Clear();
        }
        SqlConnection Conn = new SqlConnection(@"Data Source=MYSTERIOUS;Initial Catalog=""Grocery Shop"";Integrated Security=True");

        private void button4_Click(object sender, EventArgs e)
        {
            if (ItClNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into BillTbl values('" + Login.EmployeeName + "','" + ItClNameTb.Text + "'," + Amount + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Added Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void Billing_Load(object sender, EventArgs e)
        {
            //Login log = new Login();
            User.Text = Login.EmployeeName;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Calculate the total and draw each item on the bill
            int startY = 100;
            int offset = 20;
            int pos = 100;
            Amount = 0;

            foreach (DataGridViewRow row in BillDGV.Rows)
            {
                int prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                string prodname = "" + row.Cells["Column2"].Value;
                int prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
                int prodqty = Convert.ToInt32(row.Cells["Column4"].Value);
                int total = Convert.ToInt32(row.Cells["Column5"].Value);
                if (e.Graphics != null)
                {
                    e.Graphics.DrawString("ID: " + prodid, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, pos, startY + offset);
                    // Add other drawing operations here
                    e.Graphics.DrawString("Name: " + prodname, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, pos + 80, startY + offset);
                    e.Graphics.DrawString("Price: Rs " + prodprice, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, pos + 250, startY + offset);
                    e.Graphics.DrawString("Qty: " + prodqty, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, pos + 350, startY + offset);
                    e.Graphics.DrawString("Total: Rs " + total, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, pos + 450, startY + offset);
                }

                // Draw product ID, name, price, quantity, and total


                offset += 20; // Adjust the vertical position for the next line
                Amount += total;
            }

            // Draw the grand total
            offset += 20; // Add some space between the items and the total
            if (e.Graphics != null)
            {
                e.Graphics.DrawString("Grand Total: Rs " + Amount, new Font("Century Gothic", 16, FontStyle.Bold), Brushes.Black, pos, startY + offset);
            }
            // Draw additional content
            offset += 40;
            if (e.Graphics != null)
            {
                e.Graphics.DrawString("****** GroceryShop ***********", new Font("Century Gothic", 16, FontStyle.Bold), Brushes.Black, pos, startY + offset);

            }
            // Clear the DataGridView and reset the position and total
            BillDGV.Rows.Clear();
            BillDGV.Refresh();
            pos = 100;
            Amount = 0;

        }

        private void label8_Click_2(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();

        }
    }
}
