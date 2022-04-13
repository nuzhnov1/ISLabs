namespace Lab4
{
    partial class DeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteForm));
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // IdLabel
            // 
            this.IdLabel.Location = new System.Drawing.Point(20, 19);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(83, 26);
            this.IdLabel.TabIndex = 2;
            this.IdLabel.Text = "ID записи:";
            this.IdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IdLabel.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(103, 19);
            this.IdBox.Margin = new System.Windows.Forms.Padding(0, 20, 20, 20);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(127, 26);
            this.IdBox.TabIndex = 3;
            // 
            // SubmitButton
            // 
            this.SubmitButton.AutoSize = true;
            this.SubmitButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.SubmitButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.SubmitButton.FlatAppearance.BorderSize = 2;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SubmitButton.ImageKey = "(нет)";
            this.SubmitButton.Location = new System.Drawing.Point(20, 65);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 20);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(95, 33);
            this.SubmitButton.TabIndex = 20;
            this.SubmitButton.Text = "Удалить";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButtonClick);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.ExitButton.FlatAppearance.BorderSize = 2;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ExitButton.ImageKey = "(нет)";
            this.ExitButton.Location = new System.Drawing.Point(135, 65);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 20);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(95, 33);
            this.ExitButton.TabIndex = 21;
            this.ExitButton.Text = "Отмена";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.IdLabel);
            this.MainPanel.Controls.Add(this.ExitButton);
            this.MainPanel.Controls.Add(this.IdBox);
            this.MainPanel.Controls.Add(this.SubmitButton);
            this.MainPanel.Location = new System.Drawing.Point(9, 9);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(251, 145);
            this.MainPanel.TabIndex = 22;
            this.MainPanel.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(271, 166);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeleteForm";
            this.Text = "Удалить запись";
            this.Click += new System.EventHandler(this.EnviromentClick);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel MainPanel;
    }
}