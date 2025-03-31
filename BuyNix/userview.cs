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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SuperMArketManagementSystem_BuyNix_
{
    public partial class userview : Form
    {
        public userview()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Viewpage view = new Viewpage();
            view.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true || string.IsNullOrEmpty(textBox2.Text) == true || string.IsNullOrEmpty(textBox3.Text) == true || string.IsNullOrEmpty(comboBox1.Text) == true)
            {
                MessageBox.Show("Please!! Enter full details of user.");

            }

            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=LAPTOP-IL3V7IAK\\SQLEXPRESS;Initial Catalog=Registerform;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
                    conn.Open();

                    string insertcmd = "INSERT INTO register (UserName, Password, Confirm_Password, Birth_date, Gender) VALUES (@UserName, @Password, @Confirm_Password, @Birth_date, @Gender)";

                    SqlCommand cmd = new SqlCommand(insertcmd, conn);
                    try
                    {
                        cmd.Parameters.AddWithValue("@UserName", textBox1.Text.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("This username has already been used!");
                    }
                    cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Confirm_Password", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Birth_date", dateTimePicker2.Value);
                    cmd.Parameters.AddWithValue("@Gender", comboBox1.SelectedItem.ToString());




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
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-IL3V7IAK\\SQLEXPRESS;Initial Catalog=Registerform;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");

            SqlCommand cmd = new SqlCommand("SELECT * FROM register", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            sd.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Binddata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true || string.IsNullOrEmpty(textBox2.Text) == true || string.IsNullOrEmpty(textBox3.Text) == true || string.IsNullOrEmpty(comboBox1.Text) == true)
            {
                MessageBox.Show("Please Insert all the indromation Correctly!");

            }
            else
            {

                try
                {

                    SqlConnection conn = new SqlConnection("Data Source=LAPTOP-IL3V7IAK\\SQLEXPRESS;Initial Catalog=Registerform;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");

                    conn.Open();

                    string updatecmd = "UPDATE register SET UserName = @UserName, Password = @Password, Confirm_Password = @Confirm_Password, Birth_date = @Birth_date , Gender=@Gender WHERE UserName = @UserName";

                    SqlCommand cmd = new SqlCommand(updatecmd, conn);
                    try
                    {
                        cmd.Parameters.AddWithValue("@UserName", textBox1.Text.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Put another value!");

                    }

                    cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Confirm_Password", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Birth_date", dateTimePicker2.Value);
                    cmd.Parameters.AddWithValue("@Gender", comboBox1.SelectedItem.ToString());



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

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                MessageBox.Show("Please enter a Product ID to delete!");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    SqlConnection conn = new SqlConnection("Data Source=LAPTOP-IL3V7IAK\\SQLEXPRESS;Initial Catalog=Registerform;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
                    conn.Open();

                    string deletecmd = "DELETE FROM register WHERE UserName = @UserName";

                    SqlCommand cmd = new SqlCommand(deletecmd, conn);
                    cmd.Parameters.AddWithValue("@Username", textBox1.Text.ToString());

                    MessageBox.Show("Deletion successful!");

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    Binddata();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                MessageBox.Show("Please enter a User Name to search!");
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-IL3V7IAK\\SQLEXPRESS;Initial Catalog=Registerform;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
                conn.Open();

                string searchcmd = "SELECT * FROM register WHERE UserName = @UserName";

                SqlCommand cmd = new SqlCommand(searchcmd, conn);
                cmd.Parameters.AddWithValue("@Username", textBox1.Text.ToString());

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox2.Text = reader["Password"].ToString();
                    textBox3.Text = reader["Confirm_Password"].ToString();
                    dateTimePicker2.Value = Convert.ToDateTime(reader["Birth_date"]);
                    comboBox1.Text = reader["Gender"].ToString();

                }
                else
                {
                    MessageBox.Show("No record found!");
                }

                reader.Close();
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
