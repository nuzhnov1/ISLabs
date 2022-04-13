namespace Lab1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer Components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.InitButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ExecButton = new System.Windows.Forms.Button();
            this.QueryBox = new System.Windows.Forms.TextBox();
            this.QueryLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusValueLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TableView = new System.Windows.Forms.DataGridView();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).BeginInit();
            this.SuspendLayout();
            // 
            // InitButton
            // 
            this.InitButton.AutoSize = true;
            this.InitButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.InitButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.InitButton.FlatAppearance.BorderSize = 2;
            this.InitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InitButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.InitButton.ImageKey = "(нет)";
            this.InitButton.Location = new System.Drawing.Point(10, 10);
            this.InitButton.Margin = new System.Windows.Forms.Padding(10);
            this.InitButton.Name = "InitButton";
            this.InitButton.Size = new System.Drawing.Size(250, 50);
            this.InitButton.TabIndex = 8;
            this.InitButton.Text = "Инициализировать соединение";
            this.InitButton.UseVisualStyleBackColor = false;
            this.InitButton.Click += new System.EventHandler(this.InitButtonClick);
            // 
            // OpenButton
            // 
            this.OpenButton.AutoSize = true;
            this.OpenButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.OpenButton.Enabled = false;
            this.OpenButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.OpenButton.FlatAppearance.BorderSize = 2;
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.OpenButton.ImageKey = "(нет)";
            this.OpenButton.Location = new System.Drawing.Point(10, 80);
            this.OpenButton.Margin = new System.Windows.Forms.Padding(10);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(250, 50);
            this.OpenButton.TabIndex = 9;
            this.OpenButton.Text = "Открыть соединение";
            this.OpenButton.UseVisualStyleBackColor = false;
            this.OpenButton.Click += new System.EventHandler(this.OpenButtonClick);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.CloseButton.Enabled = false;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.CloseButton.FlatAppearance.BorderSize = 2;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CloseButton.ImageKey = "(нет)";
            this.CloseButton.Location = new System.Drawing.Point(280, 10);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(10);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(250, 50);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "Закрыть соединение";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // ExecButton
            // 
            this.ExecButton.AutoSize = true;
            this.ExecButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.ExecButton.Enabled = false;
            this.ExecButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.ExecButton.FlatAppearance.BorderSize = 2;
            this.ExecButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExecButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ExecButton.ImageKey = "(нет)";
            this.ExecButton.Location = new System.Drawing.Point(280, 80);
            this.ExecButton.Margin = new System.Windows.Forms.Padding(10);
            this.ExecButton.Name = "ExecButton";
            this.ExecButton.Size = new System.Drawing.Size(250, 50);
            this.ExecButton.TabIndex = 11;
            this.ExecButton.Text = "Выполнить команду";
            this.ExecButton.UseVisualStyleBackColor = false;
            this.ExecButton.Click += new System.EventHandler(this.ExecuteButtonClick);
            // 
            // QueryBox
            // 
            this.QueryBox.AcceptsReturn = true;
            this.QueryBox.AcceptsTab = true;
            this.QueryBox.AllowDrop = true;
            this.QueryBox.Enabled = false;
            this.QueryBox.HideSelection = false;
            this.QueryBox.Location = new System.Drawing.Point(550, 68);
            this.QueryBox.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.QueryBox.Multiline = true;
            this.QueryBox.Name = "QueryBox";
            this.QueryBox.Size = new System.Drawing.Size(450, 84);
            this.QueryBox.TabIndex = 13;
            this.QueryBox.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // QueryLabel
            // 
            this.QueryLabel.AutoSize = true;
            this.QueryLabel.Location = new System.Drawing.Point(549, 49);
            this.QueryLabel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.QueryLabel.Name = "QueryLabel";
            this.QueryLabel.Size = new System.Drawing.Size(167, 19);
            this.QueryLabel.TabIndex = 14;
            this.QueryLabel.Text = "Команда на языке SQL:";
            this.QueryLabel.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StatusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.StatusLabel.Location = new System.Drawing.Point(550, 10);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(142, 19);
            this.StatusLabel.TabIndex = 16;
            this.StatusLabel.Text = "Статус соединения:";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StatusLabel.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // StatusValueLabel
            // 
            this.StatusValueLabel.AutoSize = true;
            this.StatusValueLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StatusValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusValueLabel.ForeColor = System.Drawing.Color.Black;
            this.StatusValueLabel.Location = new System.Drawing.Point(692, 10);
            this.StatusValueLabel.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.StatusValueLabel.Name = "StatusValueLabel";
            this.StatusValueLabel.Size = new System.Drawing.Size(161, 19);
            this.StatusValueLabel.TabIndex = 17;
            this.StatusValueLabel.Text = "не инициализировано";
            this.StatusValueLabel.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.TableView);
            this.MainPanel.Controls.Add(this.InitButton);
            this.MainPanel.Controls.Add(this.StatusValueLabel);
            this.MainPanel.Controls.Add(this.ExecButton);
            this.MainPanel.Controls.Add(this.StatusLabel);
            this.MainPanel.Controls.Add(this.OpenButton);
            this.MainPanel.Controls.Add(this.QueryLabel);
            this.MainPanel.Controls.Add(this.CloseButton);
            this.MainPanel.Controls.Add(this.QueryBox);
            this.MainPanel.Location = new System.Drawing.Point(9, 9);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1011, 552);
            this.MainPanel.TabIndex = 18;
            this.MainPanel.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // TableView
            // 
            this.TableView.AllowUserToAddRows = false;
            this.TableView.AllowUserToDeleteRows = false;
            this.TableView.AllowUserToOrderColumns = true;
            this.TableView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableView.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.TableView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.TableView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.TableView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableView.DefaultCellStyle = dataGridViewCellStyle2;
            this.TableView.Enabled = false;
            this.TableView.EnableHeadersVisualStyles = false;
            this.TableView.GridColor = System.Drawing.Color.Black;
            this.TableView.Location = new System.Drawing.Point(10, 162);
            this.TableView.Margin = new System.Windows.Forms.Padding(0);
            this.TableView.Name = "TableView";
            this.TableView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TableView.RowTemplate.Height = 25;
            this.TableView.ShowCellToolTips = false;
            this.TableView.ShowEditingIcon = false;
            this.TableView.Size = new System.Drawing.Size(1001, 390);
            this.TableView.TabIndex = 21;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1029, 570);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "ИС. Лабораторная работа №1. Команда - HydraSquad.";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InitButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ExecButton;
        private System.Windows.Forms.TextBox QueryBox;
        private System.Windows.Forms.Label QueryLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label StatusValueLabel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.DataGridView TableView;
    }
}
