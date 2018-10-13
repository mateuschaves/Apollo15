using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

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
            if(txtLogin.Text.Equals("Mateus") && txtPassword.Text.Equals("123"))
            {
                mainScrenn ms = new mainScrenn();
                ms.login = txtLogin.Text;
                ms.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos. Tente novamente !");
            }
        }

		private void login_Load(object sender, EventArgs e)
		{
			string strConection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Aline\Desktop\Apollo15\Apollo15.mdb";
			OleDbConnection conecting = new OleDbConnection(strConection);
			try
			{
				// Abrindo o banco de dados
				conecting.Open();
			} 
			catch (Exception erro)
			{
				MessageBox.Show(erro.Message);
			}
		}
	}
}
