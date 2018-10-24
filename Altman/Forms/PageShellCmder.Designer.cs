namespace Altman.Forms
{
    partial class PageShellCmder
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this._consoleBoxCmder = new Altman.Controls.ConsoleBox();
            this.SuspendLayout();
            // 
            // _consoleBoxCmder
            // 
            this._consoleBoxCmder.BackColor = System.Drawing.SystemColors.Window;
            this._consoleBoxCmder.Dock = System.Windows.Forms.DockStyle.Fill;
            this._consoleBoxCmder.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._consoleBoxCmder.ForeColor = System.Drawing.SystemColors.WindowText;
            this._consoleBoxCmder.IsWin = true;
            this._consoleBoxCmder.Location = new System.Drawing.Point(0, 0);
            this._consoleBoxCmder.Name = "_consoleBoxCmder";
            this._consoleBoxCmder.Prompt = "> ";
            this._consoleBoxCmder.ShellTextBackColor = System.Drawing.SystemColors.Window;
            this._consoleBoxCmder.ShellTextFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._consoleBoxCmder.ShellTextForeColor = System.Drawing.SystemColors.WindowText;
            this._consoleBoxCmder.Size = new System.Drawing.Size(942, 493);
            this._consoleBoxCmder.TabIndex = 0;
            this._consoleBoxCmder.Text = "";
            // 
            // PageShellCmder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._consoleBoxCmder);
            this.Name = "PageShellCmder";
            this.Size = new System.Drawing.Size(942, 493);
            this.ResumeLayout(false);

        }

        #endregion

        private Altman.Controls.ConsoleBox _consoleBoxCmder;
    }
}
