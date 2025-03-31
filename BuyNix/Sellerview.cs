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

namespace SuperMArketManagementSystem_BuyNix_
{
    public partial class Sellerview : Form
    {
        public Sellerview()
        {
            InitializeComponent();
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
                    SqlConnection conn = new SqlConnection("Data Source=LAPTOP-IL3V7IAK\\SQLEXPRESS;Initial Catalog=sellerregistration;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
                    conn.Open();

                    string insertcmd = "INSERT INTO seller_registration (ID,Email,Password,Confirm_password,Birthdate,Gender) VALUES (@ID, @Email, @Password, @Confirm_password, @Birthdate, @Gender )";

                    SqlCommand cmd = new SqlCommand(insertcmd, conn);
                    try
                    {
                        cmd.Parameters.AddWithValue("@ID", textBox1.Text.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("This ID has already been used!");
                    }
                    cmd.Parameters.AddWithValue("@Email",textBox4.Text);
                    cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Confirm_password", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Birthdate", dateTimePicker2.Value);
                    cmd.Parameters.AddWithValue("@Gender", comboBox1.SelectedItem.ToString());




                    cmd.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Insertion successful!!");

                    Binddata1();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("This ID has already been used!");

                }

            }


        }
        void Binddata1()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-IL3V7IAK\\SQLEXPRESS;Initial Catalog=sellerregistration;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");

            SqlCommand cmd = new SqlCommand("SELECT * FROM seller_registration", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Binddata1();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Viewpage viewpage = new Viewpage();
            viewpage.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true || string.IsNullOrEmpty(textBox2.Text) == true || string.IsNullOrEmpty(textBox3.Text) == true || string.IsNullOrEmpty(comboBox1.Text) == true)
            {
                MessageBox.Show("Please Insert all the infromation Correctly!");

            }
            else
            {

                try
              {

                    SqlConnection conn = new SqlConnection("Data Source=LAPTOP-IL3V7IAK\\SQLEXPRESS;Initial Catalog=sellerregistration;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");

                    conn.Open();

                    string updatecmd = "UPDATE seller_registration SET ID = @ID, Email=@Email, Password = @Password, Confirm_Password = @Confirm_Password, Birthdate = @Birthdate , Gender=@Gender WHERE ID = @ID";

                    SqlCommand cmd = new SqlCommand(updatecmd, conn);
                    try
                    {
                        cmd.Parameters.AddWithValue("@ID", textBox1.Text.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Put another value!");

                    }
                    cmd.Parameters.AddWithValue("Email",textBox4.Text);
                    cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Confirm_Password", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Birthdate", dateTimePicker2.Value);
                    cmd.Parameters.AddWithValue("@Gender", comboBox1.SelectedItem.ToString());



                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Update successful!");

                    Binddata1();

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
                MessageBox.Show("Please enter an ID to delete!");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    SqlConnection conn = new SqlConnection("Data Source=LAPTOP-IL3V7IAK\\SQLEXPRESS;Initial Catalog=sellerregistration;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
                    conn.Open();

                    string deletecmd = "DELETE FROM seller_registration WHERE ID = @ID";

                    SqlCommand cmd = new SqlCommand(deletecmd, conn);
                    cmd.Parameters.AddWithValue("@ID", textBox1.Text.ToString());

                    MessageBox.Show("Deletion successful!");

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    Binddata1();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                MessageBox.Show("Please enter an ID to search!");
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-IL3V7IAK\\SQLEXPRESS;Initial Catalog=sellerregistration;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
                conn.Open();

                string searchcmd = "SELECT * FROM seller_registration WHERE ID = @ID";

                SqlCommand cmd = new SqlCommand(searchcmd, conn);
                cmd.Parameters.AddWithValue("@ID", textBox1.Text.ToString());

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox4.Text = reader["Email"].ToString();
                    textBox2.Text = reader["Password"].ToString();
                    textBox3.Text = reader["Confirm_Password"].ToString();
                    dateTimePicker2.Value = Convert.ToDateTime(reader["Birthdate"]);
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
    }
}
