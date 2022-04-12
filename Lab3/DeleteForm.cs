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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) => this.Close();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text);
                var connection = new NpgsqlConnection(ServerInfo.GetConnectionString());
                connection.OpenAsync();
                var query = new NpgsqlCommand($"SELECT del({id})", connection);
                query.ExecuteReader();
                connection.CloseAsync();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректно введены данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
