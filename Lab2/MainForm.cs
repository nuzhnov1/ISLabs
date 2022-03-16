using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
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

        public MainForm()
        {
            InitializeComponent();
            this.Connection = new NpgsqlConnection();
            this.ConnectionString = String.Format(
                "Host = {0}; Port = {1}; Database = {2}; " +
                "Username = {3}; Password = {4};",
                HOST, PORT, DATABASE, USERNAME, PASSWORD
            );
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
            catch (SystemException exception)
            {
                MessageBox.Show(
                    exception.Message, "Ошибка подключения к базе данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );

                return;
            }

            try
            {
                string queryString = @"
                    WITH waiters AS (
	                    SELECT
		                    workers.id AS id,
		                    workers.full_name AS name,
		                    positions.name AS position
	                    FROM workers INNER JOIN positions ON workers.position_id = positions.id
	                    WHERE positions.name = 'Waiter'
                    ),
                    cooks AS (
	                    SELECT
		                    workers.id AS id,
		                    workers.full_name AS name,
		                    positions.name AS position
	                    FROM workers INNER JOIN positions ON workers.position_id = positions.id
	                    WHERE positions.name = 'Chef'
                    )
                    SELECT
	                    dishes.name AS dish_name,
	                    dishes.price AS dish_price,
	                    dishes.cook_time AS dish_cook_time,
	                    waiters.name AS waiter,
	                    cooks.name AS chef
                    FROM orders
	                    INNER JOIN dishes ON orders.dish_id = dishes.id
	                    INNER JOIN waiters ON orders.waiter_id = waiters.id
	                    INNER JOIN cooks ON orders.chef_id = cooks.id;
                ";
                
                await using var query = new NpgsqlCommand(queryString, this.Connection);
                await using var reader = await query.ExecuteReaderAsync();

                PrintTable(reader);
            }
            catch (DbException exception)
            {
                MessageBox.Show(
                    exception.Message, "Ошибка извлечения данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );

                return;
            }

            this.TableBox.Enabled = true;
            this.InsertButton.Enabled = true;
            this.DeleteButton.Enabled = true;
            this.ShowButton.Enabled = false;
        }

        private async void PrintTable(NpgsqlDataReader reader)
        {
            StringBuilder result = new StringBuilder(@"{\rtf1 ");

            this.TableBox.Clear();

            // Добавление заголовка таблицы
            result.Append(@"\trowd");
            for (int i = 0; i < reader.FieldCount; i++)
                result.Append(@"\cellx" + (i + 1) * 1600 + @"\trrh400");
            for (int i = 0; i < reader.FieldCount; i++)
                result.Append(@"\intbl \b " + reader.GetName(i) + @" \b0 \cell");
            result.Append(@"\row");

            // Добавление содержимого таблицы
            while (await reader.ReadAsync())
            {
                result.Append(@"\trowd");
                for (int i = 0; i < reader.FieldCount; i++)
                    result.Append(@"\cellx" + (i + 1) * 1600 + @"\trrh400");
                for (int i = 0; i < reader.FieldCount; i++)
                    result.Append(@"\intbl " + reader[i].ToString() + @" \cell");
                result.Append(@"\row");
            }

            result.Append(@"\pard}");
            this.TableBox.Rtf = result.ToString();
        }

        private void EnviromentClick(object sender, EventArgs e) => ((Control)sender).Select();
    }
}
