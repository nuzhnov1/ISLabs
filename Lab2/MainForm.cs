using System;
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

namespace Lab2
{
    public partial class MainForm : Form
    {
        // Данные соединения:

        const string HOST = "localhost";
        const int PORT = 5432;
        const string DATABASE = "restaurant";
        const string USERNAME = "admin";
        const string PASSWORD = "hydra";

        // Дескриптор соединения с БД
        private readonly NpgsqlConnection Connection;
        // Строка соединения с БД
        private readonly string ConnectionString;

        // Дочернее окно
        private readonly InfoForm InfoForm;

        public MainForm()
        {
            InitializeComponent();
            
            this.Connection = new NpgsqlConnection();
            this.ConnectionString = String.Format(
                "Host = {0}; Port = {1}; Database = {2}; " +
                "Username = {3}; Password = {4};",
                HOST, PORT, DATABASE, USERNAME, PASSWORD
            );
            this.InfoForm = new InfoForm();
            this.AddOwnedForm(this.InfoForm);
        }

        /// <summary>
        /// Событие соединения с БД и извлечения данных из неё
        /// </summary>
        /// <param name="sender">Объект, вызвавший данное событие</param>
        /// <param name="e">Аргументы события</param>
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
                    $"Ошибка подключения к базе данных: { error.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );

                return;
            }

            try
            {
                string queryString = @"SELECT * FROM dishes;";
                
                await using var query = new NpgsqlCommand(queryString, this.Connection);
                await using var reader = await query.ExecuteReaderAsync();
                var table = new DataTable("Orders");

                table.Load(reader);
                this.TableView.DataSource = table;
            }
            catch (Exception error)
            {
                MessageBox.Show(
                    $"Ошибка извлечения данных : {error.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );

                return;
            }

            this.TableView.Enabled = true;
            this.InsertButton.Enabled = true;
            this.DeleteButton.Enabled = true;
            this.ShowButton.Enabled = false;
        }

        /// <summary>
        /// Событие вставки строки в таблицу БД
        /// </summary>
        /// <param name="sender">Объект, вызвавший данное событие</param>
        /// <param name="e">Аргументы события</param>
        private void InsertButtonClick(object sender, EventArgs e) => this.InfoForm.ShowDialog();

        /// <summary>
        /// Событие удаления строки из таблицы БД
        /// </summary>
        /// <param name="sender">Объект, вызвавший данное событие</param>
        /// <param name="e">Аргументы события</param>
        private void DeleteButtonClick(object sender, EventArgs e) => this.InfoForm.ShowDialog();

        private void EnviromentClick(object sender, EventArgs e) => ((Control)sender).Select();
    }
}
