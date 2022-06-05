using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RGZ.DAO;

namespace RGZ
{
    public partial class MainForm : Form
    {
        // Дескриптор соединения с БД
        private readonly NpgsqlConnection connection;
        // Таблица с данными
        private AbstractDAO CurrentTable;
        // Словарь, отображающий имена таблиц на сами таблицы
        private Dictionary<string, AbstractDAO> dict;
        // Список ID удаляемых строк из TableView
        private List<int> deletedRows;

        public MainForm()
        {
            this.connection = new NpgsqlConnection();
            this.CurrentTable = null;
            this.dict = new Dictionary<string, AbstractDAO>(8);
            this.deletedRows = new List<int>(10);

            dict.Add("Сотрудники", new EmployeeDAO());
            dict.Add("Курсы", new CoursesDAO());
            dict.Add("Сведения о прохождении курсов", new CompletedCoursesDAO());
            dict.Add("Список должностей", new PositionsDAO());
            dict.Add("Список отделов", new DepartmentsDAO());

            foreach (string tablename in dict.Keys)
                dict[tablename].TableName = tablename;

            InitializeComponent();
            TableBox.Items.AddRange(dict.Keys.ToArray());
        }

        private void ConnectionButtonClick(object sender, EventArgs e)
        {
            string connectionString =@$"
                Host = {HostTextBox.Text};
                Port = {PortTextBox.Text};
                Database = {DbTextBox.Text};
                Username = {UsernameTextBox.Text};
                Password = {PasswordTextBox.Text};
            ";

            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();
            }
            catch (NpgsqlException error)
            {
                MessageBox.Show(
                    $"Ошибка при подключении к базе данных: {error.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );

                return;
            }

            try
            {
                AbstractDAO departments = dict["Список отделов"];
                departments.Fill(connection);
                
                DepartamentBox.Items.Clear();
                foreach (DataRow row in departments.Rows)
                    DepartamentBox.Items.Add(row["name"]);
            }
            catch (SystemException error)
            {
                MessageBox.Show(
                    $"Ошибка извлечения данных из БД: {error.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );

                return;
            }

            TableView.Enabled = true;
            ConnectionButton.Enabled = false;
            CloseButton.Enabled = true;
            PasswordTextBox.Text = "";
            ControlPanel.Enabled = true;
            TableBox.SelectedItem = "Сотрудники";
        }

        private void CloseButtonClick(object sender, EventArgs e)
        {
            try
            {
                connection.Close();
            }
            catch (NpgsqlException error)
            {
                MessageBox.Show(
                    $"Ошибка при закрытии соединения: {error.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );

                return;
            }

            TableView.Enabled = false;
            ConnectionButton.Enabled = true;
            CloseButton.Enabled = false;
            ControlPanel.Enabled = false;
        }

        private void SelectedTableChanged(object sender, EventArgs e)
        {
            string selectedTable = TableBox.Text;

            try
            {
                deletedRows.Clear();
                CurrentTable = dict[selectedTable];
                CurrentTable.Fill(connection);
                SetTableView();
            }
            catch (SystemException error)
            {
                MessageBox.Show(
                    $"Ошибка извлечения данных из БД: {error.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );

                return;
            }

            if (selectedTable == "Сотрудники, не проходившие обучение в течение более года")
                UpdateButton.Enabled = false;
            else
                UpdateButton.Enabled = true;
        }

        private void SelectedPeriodChanged(object sender, EventArgs e)
        {
            string period;
            string suffix;
            
            if (PeriodBox.Text == "Год")
            {
                period = "1 year";
                suffix = "года";
            }
            else
            {
                period = "1 month";
                suffix = "месяца";
            }

            try
            {
                deletedRows.Clear();
                CurrentTable = new TrainedEmployeeDAO(period);
                CurrentTable.TableName = $"Сотрудники, проходящие обучение в течение {suffix}";
                CurrentTable.Fill(connection);
                SetTableView();
            }
            catch (SystemException error)
            {
                MessageBox.Show(
                    $"Ошибка извлечения данных из БД: {error.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );

                return;
            }

            UpdateButton.Enabled = false;
        }

        private void SelectedDepartmentChanged(object sender, EventArgs e)
        {
            string department = DepartamentBox.Text;
            
            try
            {
                deletedRows.Clear();
                CurrentTable = new TrainedEmployeeByDepartmentDAO(department);
                CurrentTable.TableName = $"Сотрудники отдела '{department}' и курсы, которые они прослушали";
                CurrentTable.Fill(connection);
                SetTableView();
            }
            catch (SystemException error)
            {
                MessageBox.Show(
                    $"Ошибка извлечения данных из БД: {error.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );

                return;
            }

            UpdateButton.Enabled = false;
        }

        private void UpdateButtonClick(object sender, EventArgs e)
        {
            try
            {
                DataTable newRows = CurrentTable.GetChanges(DataRowState.Added);
                DataTable updatedRows = CurrentTable.GetChanges(DataRowState.Modified);

                if (newRows != null)
                {
                    foreach (DataRow insertedRow in newRows.Rows)
                        CurrentTable.Insert(connection, insertedRow);
                }

                if (updatedRows != null)
                {
                    foreach (DataRow updatedRow in updatedRows.Rows)
                        CurrentTable.Update(connection, updatedRow);
                }

                foreach (int index in deletedRows)
                    CurrentTable.Delete(connection, index);
            }
            catch (SystemException error)
            {
                MessageBox.Show(
                    $"Не удалось обновить данные в БД: {error.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );

                return;
            }

            try
            {
                deletedRows.Clear();
                CurrentTable.Fill(connection);
                SetTableView();
            }
            catch (SystemException error)
            {
                MessageBox.Show(
                    $"Ошибка извлечения данных из БД: {error.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );

                return;
            }


            DataTable departments = dict["Список отделов"];
           
            DepartamentBox.Items.Clear(); 
            foreach (DataRow row in departments.Rows)
                DepartamentBox.Items.Add(row["name"]);
        }

        private void UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            deletedRows.Add(int.Parse((string)e.Row.Cells["id"].Value));
        }

        private void EnviromentClick(object sender, EventArgs e) => ((Control)sender).Select();

        private void SetTableView()
        {
            TableNameLabel.Text = CurrentTable.TableName;

            this.TableView.DataSource = this.CurrentTable;
            this.TableView.AllowUserToAddRows = this.CurrentTable.AllowInsert;
            this.TableView.AllowUserToDeleteRows = this.CurrentTable.AllowDelete;

            foreach (DataGridViewColumn column in this.TableView.Columns)
                column.HeaderText = this.CurrentTable.Columns[column.Name].Caption;
        }
    }
}
