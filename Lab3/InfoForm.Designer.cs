
namespace Lab3
{
    partial class InfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.OkButton1 = new System.Windows.Forms.Button();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.OkButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OkButton1
            // 
            this.OkButton1.AutoSize = true;
            this.OkButton1.BackColor = System.Drawing.SystemColors.Desktop;
            this.OkButton1.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.OkButton1.FlatAppearance.BorderSize = 2;
            this.OkButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OkButton1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.OkButton1.ImageKey = "(нет)";
            this.OkButton1.Location = new System.Drawing.Point(66, 373);
            this.OkButton1.Margin = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.OkButton1.Name = "OkButton1";
            this.OkButton1.Size = new System.Drawing.Size(163, 50);
            this.OkButton1.TabIndex = 9;
            this.OkButton1.Text = "Поставить";
            this.OkButton1.UseVisualStyleBackColor = false;
            this.OkButton1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ImagePanel
            // 
            this.ImagePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImagePanel.BackgroundImage")));
            this.ImagePanel.Location = new System.Drawing.Point(89, 56);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(300, 301);
            this.ImagePanel.TabIndex = 10;
            this.ImagePanel.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.BackColor = System.Drawing.Color.Black;
            this.InfoLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoLabel.ForeColor = System.Drawing.Color.Chartreuse;
            this.InfoLabel.Location = new System.Drawing.Point(170, 14);
            this.InfoLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(153, 21);
            this.InfoLabel.TabIndex = 11;
            this.InfoLabel.Text = "Поставьте защиту";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InfoLabel.Click += new System.EventHandler(this.EnviromentClick);
            // 
            // OkButton2
            // 
            this.OkButton2.AutoSize = true;
            this.OkButton2.BackColor = System.Drawing.SystemColors.Desktop;
            this.OkButton2.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.OkButton2.FlatAppearance.BorderSize = 2;
            this.OkButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkButton2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OkButton2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.OkButton2.ImageKey = "(нет)";
            this.OkButton2.Location = new System.Drawing.Point(252, 373);
            this.OkButton2.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.OkButton2.Name = "OkButton2";
            this.OkButton2.Size = new System.Drawing.Size(163, 50);
            this.OkButton2.TabIndex = 12;
            this.OkButton2.Text = "Поставить";
            this.OkButton2.UseVisualStyleBackColor = false;
            this.OkButton2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 437);
            this.ControlBox = false;
            this.Controls.Add(this.OkButton2);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.ImagePanel);
            this.Controls.Add(this.OkButton1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InfoForm";
            this.Text = "Важная информация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton1;
        private System.Windows.Forms.Panel ImagePanel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button OkButton2;
    }
}