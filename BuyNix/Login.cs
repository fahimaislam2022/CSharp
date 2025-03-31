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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SuperMArketManagementSystem_BuyNix_
{


    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin admn = new Admin();
            admn.Show();
            this.Hide();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registration rg = new registration();
            rg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text) == true || string.IsNullOrEmpty(textBox2.Text) == true)
            {
                MessageBox.Show("Please fill all the information correctly.");

            }

            else
            {



                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-IL3V7IAK\\SQLEXPRESS;Initial Catalog=Registerform;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
                SqlDataAdapter sql = new SqlDataAdapter("SELECT * FROM register WHERE UserName ='" + textBox1.Text + "' AND Password = '" + textBox2.Text + "'", conn);





                DataTable dt2 = new DataTable();
                sql.Fill(dt2);

                if (dt2.Rows.Count > 0)
                {
                    MessageBox.Show("WELCOME!!");
                    Itemcs item = new Itemcs();
                    item.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect password or username!!");
                }
            }

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sellerlogin sellerlogin = new sellerlogin();
            sellerlogin.Show();
            this.Hide();
        }
    }
}
