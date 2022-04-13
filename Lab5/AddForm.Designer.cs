namespace Lab5
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(176, 40);
            this.PriceBox.Margin = new System.Windows.Forms.Padding(0, 0, 20, 10);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(126, 26);
            this.PriceBox.TabIndex = 0;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(20, 40);
            this.NameBox.Margin = new System.Windows.Forms.Padding(20, 0, 30, 10);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(126, 26);
            this.NameBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(20, 17);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(20, 20, 30, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(126, 19);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Наименование";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NameLabel.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // PriceLabel
            // 
            this.PriceLabel.Location = new System.Drawing.Point(176, 17);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(0, 20, 20, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(126, 19);
            this.PriceLabel.TabIndex = 5;
            this.PriceLabel.Text = "Цена";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PriceLabel.Click += new System.EventHandler(this.EnviromentClick);
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
            this.SubmitButton.Location = new System.Drawing.Point(20, 76);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 20);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(126, 33);
            this.SubmitButton.TabIndex = 19;
            this.SubmitButton.Text = "Добавить";
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
            this.ExitButton.Location = new System.Drawing.Point(176, 76);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 20);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(126, 33);
            this.ExitButton.TabIndex = 20;
            this.ExitButton.Text = "Отмена";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.NameLabel);
            this.MainPanel.Controls.Add(this.ExitButton);
            this.MainPanel.Controls.Add(this.NameBox);
            this.MainPanel.Controls.Add(this.PriceBox);
            this.MainPanel.Controls.Add(this.PriceLabel);
            this.MainPanel.Controls.Add(this.SubmitButton);
            this.MainPanel.Location = new System.Drawing.Point(9, 9);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(324, 159);
            this.MainPanel.TabIndex = 21;
            this.MainPanel.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(342, 177);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddForm";
            this.Text = "Добавить запись";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel MainPanel;
    }
}