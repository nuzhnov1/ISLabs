namespace Lab1
{
    partial class ConnectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer Components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (Components != null))
            {
                Components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionForm));
            this.ExitButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.DBNameLabel = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.DBName = new System.Windows.Forms.TextBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.IP = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.TextBox();
            this.IPLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ExitButton.Location = new System.Drawing.Point(214, 237);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(10);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(109, 31);
            this.ExitButton.TabIndex = 27;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButtonClick);
            this.ExitButton.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.KeyPressed);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.AutoSize = true;
            this.ConfirmButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.ConfirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ConfirmButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ConfirmButton.Location = new System.Drawing.Point(58, 237);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(10);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(109, 31);
            this.ConfirmButton.TabIndex = 26;
            this.ConfirmButton.Text = "Подтвердить";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButtonClick);
            this.ConfirmButton.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.KeyPressed);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(63, 181);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(10);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(61, 19);
            this.PasswordLabel.TabIndex = 18;
            this.PasswordLabel.Text = "Пароль:";
            this.PasswordLabel.Click += new System.EventHandler(this.EnviromentClick);
            this.PasswordLabel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.KeyPressed);
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(20, 145);
            this.UserLabel.Margin = new System.Windows.Forms.Padding(10);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(104, 19);
            this.UserLabel.TabIndex = 17;
            this.UserLabel.Text = "Пользователь:";
            this.UserLabel.Click += new System.EventHandler(this.EnviromentClick);
            this.UserLabel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.KeyPressed);
            // 
            // DBNameLabel
            // 
            this.DBNameLabel.AutoSize = true;
            this.DBNameLabel.Location = new System.Drawing.Point(25, 106);
            this.DBNameLabel.Margin = new System.Windows.Forms.Padding(10);
            this.DBNameLabel.Name = "DBNameLabel";
            this.DBNameLabel.Size = new System.Drawing.Size(99, 19);
            this.DBNameLabel.TabIndex = 16;
            this.DBNameLabel.Text = "Название БД:";
            this.DBNameLabel.Click += new System.EventHandler(this.EnviromentClick);
            this.DBNameLabel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.KeyPressed);
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(134, 142);
            this.User.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(228, 26);
            this.User.TabIndex = 22;
            this.User.Text = "admin";
            this.User.Click += new System.EventHandler(this.EnviromentClick);
            this.User.TextChanged += new System.EventHandler(this.User_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(134, 181);
            this.Password.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(228, 26);
            this.Password.TabIndex = 23;
            this.Password.UseSystemPasswordChar = true;
            this.Password.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // DBName
            // 
            this.DBName.Location = new System.Drawing.Point(134, 103);
            this.DBName.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.DBName.Name = "DBName";
            this.DBName.Size = new System.Drawing.Size(228, 26);
            this.DBName.TabIndex = 21;
            this.DBName.Text = "restaurant";
            this.DBName.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(78, 62);
            this.PortLabel.Margin = new System.Windows.Forms.Padding(10);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(46, 19);
            this.PortLabel.TabIndex = 15;
            this.PortLabel.Text = "Порт:";
            this.PortLabel.Click += new System.EventHandler(this.EnviromentClick);
            this.PortLabel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.KeyPressed);
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(134, 20);
            this.IP.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(228, 26);
            this.IP.TabIndex = 19;
            this.IP.Text = "localhost";
            this.IP.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(134, 59);
            this.Port.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(228, 26);
            this.Port.TabIndex = 20;
            this.Port.Text = "5432";
            this.Port.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IPLabel.Location = new System.Drawing.Point(58, 23);
            this.IPLabel.Margin = new System.Windows.Forms.Padding(10);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(66, 19);
            this.IPLabel.TabIndex = 14;
            this.IPLabel.Text = "IP адрес:";
            this.IPLabel.Click += new System.EventHandler(this.EnviromentClick);
            this.IPLabel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.KeyPressed);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.DBNameLabel);
            this.MainPanel.Controls.Add(this.ExitButton);
            this.MainPanel.Controls.Add(this.User);
            this.MainPanel.Controls.Add(this.IPLabel);
            this.MainPanel.Controls.Add(this.Password);
            this.MainPanel.Controls.Add(this.ConfirmButton);
            this.MainPanel.Controls.Add(this.UserLabel);
            this.MainPanel.Controls.Add(this.Port);
            this.MainPanel.Controls.Add(this.DBName);
            this.MainPanel.Controls.Add(this.IP);
            this.MainPanel.Controls.Add(this.PasswordLabel);
            this.MainPanel.Controls.Add(this.PortLabel);
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(386, 289);
            this.MainPanel.TabIndex = 28;
            this.MainPanel.Click += new System.EventHandler(this.EnviromentClick);
            this.MainPanel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.KeyPressed);
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(410, 313);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConnectionForm";
            this.Text = "Окно инициализации соединения";
            this.Click += new System.EventHandler(this.EnviromentClick);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.KeyPressed);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label DBNameLabel;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox DBName;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.Panel MainPanel;
    }
}
