using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_Store
{
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=MYSTERIOUS;Initial Catalog=""Grocery Shop"";Integrated Security=True");

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
        private void Clear()
        {
            ItNameTb.Text = "";
            ItQtyTb.Text = "";
            ItPriceTb.Text = "";
            CatCb.SelectedIndex = -1;
            key = 0;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ItNameTb.Text == "" || ItQtyTb.Text == "" || ItPriceTb.Text == "" || CatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO ItemTbl (ItName, ItQty, ItPrice, ItCat) VALUES (@ItemName, @Quantity, @Price, @Category)", Con);
                    cmd.Parameters.AddWithValue("@ItemName", ItNameTb.Text);
                    cmd.Parameters.AddWithValue("@Quantity", ItQtyTb.Text);
                    cmd.Parameters.AddWithValue("@Price", ItPriceTb.Text);
                    cmd.Parameters.AddWithValue("@Category", CatCb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Saved Successfully");

                    Con.Close();
                    populate();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }
        int key = 0;
        private void ItemDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ItemDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ItNameTb.Text = ItemDGV.SelectedRows[0].Cells[1].Value.ToString();
            ItQtyTb.Text = ItemDGV.SelectedRows[0].Cells[2].Value.ToString();
            ItPriceTb.Text = ItemDGV.SelectedRows[0].Cells[3].Value.ToString();
            CatCb.SelectedItem = ItemDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (ItNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ItemDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the Item to Delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from ItemTbl where ItId=" + key + ";", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Deleted Successfully");
                    Con.Close();
                    populate();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (ItNameTb.Text == "" || ItQtyTb.Text == "" || ItPriceTb.Text == "" || CatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update ItemTbl set ItName=@ItemName, ItQty=@Quantity, ItPrice=@Price, ItCat=@Category where ItId=@ItId", Con);
                    cmd.Parameters.AddWithValue("@ItemName", ItNameTb.Text);
                    cmd.Parameters.AddWithValue("@Quantity", ItQtyTb.Text);
                    cmd.Parameters.AddWithValue("@Price", ItPriceTb.Text);
                    cmd.Parameters.AddWithValue("@Category", CatCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ItId", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Updated Successfully");

                    Con.Close();
                    populate();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees();
            emp.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees();
            emp.Show();
            this.Hide();
        }
    }
}
