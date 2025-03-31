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
    public partial class admin_registration : Form
    {
        public admin_registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            


                if (string.IsNullOrEmpty(textBox1.Text) == true || string.IsNullOrEmpty(textBox2.Text) == true || string.IsNullOrEmpty(textBox3.Text) == true || string.IsNullOrEmpty(textBox4.Text) == true || string.IsNullOrEmpty(comboBox1.Text) == true)
                {
                    MessageBox.Show("Please enter all the details!");

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
                    SqlConnection conn = new SqlConnection("Data Source=LAPTOP-IL3V7IAK\\SQLEXPRESS;Initial Catalog=adminregister;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
                    conn.Open();

                    string insertcmd = "INSERT INTO adminregister (ID, Email, Password, Confirm_password, Birthdate, Gender) VALUES (@ID, @Email, @Password, @Confirm_password, @Birthdate, @Gender)";

                    SqlCommand cmd = new SqlCommand(insertcmd, conn);
                    cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Email", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Confirm_password", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Birthdate", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Gender", comboBox1.SelectedItem.ToString());


                    

                    cmd.ExecuteNonQuery();

                    conn.Close();
                    MessageBox.Show("Confirm successful!!");
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This ID has already been used!");
                }
                }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
    }
}
