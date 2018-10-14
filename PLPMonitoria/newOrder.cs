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
			// String de conection com o banco de dados
			string strConection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Aline\Desktop\Apollo15\Apollo15.mdb";

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
							// Conectando com o banco de dados
							try
							{	
								OleDbConnection conecting = new OleDbConnection(strConection);
								// Abrindo o banco de dados
								conecting.Open();

								string cmd1 = @"SELECT price fROM Food WHERE nome = '"+cmbFood.SelectedItem.ToString()+"'";
								OleDbCommand comand = new OleDbCommand(cmd1, conecting);
								OleDbDataReader read_price_food = comand.ExecuteReader();
								read_price_food.Read();

								lblDetails.Text = "Detalhes do pedido de " + txtName.Text.ToString();
								dataOrder.Rows.Add(cmbFood.SelectedItem.ToString(), numFood.Value.ToString(), "R$ " + read_price_food["price"]);


								// Fechando o banco de dados
								conecting.Close();
							}
							catch (Exception erro)
							{
								MessageBox.Show(erro.Message);
							}
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
							// Conectando com o banco de dados
							try
							{
								OleDbConnection conecting = new OleDbConnection(strConection);
								// Abrindo o banco de dados
								conecting.Open();

								string cmd1 = @"SELECT price fROM Drink WHERE nome = '" + cmbDrink.SelectedItem.ToString() + "'";
								OleDbCommand comand= new OleDbCommand(cmd1, conecting);
								OleDbDataReader read_price_drink = comand.ExecuteReader();
								read_price_drink.Read();

								lblDetails.Text = "Detalhes do pedido de " + txtName.Text.ToString();
								dataOrder.Rows.Add(cmbDrink.SelectedItem.ToString(), numDrink.Value.ToString(), "R$ " + read_price_drink["price"]);
							}
							catch (Exception erro)
							{
								MessageBox.Show(erro.Message);
							}
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


			if (txtName.Text != "" & txtTable.Text != "")
			{
				try {
					// Conectando com o banco de dados
					OleDbConnection conecting = new OleDbConnection(strConection);
					// Abrindo o banco de dados
					conecting.Open();


					if (numDrink.Value != 0 & cmbDrink.SelectedIndex != -1 & numFood.Value != 0 & cmbFood.SelectedIndex != -1)
					{
						string cmd1 = @"SELECT id fROM Drink WHERE nome = '" + cmbDrink.SelectedItem.ToString() + "'";
						string cmd2 = @"SELECT id fROM Food WHERE nome = '" + cmbFood.SelectedItem.ToString() + "'";
						OleDbCommand comand1 = new OleDbCommand(cmd1, conecting);
						OleDbCommand comand2 = new OleDbCommand(cmd2, conecting);
						OleDbDataReader read_id_drink = comand1.ExecuteReader();
						read_id_drink.Read();
						OleDbDataReader read_id_food = comand2.ExecuteReader();
						read_id_food.Read();

						// Adicionando informações ao banco de dados
						string SQL = "Insert Into Orders(status, client, board_number, spent, food_id, amount_food, drink_id, amount_drink) Values";
						SQL += "('Em andamento','" + txtName.Text + "','" + txtTable.Text + "','" + 0 + "','" + read_id_food["id"] + "','" + numFood.Value + "','" + read_id_drink["id"] + "','" + numDrink.Value + "')";
						OleDbCommand comando = new OleDbCommand(SQL, conecting);
						comando.ExecuteNonQuery();
					}
					else if (numDrink.Value == 0 & cmbDrink.SelectedIndex == -1)
					{
						string cmd2 = @"SELECT id fROM Food WHERE nome = '" + cmbFood.SelectedItem.ToString() + "'";
						OleDbCommand comand2 = new OleDbCommand(cmd2, conecting);
						OleDbDataReader read_id_food = comand2.ExecuteReader();
						read_id_food.Read();

						// Adicionando informações ao banco de dados
						string SQL = "Insert Into Orders(status, client, board_number, spent, food_id, amount_food, drink_id, amount_drink) Values";
						SQL += "('Em andamento','" + txtName.Text + "','" + txtTable.Text + "','" + 0 + "','" + read_id_food["id"] + "','" + numFood.Value + "','" + 0 + "','" + 0 + "')";
						OleDbCommand comando = new OleDbCommand(SQL, conecting);
						comando.ExecuteNonQuery();
					}
					else
					{
						string cmd1 = @"SELECT id fROM Drink WHERE nome = '" + cmbDrink.SelectedItem.ToString() + "'";
						OleDbCommand comand1 = new OleDbCommand(cmd1, conecting);
						OleDbDataReader read_id_drink = comand1.ExecuteReader();
						read_id_drink.Read();

						// Adicionando informações ao banco de dados
						string SQL = "Insert Into Orders(status, client, board_number, spent, food_id, amount_food,drink_id, amount_drink) Values";
						SQL += "('Em andamento','" + txtName.Text + "','" + txtTable.Text + "','" + 0 + "','" + 0 + "','" + 0 + "','" + read_id_drink["id"] + "','" + numDrink.Value + "')";
						OleDbCommand comando = new OleDbCommand(SQL, conecting);
						comando.ExecuteNonQuery();
					}

					// Fechando o banco de dados
					conecting.Close();
				} catch (Exception erro) {
					MessageBox.Show(erro.Message);

				}

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
