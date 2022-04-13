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

        private async void SubmitButtonClick(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.IdBox.Text);
                var connection = new NpgsqlConnection(ServerInfo.GetConnectionString());
                await connection.OpenAsync();

                var query = new NpgsqlCommand($"SELECT delete_record({id})", connection);
                await query.ExecuteReaderAsync();

                await connection.CloseAsync();
                this.Close();
            }
            catch (NpgsqlException error)
            {
                MessageBox.Show(
                    $"Не удалось удалить данную строку: {error.Message}", "Ошибка",
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

        private void CloseButtonClick(object sender, EventArgs e) => this.Close();

        private void EnviromentClick(object sender, EventArgs e) => ((Control)sender).Select();
    }
}
