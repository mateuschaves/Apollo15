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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text.Equals("admin") && txtPassword.Text.Equals("admin"))
            {
                MessageBox.Show("UHUUUU");
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos. Tente novamente !");
            }
        }
    }
}
