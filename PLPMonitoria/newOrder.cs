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
            dataOrder.Rows.Add(cmbFood.SelectedItem.ToString(), numAmount.Value.ToString(), 0);
            if(txtName.Text != "")
                lblDetails.Text = "Detalhes do pedido de " + txtName.Text.ToString();
        }

		private void btnFinalizar_Click(object sender, EventArgs e)
		{
			string strConection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Aline\Desktop\Apollo15.mdb";
			OleDbConnection conecting = new OleDbConnection(strConection);
			conecting.Open();

			string SQL = "Insert Into Client(nome, board_number) values ('"+txtName.Text+"', '"+txtTable.Text+"')";
			OleDbCommand comando = new OleDbCommand(SQL,conecting);
			comando.ExecuteNonQuery();
			conecting.Close();
			MessageBox.Show("\n Pedido realizado!");
			txtName.Clear();
			txtTable.Clear();
		}
	}
}
