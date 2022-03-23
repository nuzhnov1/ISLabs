namespace Lab5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ShowButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.updateButton = new System.Windows.Forms.Button();
            this.customButton = new System.Windows.Forms.Button();
            this.TableView = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowButton
            // 
            this.ShowButton.AutoSize = true;
            this.ShowButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.ShowButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.ShowButton.FlatAppearance.BorderSize = 2;
            this.ShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ShowButton.ImageKey = "(нет)";
            this.ShowButton.Location = new System.Drawing.Point(838, 0);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 50);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(163, 50);
            this.ShowButton.TabIndex = 8;
            this.ShowButton.Text = "Показать";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButtonClick);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.updateButton);
            this.MainPanel.Controls.Add(this.customButton);
            this.MainPanel.Controls.Add(this.TableView);
            this.MainPanel.Controls.Add(this.DeleteButton);
            this.MainPanel.Controls.Add(this.InsertButton);
            this.MainPanel.Controls.Add(this.ShowButton);
            this.MainPanel.Location = new System.Drawing.Point(14, 14);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(5);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1001, 547);
            this.MainPanel.TabIndex = 18;
            this.MainPanel.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // updateButton
            // 
            this.updateButton.AutoSize = true;
            this.updateButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.updateButton.Enabled = false;
            this.updateButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.updateButton.FlatAppearance.BorderSize = 2;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updateButton.ImageKey = "(нет)";
            this.updateButton.Location = new System.Drawing.Point(838, 240);
            this.updateButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 20);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(163, 50);
            this.updateButton.TabIndex = 23;
            this.updateButton.Text = "Обновить";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // customButton
            // 
            this.customButton.AutoSize = true;
            this.customButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.customButton.Enabled = false;
            this.customButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.customButton.FlatAppearance.BorderSize = 2;
            this.customButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.customButton.ImageKey = "(нет)";
            this.customButton.Location = new System.Drawing.Point(838, 310);
            this.customButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 20);
            this.customButton.Name = "customButton";
            this.customButton.Size = new System.Drawing.Size(163, 50);
            this.customButton.TabIndex = 22;
            this.customButton.Text = "Запрос";
            this.customButton.UseVisualStyleBackColor = false;
            this.customButton.Click += new System.EventHandler(this.customButton_Click);
            // 
            // TableView
            // 
            this.TableView.AllowUserToAddRows = false;
            this.TableView.AllowUserToDeleteRows = false;
            this.TableView.AllowUserToResizeColumns = false;
            this.TableView.AllowUserToResizeRows = false;
            this.TableView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.TableView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TableView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.TableView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.TableView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableView.DefaultCellStyle = dataGridViewCellStyle2;
            this.TableView.Enabled = false;
            this.TableView.EnableHeadersVisualStyles = false;
            this.TableView.Location = new System.Drawing.Point(0, 0);
            this.TableView.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.TableView.Name = "TableView";
            this.TableView.RowHeadersVisible = false;
            this.TableView.RowTemplate.Height = 25;
            this.TableView.ShowCellToolTips = false;
            this.TableView.ShowEditingIcon = false;
            this.TableView.Size = new System.Drawing.Size(828, 547);
            this.TableView.TabIndex = 20;
            this.TableView.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.DeleteButton.Enabled = false;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.DeleteButton.FlatAppearance.BorderSize = 2;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DeleteButton.ImageKey = "(нет)";
            this.DeleteButton.Location = new System.Drawing.Point(838, 170);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 20);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(163, 50);
            this.DeleteButton.TabIndex = 19;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // InsertButton
            // 
            this.InsertButton.AutoSize = true;
            this.InsertButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.InsertButton.Enabled = false;
            this.InsertButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.InsertButton.FlatAppearance.BorderSize = 2;
            this.InsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InsertButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.InsertButton.ImageKey = "(нет)";
            this.InsertButton.Location = new System.Drawing.Point(838, 100);
            this.InsertButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 20);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(163, 50);
            this.InsertButton.TabIndex = 18;
            this.InsertButton.Text = "Вставить";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButtonClick);
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
            this.Text = "ИС. Лабораторная работа №2. Команда - HydraSquad.";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.DataGridView TableView;
        private System.Windows.Forms.Button customButton;
        private System.Windows.Forms.Button updateButton;
    }
}
