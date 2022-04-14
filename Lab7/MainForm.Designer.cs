namespace Lab7
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
            this.ShowButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.RestoreButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ExecuteButton = new System.Windows.Forms.Button();
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
            this.ShowButton.Text = "Показать таблицу";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButtonClick);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.RestoreButton);
            this.MainPanel.Controls.Add(this.SaveButton);
            this.MainPanel.Controls.Add(this.UpdateButton);
            this.MainPanel.Controls.Add(this.ExecuteButton);
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
            // RestoreButton
            // 
            this.RestoreButton.AutoSize = true;
            this.RestoreButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.RestoreButton.Enabled = false;
            this.RestoreButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.RestoreButton.FlatAppearance.BorderSize = 2;
            this.RestoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestoreButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RestoreButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RestoreButton.ImageKey = "(нет)";
            this.RestoreButton.Location = new System.Drawing.Point(838, 497);
            this.RestoreButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 20);
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.Size = new System.Drawing.Size(163, 50);
            this.RestoreButton.TabIndex = 24;
            this.RestoreButton.Text = "Восстановить";
            this.RestoreButton.UseVisualStyleBackColor = false;
            this.RestoreButton.Click += new System.EventHandler(this.RestoreButtonClick);
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSize = true;
            this.SaveButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.SaveButton.Enabled = false;
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.SaveButton.FlatAppearance.BorderSize = 2;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SaveButton.ImageKey = "(нет)";
            this.SaveButton.Location = new System.Drawing.Point(837, 427);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 20);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(164, 50);
            this.SaveButton.TabIndex = 23;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // UpdateButton
            // 
            this.UpdateButton.AutoSize = true;
            this.UpdateButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.UpdateButton.Enabled = false;
            this.UpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.UpdateButton.FlatAppearance.BorderSize = 2;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UpdateButton.ImageKey = "(нет)";
            this.UpdateButton.Location = new System.Drawing.Point(838, 240);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 20);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(163, 50);
            this.UpdateButton.TabIndex = 22;
            this.UpdateButton.Text = "Обновить данные";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.AutoSize = true;
            this.ExecuteButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.ExecuteButton.Enabled = false;
            this.ExecuteButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.ExecuteButton.FlatAppearance.BorderSize = 2;
            this.ExecuteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExecuteButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ExecuteButton.ImageKey = "(нет)";
            this.ExecuteButton.Location = new System.Drawing.Point(838, 310);
            this.ExecuteButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 20);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(163, 50);
            this.ExecuteButton.TabIndex = 21;
            this.ExecuteButton.Text = "Выполнить запрос";
            this.ExecuteButton.UseVisualStyleBackColor = false;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButtonClick);
            // 
            // TableView
            // 
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
            this.TableView.Location = new System.Drawing.Point(0, 0);
            this.TableView.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
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
            this.DeleteButton.Text = "Удалить запись";
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
            this.InsertButton.Text = "Новая запись";
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
            this.Padding = new System.Windows.Forms.Padding(10);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "ИС. Лабораторная работа №7. Команда - HydraSquad.";
            this.Click += new System.EventHandler(this.EnviromentClick);
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
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button RestoreButton;
        private System.Windows.Forms.Button SaveButton;
    }
}
