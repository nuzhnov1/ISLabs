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

namespace Lab4
{
    public partial class MainForm : Form
    {
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
            this.ConnectionString = ServerInfo.GetConnectionString();
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
                string queryString = @"SELECT * FROM dishes";
                var adapter =new NpgsqlDataAdapter(queryString,this.Connection);
                var dataSet = new DataSet();
                var dataTable=new DataTable();

                dataSet.Reset();
                adapter.Fill(dataSet);
                dataTable=dataSet.Tables[0];

                if (dataTable.Rows.Count != 0)
                {
                    TableView.DataSource = dataTable;
                    TableView.Columns[0].AutoSizeMode= DataGridViewAutoSizeColumnMode.Fill; 
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    exception.Message, "Ошибка извлечения данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );

                return;
            }
            await this.Connection.CloseAsync();
            this.TableView.Enabled = true;
            this.InsertButton.Enabled = true;
            this.DeleteButton.Enabled = true;
            customButton.Enabled = true;
        }

        /// <summary>
        /// Событие вставки строки в таблицу БД
        /// </summary>
        /// <param name="sender">Объект, вызвавший данное событие</param>
        /// <param name="e">Аргументы события</param>
        private void InsertButtonClick(object sender, EventArgs e)
        {
            var addWindow= new AddForm();
            addWindow.ShowDialog();
            ShowButtonClick(this, EventArgs.Empty);
        }

        /// <summary>
        /// Событие удаления строки из таблицы БД
        /// </summary>
        /// <param name="sender">Объект, вызвавший данное событие</param>
        /// <param name="e">Аргументы события</param>
        private void DeleteButtonClick(object sender, EventArgs e)
        {
            var deleteWindow= new DeleteForm();
            deleteWindow.ShowDialog();
            ShowButtonClick(this, EventArgs.Empty);
        }

        private void EnviromentClick(object sender, EventArgs e) => ((Control)sender).Select();

        private void customButton_Click(object sender, EventArgs e)
        {
            var customForm = new CustomForm();
            customForm.ShowDialog();
            if (CustomForm.returnTable.Rows.Count != 0) TableView.DataSource = CustomForm.returnTable;
            else ShowButtonClick(this, EventArgs.Empty);
        }
    }
}
