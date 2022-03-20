using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;    

namespace Lab3
{
    public partial class CustomForm : Form
    {
        static public DataTable returnTable = new DataTable();
        public CustomForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)=>this.Close();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var connection = new NpgsqlConnection(ServerInfo.GetConnectionString());
                connection.OpenAsync();
                var query = new NpgsqlCommand(textBox1.Text, connection);
                returnTable = new DataTable();
                returnTable.Load(query.ExecuteReader());
                connection.CloseAsync();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
