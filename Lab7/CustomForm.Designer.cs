namespace Lab7
{
    partial class CustomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomForm));
            this.QueryBox = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // QueryBox
            // 
            this.QueryBox.AcceptsReturn = true;
            this.QueryBox.AcceptsTab = true;
            this.QueryBox.AllowDrop = true;
            this.QueryBox.Location = new System.Drawing.Point(0, 32);
            this.QueryBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.QueryBox.Multiline = true;
            this.QueryBox.Name = "QueryBox";
            this.QueryBox.Size = new System.Drawing.Size(473, 149);
            this.QueryBox.TabIndex = 0;
            // 
            // Label
            // 
            this.Label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label.Location = new System.Drawing.Point(0, 0);
            this.Label.Margin = new System.Windows.Forms.Padding(0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(473, 32);
            this.Label.TabIndex = 1;
            this.Label.Text = "SQL запрос:";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label.Click += new System.EventHandler(this.EnviromentClick);
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
            this.SubmitButton.Location = new System.Drawing.Point(30, 190);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(30, 0, 10, 20);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(172, 57);
            this.SubmitButton.TabIndex = 21;
            this.SubmitButton.Text = "Выполнить";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButtonClick);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.ImageKey = "(нет)";
            this.button1.Location = new System.Drawing.Point(271, 190);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 0, 30, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 57);
            this.button1.TabIndex = 22;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.Label);
            this.MainPanel.Controls.Add(this.button1);
            this.MainPanel.Controls.Add(this.QueryBox);
            this.MainPanel.Controls.Add(this.SubmitButton);
            this.MainPanel.Location = new System.Drawing.Point(9, 9);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(473, 247);
            this.MainPanel.TabIndex = 23;
            this.MainPanel.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // CustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(491, 265);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomForm";
            this.Text = "Запрос к базе данных";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox QueryBox;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel MainPanel;
    }
}