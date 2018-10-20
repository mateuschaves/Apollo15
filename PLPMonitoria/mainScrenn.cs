using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLPMonitoria
{
    public partial class mainScrenn : Form
    {
        public string login;

        public mainScrenn()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainScrenn_Load(object sender, EventArgs e)
        {
            lblApresetation.Text = "Oiiee " + this.login + ", o que deseja fazer ? ";
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            newOrder no = new newOrder();
            no.Show();
            this.Hide();
        }

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{

		}
	}
}
