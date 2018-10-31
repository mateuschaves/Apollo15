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
			this.Close();
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

								// Total gasto no pedido da comida
								Double totalfood = Convert.ToDouble(read_price_food["price"]) * (double)numFood.Value;
								
								// Inserindo o pedido (comida) no banco de dados
								string orderfood = "Insert Into FoodOrders(client, board_number, food, quant_food, total) Values";
								orderfood += "('" + txtName.Text + "','" + txtTable.Text + "', '" + cmbFood.GetItemText(cmbFood.SelectedItem) + "','" + numFood.Value.ToString() + "','" + String.Format("{0:0.00}", totalfood) + "')";
								OleDbCommand comando = new OleDbCommand(orderfood, conecting);
								comando.ExecuteNonQuery();

                                // Buscando no banco o registro que acabou de ser inserido.
                                string id_order_food = "select `id` from FoodOrders where `client` =  '"+txtName.Text+" ' and `board_number` = '" + txtTable.Text + " ' and  food = '"+ cmbFood.SelectedItem.ToString()+" ' ";
                                OleDbCommand id = new OleDbCommand(id_order_food, conecting);


								// Alterando o label Detalhes do pedido (adicionando o nome do cliente)
								lblDetails.Text = "Detalhes do pedido de " + txtName.Text.ToString();
								// Adicionando o pedido ao DataGridView
								dataOrder.Rows.Add("Comida",cmbFood.GetItemText(cmbFood.SelectedItem), numFood.Value.ToString(), "R$ " + String.Format("{0:0.00}", read_price_food["price"]));

								// Fechando o banco de dados
								conecting.Close();
							}
							catch 
							{
								MessageBox.Show("Erro ao fazer conexão com o banco de dado!");
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

								// Lendo o preço da comida
								string cmd1 = @"SELECT price fROM Drink WHERE nome = '" + cmbDrink.GetItemText(cmbDrink.SelectedItem) + "'";
								OleDbCommand comand= new OleDbCommand(cmd1, conecting);
								OleDbDataReader read_price_drink = comand.ExecuteReader();
								read_price_drink.Read();

								// Total gasto no pedido da comida
								double totaldrink = Convert.ToDouble(read_price_drink["price"]) * (double)numDrink.Value;

								// Inserindo o pedido (comida) no banco de dados
								string orderfood = "Insert Into DrinkOrders(client, board_number, drink, quant_drink, total) Values";
								orderfood += "('" + txtName.Text + "','" + txtTable.Text + "', '" + cmbDrink.GetItemText(cmbDrink.SelectedItem) + "','" + numDrink.Value.ToString() + "','" + String.Format("{0:0.00}", totaldrink) + "')";
								OleDbCommand comando = new OleDbCommand(orderfood, conecting);
								comando.ExecuteNonQuery();

								// Alterando o label Detalhes do pedido (adicionando o nome do cliente)
								lblDetails.Text = "Detalhes do pedido de " + txtName.Text.ToString();
								// Adicionando o pedido ao DataGridView
								dataOrder.Rows.Add("Bebida", cmbDrink.GetItemText(cmbDrink.SelectedItem), numDrink.Value.ToString(), "R$ " + String.Format("{0:0.00}", read_price_drink["price"])); 								
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
			
			try
			{
				// Gasto total do cliente
				double spent = 0;
				// Conectando com o banco de dados
				OleDbConnection conecting = new OleDbConnection(strConection);
				// Abrindo o banco de dados
				conecting.Open();
				
				// Selecionando quanto foi gasto em comida com pedidos anteriores
				string sqlconnection1 = "SELECT * FROM FoodOrders WHERE client =  '" + txtName.Text + "'";
				OleDbCommand cmd1 = new OleDbCommand(sqlconnection1, conecting);
				OleDbDataReader prices = cmd1.ExecuteReader();
				
				// Somando gastos com pedidos anteriores
				while (prices.Read())
				{
					spent += Convert.ToDouble(prices["total"]);
				}

				// Selecionando quanto foi gasto em bebida com pedidos anteriores
				string sqlconnection2 = "SELECT * FROM DrinkOrders WHERE client = '" + txtName.Text + "'";
				OleDbCommand cmd2 = new OleDbCommand(sqlconnection2, conecting);
				OleDbDataReader prices2 = cmd2.ExecuteReader();

				while (prices2.Read())
				{
					spent += Convert.ToDouble(prices2["total"]);
				}

				// Mudando o total de todos o pedidos (tela de pedidos)
				lblTotal.Text = "Total: R$ " + String.Format("{0:f2}", spent);

				// Verifica se é uma mesa que já está no banco de dados
				string sqlJaExiste = "SELECT * FROM ClientOrders";
				OleDbCommand cmd3 = new OleDbCommand(sqlJaExiste, conecting);
				OleDbDataReader verificamesa = cmd3.ExecuteReader();

				bool jatem = false;
				while (verificamesa.Read())
				{
					if(verificamesa["board_number"].ToString() == txtTable.Text)
					{
						string atualiza_spent = @"UPDATE ClientOrders SET spent =  '" + String.Format("{0:0.00}", spent) + "' WHERE client =  '" + txtName.Text  + "'";
						OleDbCommand comand = new OleDbCommand(atualiza_spent, conecting);
						comand.ExecuteNonQuery();
						jatem = true;
						break;
					}
				}

				if (!jatem)
				{
					// Adicionando pedido do client no banco de dados
					string SQL = "Insert Into ClientOrders(status, client, board_number, spent) Values";
					SQL += "('Em andamento','" + txtName.Text + "','" + txtTable.Text + "','" + String.Format("{0:0.00}", spent) + "')";
					OleDbCommand comando = new OleDbCommand(SQL, conecting);
					comando.ExecuteNonQuery();
				}
				// Fechando o banco de dados
				conecting.Close();
			}
			catch
			{
				MessageBox.Show("Erro ao fazer conexão com o banco de dado!");
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
		private void txtTable_TextChanged(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
			{
				e.Handled = true;
			}
			if (e.Handled)
			{
				MessageBox.Show(" Só é permitido número!!");
			}
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
			catch
			{
				MessageBox.Show("Erro ao fazer conexão com o banco de dado (newOrder)");
			}
		}
		private void cmbDrink_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

        private void button3_Click(object sender, EventArgs e)
        {
            mainScrenn ns = new mainScrenn();
            ns.Show();
            this.Hide();
        }

		private void btnDelete_Click(object sender, EventArgs e)
		{
			
			try
			{
				// String de conection com o banco de dados
				string strConection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\mateus\Documents\Apollo15\Apollo15.mdb";
				OleDbConnection conecting = new OleDbConnection(strConection);
				conecting.Open();

				// Nome do produto selecionado 
				string Produto_selecionado = dataOrder.Rows[dataOrder.CurrentRow.Index].Cells[1].Value.ToString();

				if (dataOrder.Rows[dataOrder.CurrentRow.Index].Cells[0].Value.ToString() == "Bebida")
				{
					string ExluiPedido = @"DELETE FROM DrinkOrders WHERE drink = '" + Produto_selecionado + "'";
					OleDbCommand comand = new OleDbCommand(ExluiPedido, conecting);
					comand.ExecuteNonQuery();
				}
				else
				{
					string ExluiPedido2 = @"DELETE FROM FoodOrders WHERE food = '" + Produto_selecionado + "'";
					OleDbCommand comand = new OleDbCommand(ExluiPedido2, conecting);
					comand.ExecuteNonQuery();
				}

				// Remove a linha selecionada no datagridview
				dataOrder.Rows.Remove(dataOrder.CurrentRow);

				// Fechando o banco de dados
				conecting.Close();
			}
			catch 
			{
				MessageBox.Show("Erro ao fazer conexão com o banco de dado (Delete)");
			}
			
		}
		private void btnEdit_Click(object sender, EventArgs e)
		{

		}

		private void txtTable_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
