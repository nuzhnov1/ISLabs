using System;
using System.Diagnostics;
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

namespace Lab7
{
    public partial class MainForm : Form
    {
        // Строка запроса к БД
        const string queryString = @"SELECT * FROM dishes";
        // Абсолютный путь к программам PostgreSQL
        const string postgrePath = @"C:\Program Files\PostgreSQL\11\bin";

        // Дескриптор соединения с БД
        private readonly NpgsqlConnection Connection;
        // Строка соединения с БД
        private readonly string ConnectionString;
        // Адаптер для работы с БД
        private readonly NpgsqlDataAdapter DataAdapter;
        // Таблица с данными
        private readonly DataTable DataTable;

        public MainForm()
        {
            InitializeComponent();
            
            this.Connection = new NpgsqlConnection();
            this.DataAdapter = new NpgsqlDataAdapter(queryString, this.Connection);
            this.DataTable = new DataTable();
        }

        private async void ShowButtonClick(object sender, EventArgs e)
        {
            try
            {
                this.Connection.ConnectionString = ServerInfo.GetConnectionString();
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
                var query = new NpgsqlCommand(queryString, this.Connection);
                var reader = await query.ExecuteReaderAsync();

                this.DataTable.Clear();
                this.DataTable.Load(reader);
                this.TableView.DataSource = this.DataTable;
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
            this.UpdateButton.Enabled = true;
            this.SaveButton.Enabled = true;
            this.RestoreButton.Enabled = true;
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

        private void UpdateButtonClick(object sender, EventArgs e)
        {
            try
            {
                this.DataAdapter.UpdateCommand = new NpgsqlCommandBuilder(this.DataAdapter).GetUpdateCommand();
                this.DataAdapter.Update(this.DataTable);
                this.TableView.DataSource = this.DataTable.GetChanges(DataRowState.Added | DataRowState.Modified);
            }
            catch (SystemException error)
            {
                MessageBox.Show(
                    $"Не удалось обновить данные: {error.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            var dialogResult = folderBrowserDialog.ShowDialog();

            try
            {
                if (dialogResult == DialogResult.OK)
                {
                    string dirPath = folderBrowserDialog.SelectedPath;
                    var process = new Process();

                    process.StartInfo.EnvironmentVariables.Add("PGPASSWORD", ServerInfo.password);
                    process.StartInfo.FileName = $"{postgrePath}\\pg_dump.exe";
                    process.StartInfo.Arguments = $"-h {ServerInfo.host} -p {ServerInfo.port} -U {ServerInfo.username} -d {ServerInfo.datebase} -Fc -f {dirPath}\\restaurant.sql";
                    process.Start();
                    process.WaitForExit();

                    MessageBox.Show(
                        "Сохранение прошло успешно", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
            }
            catch (SystemException error)
            {
                MessageBox.Show(
                    $"Ошибка при сохранении: {error.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        private void RestoreButtonClick(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            var dialogResult = openFileDialog.ShowDialog();
            
            try
            {
                if (dialogResult == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    var process = new Process();

                    process.StartInfo.EnvironmentVariables.Add("PGPASSWORD", ServerInfo.password);
                    process.StartInfo.FileName = $"{postgrePath}\\pg_restore.exe";
                    process.StartInfo.Arguments = $"-h {ServerInfo.host} -p {ServerInfo.port} -U {ServerInfo.username} -d test {filePath}";
                    process.Start();
                    process.WaitForExit();

                    ServerInfo.datebase = "test";
                    
                    MessageBox.Show(
                        "Восстановление прошло успешно", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
            }
            catch (SystemException error)
            {
                MessageBox.Show(
                    $"Ошибка при восстановлении: {error.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        private void EnviromentClick(object sender, EventArgs e) => ((Control)sender).Select();
    }
}
