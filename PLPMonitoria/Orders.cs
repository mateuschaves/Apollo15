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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainScrenn nt = new mainScrenn();
            nt.Show();
            this.Hide();
        }

		private void dataOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void Orders_Load(object sender, EventArgs e)
		{
			try
			{
				string strConection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\mateus\Documents\Apollo15\Apollo15.mdb";
				OleDbConnection conecting = new OleDbConnection(strConection);
				// Abrindo o banco de dados
				conecting.Open();

				string cmd1 = @"SELECT * FROM ClientOrders WHERE status = 'Em andamento' or status = 'Em preparo' ";
				OleDbCommand comand = new OleDbCommand(cmd1, conecting);
				OleDbDataReader boardNumber = comand.ExecuteReader();
				

				// Adiciona os pedidos que estão em andamento ao datagridview
				while (boardNumber.Read())
				{
					dataOrder.Rows.Add(boardNumber["board_number"], boardNumber["status"]);
				}
				conecting.Close();
			}
			catch
			{
				MessageBox.Show(" Erro na conexão com o banco de dados!");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			mainScrenn go = new mainScrenn();
			go.Show();
			this.Hide();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				if(cmbFood.SelectedIndex != -1)
				{
					if (dataOrder.RowCount != 0)
					{
						// String de conection com o banco de dados
						string strConection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\mateus\Documents\Apollo15\Apollo15.mdb";
						OleDbConnection conecting = new OleDbConnection(strConection);
						conecting.Open();

						// Nome do produto selecionado 
						string numTable = dataOrder.Rows[dataOrder.CurrentRow.Index].Cells[0].Value.ToString();

						// Comando que atualiza o status
						string atualiza_status = @"UPDATE ClientOrders SET status = '" + cmbFood.GetItemText(cmbFood.SelectedItem) + "' WHERE board_number =  '" + numTable.ToString() + "'";
						OleDbCommand comand = new OleDbCommand(atualiza_status, conecting);
						comand.ExecuteNonQuery();

						// Atualiza o status do pedido no datagridview
						//dataOrder.Rows[dataOrder.CurrentRow.Index].Cells[1].Value = cmbFood.SelectedItem.ToString();

						// Remove a linha selecionada no datagridview
						dataOrder.Rows.Remove(dataOrder.CurrentRow);

                        string cmd1 = @"SELECT * FROM ClientOrders WHERE status = 'Em andamento' or status = 'Em preparo' ";
                        OleDbCommand fill = new OleDbCommand(cmd1, conecting);
                        OleDbDataReader boardNumber = fill.ExecuteReader();

                        dataOrder.Rows.Clear();
                        // Adiciona os pedidos que estão em andamento ao datagridview
                        while (boardNumber.Read())
                        {
                            dataOrder.Rows.Add(boardNumber["board_number"], boardNumber["status"]);
                        }
                        // Fechando o banco de dados
                        conecting.Close();
					}
					else
					{
						MessageBox.Show(" DataTable está vazia! ");
					}
				}
				else
				{
					MessageBox.Show(" Campo \"status do pedido\" está vazio! ");
				}
			}
			catch
			{
				MessageBox.Show("Erro ao fazer conexão com o banco de dados");
			}
		}

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
