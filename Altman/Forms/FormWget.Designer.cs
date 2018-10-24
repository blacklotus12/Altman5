namespace Altman.Forms
{
    partial class FormWget
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
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.textBox_save = new System.Windows.Forms.TextBox();
            this.button_wget = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_url
            // 
            this.textBox_url.Location = new System.Drawing.Point(12, 12);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(369, 25);
            this.textBox_url.TabIndex = 0;
            this.textBox_url.Text = "http://";
            this.textBox_url.TextChanged += new System.EventHandler(this.textBox_url_TextChanged);
            // 
            // textBox_save
            // 
            this.textBox_save.Location = new System.Drawing.Point(12, 45);
            this.textBox_save.Name = "textBox_save";
            this.textBox_save.Size = new System.Drawing.Size(369, 25);
            this.textBox_save.TabIndex = 1;
            // 
            // button_wget
            // 
            this.button_wget.Location = new System.Drawing.Point(39, 80);
            this.button_wget.Name = "button_wget";
            this.button_wget.Size = new System.Drawing.Size(75, 30);
            this.button_wget.TabIndex = 2;
            this.button_wget.Text = "OK";
            this.button_wget.UseVisualStyleBackColor = true;
            this.button_wget.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(273, 80);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 30);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // FormWget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(393, 113);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_wget);
            this.Controls.Add(this.textBox_save);
            this.Controls.Add(this.textBox_url);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWget";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormWget";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_url;
        private System.Windows.Forms.TextBox textBox_save;
        private System.Windows.Forms.Button button_wget;
        private System.Windows.Forms.Button button_cancel;
    }
}