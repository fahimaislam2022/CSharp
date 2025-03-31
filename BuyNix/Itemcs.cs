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
    public partial class Itemcs : Form
    {
        public Itemcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Foodinfouser food = new Foodinfouser();
            food.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gadgetinfouser g = new Gadgetinfouser();
            g.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fashioninfouser f = new Fashioninfouser();
            f.Show();
            this.Hide();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
