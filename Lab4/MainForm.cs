using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Lab4
{
    public partial class MainForm : Form
    {
        // Дескриптор соединения с БД
        private readonly NpgsqlConnection Connection;
        // Строка соединения с БД
        private readonly string ConnectionString;
        
        public MainForm()
        {
            InitializeComponent();
            
            this.Connection = new NpgsqlConnection();
            this.ConnectionString = ServerInfo.GetConnectionString();
        }

        private async void ShowButtonClick(object sender, EventArgs e)
        {
            try
            {
                this.Connection.ConnectionString = this.ConnectionString;
                await this.Connection.OpenAsync();
            }
            catch (SystemException error)
            {
                MessageBox.Show(
                    $"Ошибка при подключении к базе данных: {error.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );

                return;
            }

            try
            {
                string queryString = @"SELECT * FROM dishes";
                var adapter = new NpgsqlDataAdapter(queryString, this.Connection);
                var dataSet = new DataSet();
                var dataTable = new DataTable();

                dataSet.Reset();
                adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];

                if (dataTable.Rows.Count != 0)
                {
                    this.TableView.DataSource = dataTable;
                    this.TableView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (SystemException error)
            {
                MessageBox.Show(
                    $"Ошибка извлечения данных: {error.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );

                return;
            }

            await this.Connection.CloseAsync();

            this.TableView.Enabled = true;
            this.InsertButton.Enabled = true;
            this.DeleteButton.Enabled = true;
            this.ExecuteButton.Enabled = true;
        }

        private void InsertButtonClick(object sender, EventArgs e)
        {
            var addWindow = new AddForm();

            addWindow.ShowDialog();
            ShowButtonClick(this, EventArgs.Empty);
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            var deleteWindow = new DeleteForm();

            deleteWindow.ShowDialog();
            ShowButtonClick(this, EventArgs.Empty);
        }

        private void ExecuteButtonClick(object sender, EventArgs e)
        {
            var customForm = new CustomForm();

            customForm.ShowDialog();
            if (customForm.ReturnTable.Rows.Count != 0)
                this.TableView.DataSource = customForm.ReturnTable;
            else
                ShowButtonClick(this, EventArgs.Empty);
        }

        private void EnviromentClick(object sender, EventArgs e) => ((Control)sender).Select();
    }
}
