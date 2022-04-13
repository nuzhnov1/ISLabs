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

namespace Lab6
{
    public partial class MainForm : Form
    {
        private readonly NpgsqlConnection Connection;
        
        public MainForm()
        {
            InitializeComponent();
            this.Connection = new NpgsqlConnection(ServerInfo.GetConnectionString());

            try
            {
                this.Connection.Open();

                string queryString = "SELECT datname FROM pg_database WHERE datistemplate = false";
                var query = new NpgsqlCommand(queryString, this.Connection);
                var reader = query.ExecuteReader();
                var table = new DataTable();

                table.Load(reader);

                foreach (DataRow row in table.Rows)
                {
                    this.TreeView.Nodes.Add(new TreeNode(row["datname"].ToString()));
                }
            }
            catch (SystemException error)
            {
                MessageBox.Show(
                    $"Ошибка подключения к базе данных: {error.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }


        private async void TreeViewNodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs eventArgs)
        {
            try
            {
                // Если выбрана одна из таблиц базы данных:
                if (eventArgs.Node.Parent != null)
                {
                    await this.Connection.ChangeDatabaseAsync(eventArgs.Node.Parent.Text);

                    string queryString = "SELECT * FROM " + eventArgs.Node.Text;
                    var query = new NpgsqlCommand(queryString, this.Connection);
                    var reader = await query.ExecuteReaderAsync();
                    var table = new DataTable();

                    table.Load(reader);
                    this.TableView.DataSource = table;
                }
                // Если выбрана база данных:
                else
                {
                    await this.Connection.ChangeDatabaseAsync(eventArgs.Node.Text);
                    DataTable schema = await this.Connection.GetSchemaAsync("Tables");

                    this.TreeView.Nodes[eventArgs.Node.Index].Nodes.Clear();
                    foreach (DataRow row in schema.Rows)
                    {
                        this.TreeView.Nodes[eventArgs.Node.Index].Nodes.Add(new TreeNode(row["table_name"].ToString()));
                    }
                }
            }
            catch (SystemException error)
            {
                MessageBox.Show(
                    $"Ошибка при получении данных: {error.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        private void EnviromentClick(object sender, EventArgs e) => ((Control)sender).Select();
    }
}
