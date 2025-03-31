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
    public partial class Gadgetinfouser : Form
    {
        public Gadgetinfouser()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Itemcs itemcs = new Itemcs();
            itemcs.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                MessageBox.Show("Search the item you need!");
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-IL3V7IAK\\SQLEXPRESS;Initial Catalog=gadgets;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
                conn.Open();

                string searchcmd = "SELECT * FROM gadgets WHERE Gadget_name = @Gadget_name";

                SqlCommand cmd = new SqlCommand(searchcmd, conn);
                cmd.Parameters.AddWithValue("@Gadget_name", textBox1.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox2.Text = reader["Gadget_name"].ToString();
                    textBox3.Text = reader["Design"].ToString();
                    textBox4.Text = reader["Color"].ToString();
                    textBox5.Text = reader["Price"].ToString();

                    //dateTimePicker1.Value = Convert.ToDateTime(reader["Date"]);
                }
                else
                {
                    MessageBox.Show("Not available!");
                }

                reader.Close();
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox5.Text);
            double b = Convert.ToDouble(textBox6.Text);



            if (a > b)
            {
                MessageBox.Show("Payment Unsucessful!");
            }
            else
            {
                double c = b - a;

                string d = Convert.ToString(c);

                textBox7.Text = d;

                MessageBox.Show("Payment successful!!");


                Itemcs itemcs = new Itemcs();
                itemcs.Show();
                this.Hide();


            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
