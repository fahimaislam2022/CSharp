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
    public partial class sellerlogin : Form
    {
        public sellerlogin()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Login lg = new Login();

            lg.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sellerregistration sel = new sellerregistration();
            sel.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.TextLength < 7 || string.IsNullOrEmpty(textBox1.Text) == true || string.IsNullOrEmpty(textBox2.Text) == true)
            {
                MessageBox.Show("Please fill all the information correctly.");

            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-IL3V7IAK\\SQLEXPRESS;Initial Catalog=sellerregistration;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
                SqlDataAdapter sql = new SqlDataAdapter("SELECT * FROM seller_registration WHERE ID = '" + textBox1.Text + "' AND Password = '" + textBox2.Text + "'", conn);

                DataTable dt = new DataTable();
                sql.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Welcome seller!");

                    selleritemadd selleritemadd = new selleritemadd();
                    selleritemadd.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Wrong ID or Password!!");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
