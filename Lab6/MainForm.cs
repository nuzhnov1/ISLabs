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
        NpgsqlConnection connection= new NpgsqlConnection(ServerInfo.GetConnectionString());
        public MainForm()
        {
            InitializeComponent();

            try
            {
                connection.Open();

                string query = "SELECT datname From pg_database WHERE  datistemplate=false";
                var adapter = new NpgsqlDataAdapter(query, connection);
                var dataSet = new DataSet();

                adapter.Fill(dataSet);

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    treeView1.Nodes.Add(new TreeNode(row[0].ToString()));
                }
            }
            catch (SystemException exception)
            {
                MessageBox.Show(
                    exception.Message, "Ошибка подключения к базе данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );

            }

            connection.Close();
        }


        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            connection.Open();

            if (e.Node.Parent!=null)
            {
                connection.ChangeDatabase(e.Node.Parent.Text);
                string query = "select * from " + e.Node.Text;
                var command = new NpgsqlCommand(query, connection);
                var dataSet = new DataSet();
                var adapter= new NpgsqlDataAdapter(command);

                adapter.Fill(dataSet);
                dataGridView1.DataSource=dataSet.Tables[0];
            }
            else
            {
                connection.ChangeDatabase(e.Node.Text);
                DataTable dbTables = connection.GetSchema("Tables");   

                foreach (DataRow row in dbTables.Rows)
                {
                    treeView1.Nodes[e.Node.Index].Nodes.Add(new TreeNode(row["table_name"].ToString()));
                }
            }

            connection.Close();
        }

    }
}
