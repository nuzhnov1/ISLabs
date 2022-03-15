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
        private readonly ConnectionForm ConnectionForm;
        private readonly NpgsqlConnection Connection;
        private string ConnectionString;

        public MainForm()
        {
            InitializeComponent();

            this.ConnectionForm = new ConnectionForm();
            this.Connection = new NpgsqlConnection();
            this.AddOwnedForm(ConnectionForm);
            this.ConnectionString = "";
        }

        private void InitButtonClick(object sender, EventArgs e)
        {
            try
            {
                this.ConnectionForm.ShowDialog();
                this.ConnectionString = this.ConnectionForm.ConnectionString;
            }
            catch (SystemException exception)
            {
                MessageBox.Show(
                    exception.Message, "Ошибка инициализации",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }

            if (this.ConnectionString == "")
            {
                this.OpenButton.Enabled = false;
                this.CloseButton.Enabled = false;
                this.ExecButton.Enabled = false;
                this.QueryBox.Enabled = false;
                this.TableView.Visible = false;

                this.StatusValueLabel.Text = "не инициализировано";
                this.StatusValueLabel.ForeColor = Color.Black;
            }
            else
            {
                try
                {
                    this.Connection.ConnectionString = this.ConnectionString;
                }
                catch (NpgsqlException exception)
                {
                    MessageBox.Show(
                        exception.Message, "Ошибка инициализации",
                        MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
                }

                this.OpenButton.Enabled = true;
                this.CloseButton.Enabled = false;
                this.ExecButton.Enabled = false;
                this.QueryBox.Enabled = false;
                this.TableView.Visible = false;

                this.StatusValueLabel.Text = "инициализировано";
                this.StatusValueLabel.ForeColor = Color.Green;
            }
        }

        private async void OpenButtonClick(object sender, EventArgs e)
        {
            try
            {
                await this.Connection.OpenAsync();

                this.InitButton.Enabled = false;
                this.OpenButton.Enabled = false;
                this.CloseButton.Enabled = true;
                this.ExecButton.Enabled = this.QueryBox.Text != "";
                this.QueryBox.Enabled = true;
                this.TableView.Visible = true;

                this.StatusValueLabel.Text = "открыто";
                this.StatusValueLabel.ForeColor = Color.Yellow;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show(
                    exception.Message, "Ошибка открытия",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        private async void CloseButtonClick(object sender, EventArgs e)
        {
            try
            {
                await this.Connection.CloseAsync();

                this.StatusValueLabel.Text = "закрыто";
                this.StatusValueLabel.ForeColor = Color.Red;

                this.InitButton.Enabled = true;
                this.OpenButton.Enabled = true;
                this.CloseButton.Enabled = false;
                this.ExecButton.Enabled = false;
                this.QueryBox.Enabled = false;
                this.TableView.Visible = false;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show(
                    exception.Message, "Ошибка закрытия",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        private async void ExecuteButtonClick(object sender, EventArgs e)
        {
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
                    MessageBox.Show("Операция выполнена успешно", 
                        "Результат выполнения команды", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show(exception.Message, "Ошибка выполнения команды", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnviromentClick(object sender, EventArgs e) => ((Control)sender).Select();
        private void QueryBoxLostFocus(object sender, EventArgs e) => this.ExecButton.Enabled = this.QueryBox.Text != "";
    }
}
