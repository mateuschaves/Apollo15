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
			string strConection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\mateus\Documents\Apollo15\Apollo15.mdb";
			
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

								string cmd1 = @"SELECT price fROM Food WHERE nome = '"+ cmbFood.GetItemText(cmbFood.SelectedItem)+"'";
								OleDbCommand comand = new OleDbCommand(cmd1, conecting);
								OleDbDataReader read_price_food = comand.ExecuteReader();
								read_price_food.Read();
								
								lblDetails.Text = "Detalhes do pedido de " + txtName.Text.ToString();
								dataOrder.Rows.Add(cmbFood.GetItemText(cmbFood.SelectedItem), numFood.Value.ToString(), "R$ " + read_price_food["price"]);

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

								string cmd1 = @"SELECT price fROM Drink WHERE nome = '" + cmbDrink.GetItemText(cmbDrink.SelectedItem) + "'";
								OleDbCommand comand= new OleDbCommand(cmd1, conecting);
								OleDbDataReader read_price_drink = comand.ExecuteReader();
								read_price_drink.Read();

								lblDetails.Text = "Detalhes do pedido de " + txtName.Text.ToString();
								dataOrder.Rows.Add(cmbDrink.GetItemText(cmbDrink.SelectedItem), numDrink.Value.ToString(), "R$ " + read_price_drink["price"]);
								
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
					MessageBox.Show("Campo \"Bebidas\" obrigatório! ");

				}
			}
			if (txtName.Text != "" & txtTable.Text != "")
			{
				if (numDrink.Value == 0 & cmbDrink.SelectedIndex == -1 & numFood.Value == 0 & cmbFood.SelectedIndex == -1)
				{
					MessageBox.Show(" Todos os campos estão vazio!!");
				}
				if ((numDrink.Value > 0 & cmbDrink.SelectedIndex != -1) || (numFood.Value > 0 & cmbFood.SelectedIndex != -1))
				{
					try
					{
						// Conectando com o banco de dados
						OleDbConnection conecting = new OleDbConnection(strConection);
						// Abrindo o banco de dados
						conecting.Open();

						if (numDrink.Value != 0 & cmbDrink.SelectedIndex != -1 & numFood.Value != 0 & cmbFood.SelectedIndex != -1)
						{
							string cmd1 = @"SELECT id fROM Drink WHERE nome = '" + cmbDrink.GetItemText(cmbDrink.SelectedItem) + "'";
							string cmd2 = @"SELECT id fROM Food WHERE nome = '" + cmbFood.GetItemText(cmbFood.SelectedItem) + "'";
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
							string cmd2 = @"SELECT id fROM Food WHERE nome = '" + cmbFood.GetItemText(cmbFood.SelectedItem) + "'";
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
							string cmd1 = @"SELECT id fROM Drink WHERE nome = '" + cmbDrink.GetItemText(cmbDrink.SelectedItem) + "'";
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
					}
					catch (Exception erro)
					{
						MessageBox.Show(erro.Message);
					}
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
		private void newOrder_Load(object sender, EventArgs e)
		{
			
			// Preechendo o Combobox com dados do banco de dados 
			try
			{
				// String de conection com o banco de dados
				string strConection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\mateus\Documents\Apollo15\Apollo15.mdb";
				OleDbConnection conecting = new OleDbConnection(strConection);
				conecting.Open();

				cmbFood.Items.Clear();
				string cmd1 = "SELECT * FROM Food ORDER BY nome ASC";
				OleDbCommand comand1 = new OleDbCommand(cmd1, conecting);
				OleDbDataAdapter adapter1 = new OleDbDataAdapter(comand1);
				DataTable table1 = new DataTable();

				adapter1.Fill(table1);
				cmbFood.DataSource = table1;
				cmbFood.ValueMember = "id";
				cmbFood.DisplayMember = "nome";

				// -------------------------------------------------------------------
				cmbDrink.Items.Clear();
				string cmd2 = "SELECT * FROM Drink ORDER BY nome ASC";
				OleDbCommand comand2 = new OleDbCommand(cmd2, conecting);
				OleDbDataAdapter adapter2 = new OleDbDataAdapter(comand2);
				DataTable table2 = new DataTable();
            

				adapter2.Fill(table2);
				cmbDrink.DataSource = table2;
				cmbDrink.ValueMember = "id";
				cmbDrink.DisplayMember = "nome";

				cmbFood.SelectedIndex = -1;
				cmbDrink.SelectedIndex = -1;
				// Fechando o banco de dados
				conecting.Close();
			}
			catch (Exception erro)
			{
				MessageBox.Show(erro.Message);
			}
		}
		private void cmbDrink_SelectedIndexChanged(object sender, EventArgs e)
		{
		}
	}
}
