using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace Lab1
{
    public partial class ConnectionForm : Form
    {
        // Строка соединения (для внешнего кода доступно только чтение)
        public string ConnectionString { get; private set; }

        public ConnectionForm()
        {
            InitializeComponent();
            this.ConnectionString = "";
        }

        private void Confirm()
        {
            this.ConnectionString = String.Format(
                "Host = {0}; Port = {1}; Database = {2}; " +
                "Username = {3}; Password = {4};",
                this.IP.Text, this.Port.Text, this.DBName.Text,
                this.User.Text, this.Password.Text
            );

            this.Hide();
        }

        private void Exit() => this.Hide();

        private void ConfirmButtonClick(object sender, EventArgs e) => Confirm();
        private void ExitButtonClick(object sender, EventArgs e) => Exit();
        private void EnviromentClick(object sender, EventArgs e) => ((Control)sender).Select();

        /// <summary>
        /// Событие, которое вызывается при нажатии клавиш
        /// </summary>
        /// <param name="sender">Объект, который вызвал данное событие</param>
        /// <param name="e"></param>
        private void KeyPressed(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Confirm();
            else if (e.KeyCode == Keys.Escape)
                Exit();
        }

        private void User_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
