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
    public partial class Foodbuyphase : Form
    {
        public Foodbuyphase()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Foodinfouser f = new Foodinfouser();
            f.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
