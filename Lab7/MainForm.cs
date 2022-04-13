using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Lab7
{
    public partial class MainForm : Form
    {
        // Дескриптор соединения с БД
        private readonly NpgsqlConnection Connection;
        // Строка соединения с БД
        private readonly string ConnectionString;

        // Дочернее окно
        private readonly InfoForm InfoForm;

        DataSet dataSet ;
        DataTable dataTable;
        NpgsqlDataAdapter adapter;
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
                this.Connection.Open();
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
                adapter =new NpgsqlDataAdapter(queryString,this.Connection);
                dataSet = new DataSet();
                dataTable=new DataTable();
                TableView.ForeColor = Color.Black;
                dataSet.Reset();
                adapter.Fill(dataSet);
                dataTable=dataSet.Tables[0];
                TableView.DataSource = dataTable;
                TableView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    exception.Message, "Ошибка извлечения данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );

                return;
            }
            this.Connection.Close();
            this.TableView.Enabled = true;
            this.InsertButton.Enabled = true;
            this.DeleteButton.Enabled = true;
            customButton.Enabled = true;
            updateButton.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var chagesTable = new DataTable();
                chagesTable = dataTable.GetChanges(DataRowState.Modified);
                adapter.UpdateCommand = new NpgsqlCommandBuilder(adapter).GetUpdateCommand();
                adapter.Update(dataTable);
                TableView.ForeColor = Color.Green;
                TableView.DataSource=chagesTable;
                TableView.Columns[1].AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    //Connection.Open();
                    //var query = new NpgsqlCommand("DROP DATABASE "+ServerInfo.datebase, Connection);
                    //var reader =  query.ExecuteReaderAsync();
                    //Connection.Close();
                    //var process1 = new Process();
                    var process2 = new Process();
                    var process3 = new Process();
                    string s1 = @"C:\Program Files\PostgreSQL\11\bin\dropdb.exe";
                    string s2 = @"C:\Program Files\PostgreSQL\11\bin\createdb.exe";
                    string s3 = @"C:\Program Files\PostgreSQL\11\bin\pg_restore.exe";
                    string arg1 = String.Format(@"-p {0} -U {1} {2}", ServerInfo.port, ServerInfo.username, ServerInfo.datebase);
                    string arg3 = String.Format(@"-p {0} -U {1} -d {2} -v " + filePath,ServerInfo.port,ServerInfo.username,ServerInfo.datebase);
                    //process1.StartInfo.EnvironmentVariables.Add("PGPASSWORD", ServerInfo.password);
                    process2.StartInfo.EnvironmentVariables.Add("PGPASSWORD", ServerInfo.password);
                    process3.StartInfo.EnvironmentVariables.Add("PGPASSWORD", ServerInfo.password);
                   // process1.StartInfo.FileName = s1;
                   // process1.StartInfo.Arguments = arg1;
                   // process1.Start();
                    //process1.WaitForExit();
                    process2.StartInfo.FileName = s2;
                    process2.StartInfo.Arguments = arg1;
                    process2.Start();
                    process2.WaitForExit();
                    process3.StartInfo.FileName = s3;
                    process3.StartInfo.Arguments = arg3;
                    process3.Start();
                    process3.WaitForExit();
                }
            }

            //string s1 = @"C:\Program Files\PostgreSQL\14\bin\pg_restore.exe";
            //string s2 = @"-p 1100 -U postgres -d test -v "+filePath;
            //Process process = new Process();
            //process.StartInfo.FileName = s1;
            //process.StartInfo.ArgumentList.Add(s2);
            //process.StartInfo.EnvironmentVariables.Add("PGPASSWORD", ServerInfo.password);
            //process.Start();
            //process.StartInfo.FileName = @"C:\Program Files\PostgreSQL\14\bin\pg_restore.exe";
            //process.StartInfo.ArgumentList.Add("-p " + ServerInfo.port);
            //process.StartInfo.ArgumentList.Add("-U " + ServerInfo.username);
            //process.StartInfo.ArgumentList.Add("-d test");
            //process.StartInfo.ArgumentList.Add(@"-v D:\s\lr7.sql");
            //Process.Start(s1, s2);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = folderBrowserDialog.SelectedPath;
                    string s1 = "> " + filePath + @"\lr17.sql";
                    var process = new Process();
                    //process.StartInfo.EnvironmentVariables.Add("PGPASSWORD", ServerInfo.password);
                    process.StartInfo.FileName = @"C:\Program Files\PostgreSQL\11\bin\pg_dump.exe";
                    process.StartInfo.ArgumentList.Add("-d " + ServerInfo.datebase);
                    process.StartInfo.ArgumentList.Add("-p " + ServerInfo.port);
                    process.StartInfo.ArgumentList.Add("-U " + ServerInfo.username);
                    process.StartInfo.ArgumentList.Add(s1);
                    process.Start();
                    process.WaitForExit();
                }
            }
        }
    }
}
