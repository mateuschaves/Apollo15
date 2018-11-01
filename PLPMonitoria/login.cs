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
			// String de conection com o banco de dados
			string strConection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\mateus\Documents\Apollo15\Apollo15.mdb";
			//string strConection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Aline\Desktop\Apollo15\Apollo15.mdb";
		//	string strConection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Daniel Victor\Documents\Apollo15\Apollo15.mdb";
			// Checkbox no banco de dados
			try
			{
				OleDbConnection conecting = new OleDbConnection(strConection);
				conecting.Open();

				if (checkBox1.Checked == true)
				{
					string sqlcheckbox2 = @"UPDATE login SET checked =  '" + "true" + "'";
					OleDbCommand cmd2 = new OleDbCommand(sqlcheckbox2, conecting);
					cmd2.ExecuteNonQuery();
				}
				else
				{
					string sqlcheckbox2 = @"UPDATE login SET checked =  '" + "false" + "'";
					OleDbCommand cmd2 = new OleDbCommand(sqlcheckbox2, conecting);
					cmd2.ExecuteNonQuery();
				}

				// Pegando o login e a senha pra checar se estão corretas!
				string sqlverifica = "SELECT * FROM login";
				OleDbCommand cmd = new OleDbCommand(sqlverifica, conecting);
				OleDbDataReader read = cmd.ExecuteReader();
				read.Read();

				if (txtLogin.Text.Equals(read["loginName"].ToString()) && txtPassword.Text.Equals(read["senha"].ToString()))
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

				// Fechando o banco de dados
				conecting.Close();
			}
			catch
			{
				MessageBox.Show("Erro ao fazer conexão com o banco de dado (login/update)");
			}

        }

		private void login_Load(object sender, EventArgs e)
		{
			try
			{
				// String de conection com o banco de dados
				string strConection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\mateus\Documents\Apollo15\Apollo15.mdb";
				// Conectando com o banco de dados
				OleDbConnection conecting = new OleDbConnection(strConection);
				// Abrindo o banco de dados
				conecting.Open();

				string sqllogin = "SELECT * FROM login";
				OleDbCommand cmd = new OleDbCommand(sqllogin, conecting);
				OleDbDataReader read = cmd.ExecuteReader();
				read.Read();

				if (read["checked"].ToString() == "true")
				{
					checkBox1.Checked = true;
					txtLogin.Text = Convert.ToString(read["loginName"].ToString());
				}
				else
				{
					txtLogin.Text = "";
				}
				// Fechando o banco de dados
				conecting.Close();
			}
			catch
			{
				MessageBox.Show("Erro ao fazer conexão com o banco de dado (login/save)");
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			
		}
	}
}
