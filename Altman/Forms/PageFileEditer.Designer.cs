namespace Altman
{
    partial class PageFileEditer
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
            this._textAreaBody = new System.Windows.Forms.RichTextBox();
            this._textBoxUrl = new System.Windows.Forms.TextBox();
            this._buttonReadFile = new System.Windows.Forms.Button();
            this._buttonSaveFile = new System.Windows.Forms.Button();
            this._panelSearch = new System.Windows.Forms.Panel();
            this._checkCaseSensitive = new System.Windows.Forms.CheckBox();
            this._textSearch = new System.Windows.Forms.TextBox();
            this._panelShowUrl = new System.Windows.Forms.Panel();
            this._panelSearch.SuspendLayout();
            this._panelShowUrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // _textAreaBody
            // 
            this._textAreaBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textAreaBody.Location = new System.Drawing.Point(3, 42);
            this._textAreaBody.Name = "_textAreaBody";
            this._textAreaBody.Size = new System.Drawing.Size(853, 405);
            this._textAreaBody.TabIndex = 0;
            this._textAreaBody.Text = "";
            this._textAreaBody.KeyDown += new System.Windows.Forms.KeyEventHandler(this._textAreaBody_KeyDown);
            // 
            // _textBoxUrl
            // 
            this._textBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxUrl.Location = new System.Drawing.Point(81, 6);
            this._textBoxUrl.Name = "_textBoxUrl";
            this._textBoxUrl.Size = new System.Drawing.Size(689, 25);
            this._textBoxUrl.TabIndex = 1;
            // 
            // _buttonReadFile
            // 
            this._buttonReadFile.Location = new System.Drawing.Point(3, 6);
            this._buttonReadFile.Name = "_buttonReadFile";
            this._buttonReadFile.Size = new System.Drawing.Size(75, 25);
            this._buttonReadFile.TabIndex = 2;
            this._buttonReadFile.Text = "Get";
            this._buttonReadFile.UseVisualStyleBackColor = true;
            // 
            // _buttonSaveFile
            // 
            this._buttonSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonSaveFile.Location = new System.Drawing.Point(773, 6);
            this._buttonSaveFile.Name = "_buttonSaveFile";
            this._buttonSaveFile.Size = new System.Drawing.Size(75, 25);
            this._buttonSaveFile.TabIndex = 3;
            this._buttonSaveFile.Text = "Save";
            this._buttonSaveFile.UseVisualStyleBackColor = true;
            this._buttonSaveFile.Click += new System.EventHandler(this._buttonSaveFile_Click);
            // 
            // _panelSearch
            // 
            this._panelSearch.Controls.Add(this._checkCaseSensitive);
            this._panelSearch.Controls.Add(this._textSearch);
            this._panelSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelSearch.Location = new System.Drawing.Point(0, 451);
            this._panelSearch.Name = "_panelSearch";
            this._panelSearch.Size = new System.Drawing.Size(859, 32);
            this._panelSearch.TabIndex = 4;
            // 
            // _checkCaseSensitive
            // 
            this._checkCaseSensitive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._checkCaseSensitive.AutoSize = true;
            this._checkCaseSensitive.Location = new System.Drawing.Point(724, 7);
            this._checkCaseSensitive.Name = "_checkCaseSensitive";
            this._checkCaseSensitive.Size = new System.Drawing.Size(133, 19);
            this._checkCaseSensitive.TabIndex = 1;
            this._checkCaseSensitive.Text = "CaseSensitive";
            this._checkCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // _textSearch
            // 
            this._textSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textSearch.Location = new System.Drawing.Point(2, 3);
            this._textSearch.Name = "_textSearch";
            this._textSearch.Size = new System.Drawing.Size(712, 25);
            this._textSearch.TabIndex = 0;
            this._textSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this._textSearch_KeyDown);
            // 
            // _panelShowUrl
            // 
            this._panelShowUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._panelShowUrl.Controls.Add(this._buttonReadFile);
            this._panelShowUrl.Controls.Add(this._textBoxUrl);
            this._panelShowUrl.Controls.Add(this._buttonSaveFile);
            this._panelShowUrl.Location = new System.Drawing.Point(2, 3);
            this._panelShowUrl.Name = "_panelShowUrl";
            this._panelShowUrl.Size = new System.Drawing.Size(853, 36);
            this._panelShowUrl.TabIndex = 5;
            // 
            // PageFileEditer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._panelShowUrl);
            this.Controls.Add(this._panelSearch);
            this.Controls.Add(this._textAreaBody);
            this.Name = "PageFileEditer";
            this.Size = new System.Drawing.Size(859, 483);
            this._panelSearch.ResumeLayout(false);
            this._panelSearch.PerformLayout();
            this._panelShowUrl.ResumeLayout(false);
            this._panelShowUrl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox _textAreaBody;
        private System.Windows.Forms.TextBox _textBoxUrl;
        private System.Windows.Forms.Button _buttonReadFile;
        private System.Windows.Forms.Button _buttonSaveFile;
        private System.Windows.Forms.Panel _panelSearch;
        private System.Windows.Forms.TextBox _textSearch;
        private System.Windows.Forms.Panel _panelShowUrl;
        private System.Windows.Forms.CheckBox _checkCaseSensitive;
    }
}
