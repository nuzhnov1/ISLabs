using Npgsql;
using System;
using System.Globalization;
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

        private async void SubmitButtonClick(object sender, EventArgs e)
        {
            try
            {
                double price = double.Parse(this.PriceBox.Text, NumberStyles.Number, CultureInfo.InvariantCulture);
                string name = this.NameBox.Text;
                var connection = new NpgsqlConnection(ServerInfo.GetConnectionString());
                await connection.OpenAsync();

                string queryString = String.Format(
                    CultureInfo.InvariantCulture,
                    $"SELECT add_record('{name}', {price.ToString(CultureInfo.InvariantCulture)})"
                );
                var query = new NpgsqlCommand(queryString, connection);
                await query.ExecuteReaderAsync();
                
                await connection.CloseAsync();
                this.Close();
            }
            catch (NpgsqlException error)
            {
                MessageBox.Show(
                    $"Не удалось осуществить вставку новой строки: {error.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
            catch (SystemException error) 
            {
                MessageBox.Show(
                    $"Некорректно введены данные: {error.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        private void CancelButtonClick(object sender, EventArgs e) => this.Close();

        private void EnviromentClick(object sender, EventArgs e) => ((Control)sender).Select();
    }
}
