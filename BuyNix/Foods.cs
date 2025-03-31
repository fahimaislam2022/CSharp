using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMArketManagementSystem_BuyNix_
{
    public partial class Foods : Form
    {
        public Foods()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemview itemview = new itemview();
            itemview.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (string.IsNullOrEmpty(textBox1.Text) == true || string.IsNullOrEmpty(textBox2.Text) == true || string.IsNullOrEmpty(textBox3.Text) == true || string.IsNullOrEmpty(textBox3.Text) == true)
            {
                MessageBox.Show("Please Insert all the infromation Correctly!");

            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=LAPTOP-IL3V7IAK\\SQLEXPRESS;Initial Catalog=foods;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
                    conn.Open();

                    string insertcmd = "INSERT INTO foods (Product_ID, Item_name, Category, Quantity, Date, Price) VALUES (@Product_ID, @Item_name, @Category, @Quantity, @Date, @Price)";

                    SqlCommand cmd = new SqlCommand(insertcmd, conn);

                    try
                    {
                        cmd.Parameters.AddWithValue("@Product_ID", Convert.ToInt32(textBox1.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Put integer values like 101 or 102!");

                    }

                    cmd.Parameters.AddWithValue("@Item_name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Category", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Quantity", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Price", textBox5.Text);



                    cmd.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Insertion successful!!");

                    Binddata();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This ID has already been used!");
                }
            }


        }
        void Binddata()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-IL3V7IAK\\SQLEXPRESS;Initial Catalog=foods;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");

            SqlCommand cmd = new SqlCommand("SELECT * FROM foods", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            sd.Fill(dt);
            dataGridView1.DataSource = dt;




        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                MessageBox.Show("Please enter a Product ID to delete!");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {


                    SqlConnection conn = new SqlConnection("Data Source=LAPTOP-IL3V7IAK\\SQLEXPRESS;Initial Catalog=foods;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
                    conn.Open();

                    string deletecmd = "DELETE FROM foods WHERE Product_ID = @Product_ID";

                    SqlCommand cmd = new SqlCommand(deletecmd, conn);
                    cmd.Parameters.AddWithValue("@Product_ID", textBox1.Text.ToString());

                    MessageBox.Show("Deletion successful!");

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    Binddata();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true || string.IsNullOrEmpty(textBox2.Text) == true || string.IsNullOrEmpty(textBox3.Text) == true || string.IsNullOrEmpty(textBox3.Text) == true)
            {
                MessageBox.Show("Please Insert all the indromation Correctly!");

            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=LAPTOP-IL3V7IAK\\SQLEXPRESS;Initial Catalog=foods;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");

                    conn.Open();

                    string updatecmd = "UPDATE foods SET Item_name = @Item_name, Category = @category, Quantity = @Quantity, Date = @Date , Price=@Price WHERE Product_ID = @Product_ID";

                    SqlCommand cmd = new SqlCommand(updatecmd, conn);

                    cmd.Parameters.AddWithValue("@Product_ID", textBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@Item_name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Category", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Quantity", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Price", textBox5.Text);



                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Update successful!");
                    Binddata();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid details!");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                MessageBox.Show("Please enter a Product ID to search!");
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-IL3V7IAK\\SQLEXPRESS;Initial Catalog=foods;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
                conn.Open();

                string searchcmd = "SELECT * FROM foods WHERE Product_ID = @Product_ID";

                SqlCommand cmd = new SqlCommand(searchcmd, conn);
                cmd.Parameters.AddWithValue("@Product_ID", textBox1.Text.ToString());

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox2.Text = reader["Item_name"].ToString();
                    textBox3.Text = reader["Category"].ToString();
                    textBox4.Text = reader["Quantity"].ToString();
                    textBox5.Text = reader["Price"].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(reader["Date"]);
                }
                else
                {
                    MessageBox.Show("No record found!");
                }

                reader.Close();
                conn.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Binddata();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            selleritemadd selleritemadd = new selleritemadd();
            selleritemadd.Show();
            this.Hide();
        }
    }

}
