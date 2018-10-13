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
			if (numFood.Value != 0)
			{
				// Checando se foi selecionada alguma comida
				if (cmbFood.SelectedIndex != -1)
				{
					if (txtTable.Text != "")
					{
						if (txtName.Text != "")
						{
							lblDetails.Text = "Detalhes do pedido de " + txtName.Text.ToString();
							dataOrder.Rows.Add(cmbFood.SelectedItem.ToString(), numFood.Value.ToString(), 0);
						}
						else
						{
							MessageBox.Show("Campo \"Nome\" obrigatório! ");
							txtTable.Text = "";
						}
					}
					else
					{
						MessageBox.Show("Campo \"Mesa\" obrigatório! ");
					}
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
					if (txtTable.Text != "")
					{
						if (txtName.Text != "")
						{
							lblDetails.Text = "Detalhes do pedido de " + txtName.Text.ToString();
							dataOrder.Rows.Add(cmbDrink.SelectedItem.ToString(), numDrink.Value.ToString(), 0);
						}
						else
						{
							MessageBox.Show("Campo \"Nome\" obrigatório! ");
							txtTable.Text = "";
						}
					}
					else
					{
						MessageBox.Show("Campo \"Mesa\" obrigatório! ");
					}
				}
				else
				{
					MessageBox.Show("Campo \"Bebidas\" obrigatório! ");

				}
			}

			// Conectando com o banco de dados
			string strConection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Aline\Desktop\Apollo15\Apollo15.mdb";
			OleDbConnection conecting = new OleDbConnection(strConection);
			try
			{
				// Abrindo o banco de dados
				conecting.Open();
				if (txtName.Text != "" & txtTable.Text != "")
				{
					/*
					string cmd1 = "SELECT id fROM Drink WHERE nome = cmbFood.SelectedItem";
				    string cmd2 = "SELECT id fROM Food WHERE nome = cmbDrink.SelectedItem";

					OleDbDataAdapter adpter = new OleDbDataAdapter(cmd1, conecting);
					OleDbDataAdapter adpter2 = new OleDbDataAdapter(cmd2, conecting);
					

					OleDbCommand comand1 = new OleDbCommand(cmd1, conecting);
					OleDbCommand comand2 = new OleDbCommand(cmd2, conecting);
					OleDbDataReader read_id_food = comand1.ExecuteReader();
					OleDbDataReader read_id_drink = comand2.ExecuteReader();

					read_id_food.Read();
					read_id_drink.Read();
					comand1.ExecuteNonQuery();
					comand2.ExecuteNonQuery();
					*/


					// Adicionando informações ao banco de dados
					string SQL = "Insert Into Orders(client, board_number, spent, amount_food, amount_drink) Values";
					SQL += "('"+txtName.Text+"','"+ txtTable.Text+"','"+0+"','"+numFood.Value+"','"+numDrink.Value+"')";
					

					OleDbCommand comando = new OleDbCommand(SQL, conecting);
					comando.ExecuteNonQuery();
					// Fechando o banco de dados
					conecting.Close();
				}
			}
			catch (Exception erro)
			{
				MessageBox.Show(erro.Message);
			}

			// Limpando dados
			cmbFood.SelectedIndex = -1;
			cmbDrink.SelectedIndex = -1;
			numFood.Value = 0;
			numDrink.Value = 0;
		}

		private ComboBox GetCmbFood()
		{
			return cmbFood;
		}
		private void btnFinalizar_Click(object sender, EventArgs e)
		{
			// Checando se foi adicionado algum pedido
			if (dataOrder.RowCount != 0)
			{
				MessageBox.Show("\n Pedido realizado!");
			}
			mainScrenn go = new mainScrenn();
			go.Show();
			this.Hide();
		}

		private void txtTable_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
