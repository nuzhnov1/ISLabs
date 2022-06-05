namespace RGZ
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TableView = new System.Windows.Forms.DataGridView();
            this.DataGridPanel = new System.Windows.Forms.Panel();
            this.TableNameLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ConnectionPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.HostLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.HostTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.ConnectionButton = new System.Windows.Forms.Button();
            this.DbLabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.DbTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.TableBoxLabel = new System.Windows.Forms.Label();
            this.DepartamentBoxLabel = new System.Windows.Forms.Label();
            this.DepartamentBox = new System.Windows.Forms.ComboBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.PeriodBoxLabel = new System.Windows.Forms.Label();
            this.TableBox = new System.Windows.Forms.ComboBox();
            this.PeriodBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).BeginInit();
            this.DataGridPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.ConnectionPanel.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableView
            // 
            this.TableView.AllowUserToOrderColumns = true;
            this.TableView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableView.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.TableView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.TableView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableView.ColumnHeadersHeight = 60;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableView.DefaultCellStyle = dataGridViewCellStyle2;
            this.TableView.Enabled = false;
            this.TableView.EnableHeadersVisualStyles = false;
            this.TableView.GridColor = System.Drawing.Color.Black;
            this.TableView.Location = new System.Drawing.Point(0, 25);
            this.TableView.Margin = new System.Windows.Forms.Padding(0);
            this.TableView.Name = "TableView";
            this.TableView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TableView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TableView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DarkOrange;
            this.TableView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TableView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.TableView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkCyan;
            this.TableView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.TableView.RowTemplate.Height = 60;
            this.TableView.Size = new System.Drawing.Size(988, 404);
            this.TableView.TabIndex = 21;
            this.TableView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.UserDeletingRow);
            this.TableView.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // DataGridPanel
            // 
            this.DataGridPanel.Controls.Add(this.TableNameLabel);
            this.DataGridPanel.Controls.Add(this.TableView);
            this.DataGridPanel.Location = new System.Drawing.Point(10, 10);
            this.DataGridPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.DataGridPanel.Name = "DataGridPanel";
            this.DataGridPanel.Size = new System.Drawing.Size(988, 429);
            this.DataGridPanel.TabIndex = 22;
            this.DataGridPanel.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // TableNameLabel
            // 
            this.TableNameLabel.AutoSize = true;
            this.TableNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TableNameLabel.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TableNameLabel.Location = new System.Drawing.Point(0, 0);
            this.TableNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TableNameLabel.Name = "TableNameLabel";
            this.TableNameLabel.Size = new System.Drawing.Size(18, 25);
            this.TableNameLabel.TabIndex = 22;
            this.TableNameLabel.Text = " ";
            this.TableNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TableNameLabel.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.ConnectionPanel);
            this.MainPanel.Controls.Add(this.ControlPanel);
            this.MainPanel.Location = new System.Drawing.Point(10, 449);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(988, 202);
            this.MainPanel.TabIndex = 23;
            this.MainPanel.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // ConnectionPanel
            // 
            this.ConnectionPanel.Controls.Add(this.CloseButton);
            this.ConnectionPanel.Controls.Add(this.HostLabel);
            this.ConnectionPanel.Controls.Add(this.PasswordLabel);
            this.ConnectionPanel.Controls.Add(this.HostTextBox);
            this.ConnectionPanel.Controls.Add(this.PasswordTextBox);
            this.ConnectionPanel.Controls.Add(this.PortTextBox);
            this.ConnectionPanel.Controls.Add(this.ConnectionButton);
            this.ConnectionPanel.Controls.Add(this.DbLabel);
            this.ConnectionPanel.Controls.Add(this.PortLabel);
            this.ConnectionPanel.Controls.Add(this.DbTextBox);
            this.ConnectionPanel.Controls.Add(this.UsernameTextBox);
            this.ConnectionPanel.Controls.Add(this.UsernameLabel);
            this.ConnectionPanel.Location = new System.Drawing.Point(20, 0);
            this.ConnectionPanel.Margin = new System.Windows.Forms.Padding(20, 0, 50, 0);
            this.ConnectionPanel.Name = "ConnectionPanel";
            this.ConnectionPanel.Size = new System.Drawing.Size(461, 202);
            this.ConnectionPanel.TabIndex = 39;
            this.ConnectionPanel.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.CloseButton.Enabled = false;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.CloseButton.FlatAppearance.BorderSize = 2;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.CloseButton.ImageKey = "(нет)";
            this.CloseButton.Location = new System.Drawing.Point(310, 121);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(150, 50);
            this.CloseButton.TabIndex = 39;
            this.CloseButton.Text = "Закрыть соединения";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // HostLabel
            // 
            this.HostLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HostLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HostLabel.Location = new System.Drawing.Point(0, 10);
            this.HostLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.HostLabel.Name = "HostLabel";
            this.HostLabel.Size = new System.Drawing.Size(150, 26);
            this.HostLabel.TabIndex = 30;
            this.HostLabel.Text = "Имя хоста:";
            this.HostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HostLabel.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PasswordLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.Location = new System.Drawing.Point(0, 173);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(150, 26);
            this.PasswordLabel.TabIndex = 38;
            this.PasswordLabel.Text = "Пароль:";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PasswordLabel.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // HostTextBox
            // 
            this.HostTextBox.BackColor = System.Drawing.Color.Black;
            this.HostTextBox.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.HostTextBox.Location = new System.Drawing.Point(150, 10);
            this.HostTextBox.Margin = new System.Windows.Forms.Padding(0, 10, 10, 5);
            this.HostTextBox.Name = "HostTextBox";
            this.HostTextBox.PlaceholderText = "IP-адрес или доменное имя";
            this.HostTextBox.Size = new System.Drawing.Size(150, 26);
            this.HostTextBox.TabIndex = 29;
            this.HostTextBox.Text = "localhost";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.Black;
            this.PasswordTextBox.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.PasswordTextBox.Location = new System.Drawing.Point(150, 173);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(0, 10, 10, 5);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(150, 26);
            this.PasswordTextBox.TabIndex = 37;
            // 
            // PortTextBox
            // 
            this.PortTextBox.BackColor = System.Drawing.Color.Black;
            this.PortTextBox.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.PortTextBox.Location = new System.Drawing.Point(150, 50);
            this.PortTextBox.Margin = new System.Windows.Forms.Padding(0, 10, 10, 5);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.PlaceholderText = "Число от 0 до 65535";
            this.PortTextBox.Size = new System.Drawing.Size(150, 26);
            this.PortTextBox.TabIndex = 31;
            this.PortTextBox.Text = "5432";
            // 
            // ConnectionButton
            // 
            this.ConnectionButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.ConnectionButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.ConnectionButton.FlatAppearance.BorderSize = 2;
            this.ConnectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectionButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConnectionButton.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.ConnectionButton.ImageKey = "(нет)";
            this.ConnectionButton.Location = new System.Drawing.Point(310, 35);
            this.ConnectionButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.ConnectionButton.Name = "ConnectionButton";
            this.ConnectionButton.Size = new System.Drawing.Size(150, 50);
            this.ConnectionButton.TabIndex = 24;
            this.ConnectionButton.Text = "Соединиться с БД";
            this.ConnectionButton.UseVisualStyleBackColor = false;
            this.ConnectionButton.Click += new System.EventHandler(this.ConnectionButtonClick);
            // 
            // DbLabel
            // 
            this.DbLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DbLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DbLabel.Location = new System.Drawing.Point(0, 133);
            this.DbLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.DbLabel.Name = "DbLabel";
            this.DbLabel.Size = new System.Drawing.Size(150, 26);
            this.DbLabel.TabIndex = 36;
            this.DbLabel.Text = "Название БД:";
            this.DbLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DbLabel.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // PortLabel
            // 
            this.PortLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PortLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PortLabel.Location = new System.Drawing.Point(0, 51);
            this.PortLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(150, 26);
            this.PortLabel.TabIndex = 32;
            this.PortLabel.Text = "Порт:";
            this.PortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PortLabel.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // DbTextBox
            // 
            this.DbTextBox.BackColor = System.Drawing.Color.Black;
            this.DbTextBox.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.DbTextBox.Location = new System.Drawing.Point(150, 133);
            this.DbTextBox.Margin = new System.Windows.Forms.Padding(0, 10, 10, 5);
            this.DbTextBox.Name = "DbTextBox";
            this.DbTextBox.Size = new System.Drawing.Size(150, 26);
            this.DbTextBox.TabIndex = 35;
            this.DbTextBox.Text = "study_center";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.Color.Black;
            this.UsernameTextBox.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.UsernameTextBox.Location = new System.Drawing.Point(150, 93);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(0, 10, 10, 5);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.PlaceholderText = "Строка";
            this.UsernameTextBox.Size = new System.Drawing.Size(150, 26);
            this.UsernameTextBox.TabIndex = 33;
            this.UsernameTextBox.Text = "sunman";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UsernameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameLabel.Location = new System.Drawing.Point(0, 92);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(150, 26);
            this.UsernameLabel.TabIndex = 34;
            this.UsernameLabel.Text = "Имя пользователя:";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UsernameLabel.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.TableBoxLabel);
            this.ControlPanel.Controls.Add(this.DepartamentBoxLabel);
            this.ControlPanel.Controls.Add(this.DepartamentBox);
            this.ControlPanel.Controls.Add(this.UpdateButton);
            this.ControlPanel.Controls.Add(this.PeriodBoxLabel);
            this.ControlPanel.Controls.Add(this.TableBox);
            this.ControlPanel.Controls.Add(this.PeriodBox);
            this.ControlPanel.Enabled = false;
            this.ControlPanel.Location = new System.Drawing.Point(493, 0);
            this.ControlPanel.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(475, 202);
            this.ControlPanel.TabIndex = 29;
            this.ControlPanel.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // TableBoxLabel
            // 
            this.TableBoxLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TableBoxLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TableBoxLabel.Location = new System.Drawing.Point(0, 0);
            this.TableBoxLabel.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.TableBoxLabel.Name = "TableBoxLabel";
            this.TableBoxLabel.Size = new System.Drawing.Size(150, 60);
            this.TableBoxLabel.TabIndex = 23;
            this.TableBoxLabel.Text = "Сведения:";
            this.TableBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TableBoxLabel.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // DepartamentBoxLabel
            // 
            this.DepartamentBoxLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DepartamentBoxLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DepartamentBoxLabel.Location = new System.Drawing.Point(320, 0);
            this.DepartamentBoxLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.DepartamentBoxLabel.Name = "DepartamentBoxLabel";
            this.DepartamentBoxLabel.Size = new System.Drawing.Size(150, 60);
            this.DepartamentBoxLabel.TabIndex = 28;
            this.DepartamentBoxLabel.Text = "Сотрудники, прослушавшие курсы в отделе:";
            this.DepartamentBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DepartamentBoxLabel.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // DepartamentBox
            // 
            this.DepartamentBox.BackColor = System.Drawing.Color.Black;
            this.DepartamentBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartamentBox.DropDownWidth = 400;
            this.DepartamentBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DepartamentBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DepartamentBox.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.DepartamentBox.FormattingEnabled = true;
            this.DepartamentBox.Location = new System.Drawing.Point(320, 60);
            this.DepartamentBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.DepartamentBox.Name = "DepartamentBox";
            this.DepartamentBox.Size = new System.Drawing.Size(150, 23);
            this.DepartamentBox.TabIndex = 27;
            this.DepartamentBox.SelectedValueChanged += new System.EventHandler(this.SelectedDepartmentChanged);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Black;
            this.UpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.UpdateButton.FlatAppearance.BorderSize = 2;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateButton.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.UpdateButton.ImageKey = "(нет)";
            this.UpdateButton.Location = new System.Drawing.Point(0, 103);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(150, 50);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // PeriodBoxLabel
            // 
            this.PeriodBoxLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PeriodBoxLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PeriodBoxLabel.Location = new System.Drawing.Point(160, 0);
            this.PeriodBoxLabel.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.PeriodBoxLabel.Name = "PeriodBoxLabel";
            this.PeriodBoxLabel.Size = new System.Drawing.Size(150, 60);
            this.PeriodBoxLabel.TabIndex = 26;
            this.PeriodBoxLabel.Text = "Сотрудники, проходящие обучение:";
            this.PeriodBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PeriodBoxLabel.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // TableBox
            // 
            this.TableBox.BackColor = System.Drawing.Color.Black;
            this.TableBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableBox.DropDownWidth = 400;
            this.TableBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TableBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TableBox.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.TableBox.FormattingEnabled = true;
            this.TableBox.Location = new System.Drawing.Point(0, 60);
            this.TableBox.Margin = new System.Windows.Forms.Padding(0, 0, 10, 20);
            this.TableBox.Name = "TableBox";
            this.TableBox.Size = new System.Drawing.Size(150, 23);
            this.TableBox.TabIndex = 12;
            this.TableBox.SelectedValueChanged += new System.EventHandler(this.SelectedTableChanged);
            // 
            // PeriodBox
            // 
            this.PeriodBox.BackColor = System.Drawing.Color.Black;
            this.PeriodBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PeriodBox.DropDownWidth = 200;
            this.PeriodBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PeriodBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PeriodBox.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.PeriodBox.FormattingEnabled = true;
            this.PeriodBox.Items.AddRange(new object[] {
            "Месяц",
            "Год"});
            this.PeriodBox.Location = new System.Drawing.Point(160, 60);
            this.PeriodBox.Margin = new System.Windows.Forms.Padding(0, 0, 10, 20);
            this.PeriodBox.Name = "PeriodBox";
            this.PeriodBox.Size = new System.Drawing.Size(150, 23);
            this.PeriodBox.TabIndex = 25;
            this.PeriodBox.SelectedValueChanged += new System.EventHandler(this.SelectedPeriodChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.DataGridPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "ИС. Расчётно-графическая работа. Команда - HydraSquad.";
            this.Click += new System.EventHandler(this.EnviromentClick);
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).EndInit();
            this.DataGridPanel.ResumeLayout(false);
            this.DataGridPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.ConnectionPanel.ResumeLayout(false);
            this.ConnectionPanel.PerformLayout();
            this.ControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TableView;
        private System.Windows.Forms.Panel DataGridPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label TableNameLabel;
        private System.Windows.Forms.Label PeriodBoxLabel;
        private System.Windows.Forms.ComboBox PeriodBox;
        private System.Windows.Forms.Label TableBoxLabel;
        private System.Windows.Forms.ComboBox TableBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label DepartamentBoxLabel;
        private System.Windows.Forms.ComboBox DepartamentBox;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Panel ConnectionPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label HostLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox HostTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Button ConnectionButton;
        private System.Windows.Forms.Label DbLabel;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox DbTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label UsernameLabel;
    }
}