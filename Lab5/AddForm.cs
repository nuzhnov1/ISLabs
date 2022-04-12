using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) => this.Close();

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double price = double.Parse(textBox2.Text);
                string name = textBox1.Text;
                var connection = new NpgsqlConnection(ServerInfo.GetConnectionString());
                connection.OpenAsync();
                var query = new NpgsqlCommand($"SELECT myadd('{name}',{price})", connection);
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
