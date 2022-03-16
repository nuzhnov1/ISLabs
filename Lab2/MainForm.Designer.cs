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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ShowButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.TableBox = new System.Windows.Forms.RichTextBox();
            this.MainPanel.SuspendLayout();
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
            this.MainPanel.Controls.Add(this.DeleteButton);
            this.MainPanel.Controls.Add(this.InsertButton);
            this.MainPanel.Controls.Add(this.TableBox);
            this.MainPanel.Controls.Add(this.ShowButton);
            this.MainPanel.Location = new System.Drawing.Point(14, 14);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(5);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1001, 547);
            this.MainPanel.TabIndex = 18;
            this.MainPanel.Click += new System.EventHandler(this.EnviromentClick);
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
            // 
            // TableBox
            // 
            this.TableBox.BackColor = System.Drawing.Color.Silver;
            this.TableBox.Enabled = false;
            this.TableBox.Location = new System.Drawing.Point(0, 0);
            this.TableBox.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.TableBox.Name = "TableBox";
            this.TableBox.Size = new System.Drawing.Size(828, 547);
            this.TableBox.TabIndex = 17;
            this.TableBox.Text = "";
            this.TableBox.Click += new System.EventHandler(this.EnviromentClick);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.RichTextBox TableBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button InsertButton;
    }
}
