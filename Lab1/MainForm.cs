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

namespace Lab1
{
    public partial class MainForm : Form
    {
        // Дочерняя форма для ввода данных соединения
        private readonly ConnectionForm ConnectionForm;
        // Дескриптор соединения с БД
        private readonly NpgsqlConnection Connection;
        // Строка соединения с БД
        private string ConnectionString;

        public MainForm()
        {
            InitializeComponent();

            this.ConnectionForm = new ConnectionForm();
            this.Connection = new NpgsqlConnection();
            this.AddOwnedForm(ConnectionForm);
            this.ConnectionString = "";
        }

        /// <summary>
        /// Событие инициализации соединения: показывает ConnectionForm, которая принимает данные соединения
        /// и передаёт их ConnectionString
        /// </summary>
        /// <param name="sender">Объект, вызвавший данное событие</param>
        /// <param name="e">Аргументы события</param>
        private void InitButtonClick(object sender, EventArgs e)
        {
            try
            {
                this.ConnectionForm.ShowDialog();
                this.ConnectionString = this.ConnectionForm.ConnectionString;
            }
            catch (SystemException error)
            {
                MessageBox.Show(
                    $"Ошибка инициализации: {error.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }

            // Если данные не были получены
            if (this.ConnectionString == "")
            {
                this.OpenButton.Enabled = false;
                this.CloseButton.Enabled = false;
                this.ExecButton.Enabled = false;
                this.QueryBox.Enabled = false;
                this.TableView.Enabled = false;

                this.StatusValueLabel.Text = "не инициализировано";
                this.StatusValueLabel.ForeColor = Color.Black;
            }
            else
            {
                try
                {
                    this.Connection.ConnectionString = this.ConnectionString;

                    this.OpenButton.Enabled = true;
                    this.CloseButton.Enabled = false;
                    this.ExecButton.Enabled = false;
                    this.QueryBox.Enabled = false;
                    this.TableView.Enabled = false;

                    this.StatusValueLabel.Text = "инициализировано";
                    this.StatusValueLabel.ForeColor = Color.Green;
                }
                catch (NpgsqlException error)
                {
                    this.OpenButton.Enabled = false;
                    this.CloseButton.Enabled = false;
                    this.ExecButton.Enabled = false;
                    this.QueryBox.Enabled = false;
                    this.TableView.Enabled = false;

                    this.StatusValueLabel.Text = "не инициализировано";
                    this.StatusValueLabel.ForeColor = Color.Black;

                    MessageBox.Show(
                        $"Ошибка инициализации: {error.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
            }
            }
        }

        /// <summary>
        /// Событие открытия соединения с БД
        /// </summary>
        /// <param name="sender">Объект, вызвавший данное событие</param>
        /// <param name="e">Аргументы события</param>
        private async void OpenButtonClick(object sender, EventArgs e)
        {
            try
            {
                await this.Connection.OpenAsync();

                this.InitButton.Enabled = false;
                this.OpenButton.Enabled = false;
                this.CloseButton.Enabled = true;
                this.ExecButton.Enabled = true;
                this.QueryBox.Enabled = true;
                this.TableView.Enabled = true;

                this.StatusValueLabel.Text = "открыто";
                this.StatusValueLabel.ForeColor = Color.Yellow;
            }
            catch (NpgsqlException error)
            {
                MessageBox.Show(
                    $"Ошибка открытия: {error.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        /// <summary>
        /// Событие закрытия соединения с БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void CloseButtonClick(object sender, EventArgs e)
        {
            try
            {
                await this.Connection.CloseAsync();

                this.InitButton.Enabled = true;
                this.OpenButton.Enabled = true;
                this.CloseButton.Enabled = false;
                this.ExecButton.Enabled = false;
                this.QueryBox.Text = "";
                this.QueryBox.Enabled = false;
                this.TableView.Enabled = false;
                this.TableView.DataSource = new DataTable();

                this.StatusValueLabel.Text = "закрыто";
                this.StatusValueLabel.ForeColor = Color.Red;
            }
            catch (NpgsqlException error)
            {
                MessageBox.Show(
                    $"Ошибка закрытия: {error.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        /// <summary>
        /// Событие выполнения запроса к БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ExecuteButtonClick(object sender, EventArgs e)
        {
            if (this.QueryBox.Text == "")
                return;

            try
            {
                await using var query = new NpgsqlCommand(this.QueryBox.Text, this.Connection);
                await using var reader = await query.ExecuteReaderAsync();
                
                if (reader.FieldCount > 0)
                {
                    var table = new DataTable();

                    table.Load(reader);
                    this.TableView.DataSource = table;
                }
                else
                {
                    MessageBox.Show(
                        "Операция выполнена успешно", "Результат выполнения команды", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
            }
            catch (NpgsqlException error)
            {
                MessageBox.Show(
                    $"Ошибка выполнения комадны: {error.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        private void EnviromentClick(object sender, EventArgs e) => ((Control)sender).Select();
    }
}
