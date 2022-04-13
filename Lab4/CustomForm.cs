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

namespace Lab4
{
    public partial class CustomForm : Form
    {
        public DataTable ReturnTable { get; private set; }

        public CustomForm()
        {
            InitializeComponent();
            this.ReturnTable = new DataTable();
        }

        private async void SubmitButtonClick(object sender, EventArgs e)
        {
            try
            {
                var connection = new NpgsqlConnection(ServerInfo.GetConnectionString());
                await connection.OpenAsync();
                
                var query = new NpgsqlCommand(this.QueryBox.Text, connection);
                this.ReturnTable.Load(await query.ExecuteReaderAsync());
                
                await connection.CloseAsync();
                this.Close();
            }
            catch (SystemException error)
            {
                MessageBox.Show(
                    $"Ошибка при выполнении запроса: {error.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        private void CancelButtonClick(object sender, EventArgs e) => this.Close();

        private void EnviromentClick(object sender, EventArgs e) => ((Control)sender).Select();
    }
}
