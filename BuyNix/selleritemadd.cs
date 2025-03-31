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
    public partial class selleritemadd : Form
    {
        public selleritemadd()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            sellerlogin sellerlogin = new sellerlogin();
            sellerlogin.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Foods foods = new Foods();
            foods.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gadgets gadgets = new Gadgets();
            gadgets.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fashioncs fashioncs = new fashioncs();
            fashioncs.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
