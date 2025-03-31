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
    public partial class itemview : Form
    {
        public itemview()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Viewpage viewpage = new Viewpage();
            viewpage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gadgets gadgets = new Gadgets();
            gadgets.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Foods foods = new Foods();
            foods.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            fashioncs fas = new fashioncs();
            fas.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Foods foods1 = new Foods();
            foods1.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Gadgets gd = new Gadgets();
            gd.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fashioncs fashion = new fashioncs();
            fashion.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
