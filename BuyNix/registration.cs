using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Win32;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace SuperMArketManagementSystem_BuyNix_
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true || string.IsNullOrEmpty(textBox2.Text) == true || string.IsNullOrEmpty(textBox3.Text) == true || string.IsNullOrEmpty(comboBox1.Text) == true)
            {
                MessageBox.Show("Please!! Enter your full details.");

            }
            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Password incorrect!!");

            }
            else if (textBox2.TextLength < 3 && textBox3.TextLength < 3)
            {
                MessageBox.Show("Password length must be more than 3!!");
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
                    cmd.Parameters.AddWithValue("@Birth_date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Gender", comboBox1.SelectedItem.ToString());




                    cmd.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Confirm successful!!");

                    Login lg = new Login();
                    lg.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("This ID has already been used!");

                }

                /*try
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO login (UserName, Password) SELECT UserName,Password from register ", conn);

                    cmd2.ExecuteNonQuery();

                    // SqlDataAdapter sql = new SqlDataAdapter("SELECT * FROM login WHERE UserName ='" + textBox1.Text + "' AND Password = '" + textBox2.Text + "'", conn);




                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!");

                }*/

            }




        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
