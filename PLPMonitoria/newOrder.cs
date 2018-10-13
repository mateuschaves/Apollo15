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
	public partial class newOrder : Form
	{
		public newOrder()
		{
			InitializeComponent();
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void dataOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			// Checando se o numero de produto é maior que zero
			if (numAmount.Value != 0)
			{
				// Checando se foi selecionada alguma comida
				if (cmbFood.SelectedIndex != -1)
				{
					dataOrder.Rows.Add(cmbFood.SelectedItem.ToString(), numAmount.Value.ToString(), 0);
				}
				else
				{
					MessageBox.Show("Campo \"Pratos\" obrigatório! ");

				}
			}
			// Checando se o numero de produto é maior que zero
			if (numDrink.Value != 0)
			{
				// Checando se foi selecionada alguma comida
				if (cmbDrink.SelectedIndex != -1)
				{
					dataOrder.Rows.Add(cmbDrink.SelectedItem.ToString(), numDrink.Value.ToString(), 0);
				}
				else
				{
					MessageBox.Show("Campo \"Bebidas\" obrigatório! ");

				}
			}

			if (txtName.Text != "")
			{
				lblDetails.Text = "Detalhes do pedido de " + txtName.Text.ToString();
			}
			else
			{
				MessageBox.Show("Campo \"Nome\" obrigatório! ");
				txtTable.Text = "";
			}

			// Conectando com o banco de dados
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

			if (txtName.Text != "")
			{
				// Adicionando informações ao banco de dados
				string SQL = "Insert Into Client(nome, board_number) values ('" + txtName.Text + "', '" + txtTable.Text + "')";
				OleDbCommand comando = new OleDbCommand(SQL, conecting);
				comando.ExecuteNonQuery();
				// Fechando o banco de dados
				conecting.Close();
			}
			
			// Limpando dados
			cmbFood.Text = "";
			cmbDrink.Text = "";
			numAmount.Value = 0;
			numDrink.Value = 0;
		}

		private ComboBox GetCmbFood()
		{
			return cmbFood;
		}
		private void btnFinalizar_Click(object sender, EventArgs e)
		{
			MessageBox.Show("\n Pedido realizado!");
			mainScrenn go = new mainScrenn();
			go.Show();
			this.Hide();
		}
	}
}
