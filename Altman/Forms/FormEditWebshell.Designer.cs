namespace Altman.Forms
{
    partial class FormEditWebshell
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
            this._textBoxName = new System.Windows.Forms.TextBox();
            this._textBoxShellPath = new System.Windows.Forms.TextBox();
            this._comboBoxLevel = new System.Windows.Forms.ComboBox();
            this._dropDownScritpType = new System.Windows.Forms.ComboBox();
            this._textBoxShellPass = new System.Windows.Forms.TextBox();
            this._textBoxRemark = new System.Windows.Forms.TextBox();
            this._buttonAdvanced = new System.Windows.Forms.Button();
            this._buttonAdd = new System.Windows.Forms.Button();
            this._dropDownServerCoding = new System.Windows.Forms.ComboBox();
            this._dropDownWebCoding = new System.Windows.Forms.ComboBox();
            this._buttonDefault = new System.Windows.Forms.Button();
            this._panelAdvanced = new System.Windows.Forms.Panel();
            this._richTextBoxSetting = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._panelAdvanced.SuspendLayout();
            this.SuspendLayout();
            // 
            // _textBoxName
            // 
            this._textBoxName.Location = new System.Drawing.Point(1, 2);
            this._textBoxName.Name = "_textBoxName";
            this._textBoxName.Size = new System.Drawing.Size(388, 25);
            this._textBoxName.TabIndex = 10;
            // 
            // _textBoxShellPath
            // 
            this._textBoxShellPath.Location = new System.Drawing.Point(1, 33);
            this._textBoxShellPath.Name = "_textBoxShellPath";
            this._textBoxShellPath.Size = new System.Drawing.Size(515, 25);
            this._textBoxShellPath.TabIndex = 1;
            // 
            // _comboBoxLevel
            // 
            this._comboBoxLevel.FormattingEnabled = true;
            this._comboBoxLevel.Location = new System.Drawing.Point(395, 2);
            this._comboBoxLevel.Name = "_comboBoxLevel";
            this._comboBoxLevel.Size = new System.Drawing.Size(121, 23);
            this._comboBoxLevel.TabIndex = 2;
            // 
            // _dropDownScritpType
            // 
            this._dropDownScritpType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._dropDownScritpType.FormattingEnabled = true;
            this._dropDownScritpType.Location = new System.Drawing.Point(522, 2);
            this._dropDownScritpType.Name = "_dropDownScritpType";
            this._dropDownScritpType.Size = new System.Drawing.Size(121, 23);
            this._dropDownScritpType.TabIndex = 3;
            // 
            // _textBoxShellPass
            // 
            this._textBoxShellPass.Location = new System.Drawing.Point(522, 33);
            this._textBoxShellPass.Name = "_textBoxShellPass";
            this._textBoxShellPass.Size = new System.Drawing.Size(121, 25);
            this._textBoxShellPass.TabIndex = 4;
            // 
            // _textBoxRemark
            // 
            this._textBoxRemark.Location = new System.Drawing.Point(1, 64);
            this._textBoxRemark.Name = "_textBoxRemark";
            this._textBoxRemark.Size = new System.Drawing.Size(642, 25);
            this._textBoxRemark.TabIndex = 5;
            // 
            // _buttonAdvanced
            // 
            this._buttonAdvanced.Location = new System.Drawing.Point(9, 96);
            this._buttonAdvanced.Name = "_buttonAdvanced";
            this._buttonAdvanced.Size = new System.Drawing.Size(80, 30);
            this._buttonAdvanced.TabIndex = 0;
            this._buttonAdvanced.Text = "Advanced";
            this._buttonAdvanced.UseVisualStyleBackColor = true;
            this._buttonAdvanced.Click += new System.EventHandler(this._buttonAdvanced_Click);
            // 
            // _buttonAdd
            // 
            this._buttonAdd.Location = new System.Drawing.Point(560, 96);
            this._buttonAdd.Name = "_buttonAdd";
            this._buttonAdd.Size = new System.Drawing.Size(80, 30);
            this._buttonAdd.TabIndex = 7;
            this._buttonAdd.Text = "Save";
            this._buttonAdd.UseVisualStyleBackColor = true;
            this._buttonAdd.Click += new System.EventHandler(this._buttonAdd_Click);
            // 
            // _dropDownServerCoding
            // 
            this._dropDownServerCoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._dropDownServerCoding.FormattingEnabled = true;
            this._dropDownServerCoding.Location = new System.Drawing.Point(117, 7);
            this._dropDownServerCoding.Name = "_dropDownServerCoding";
            this._dropDownServerCoding.Size = new System.Drawing.Size(93, 23);
            this._dropDownServerCoding.TabIndex = 9;
            // 
            // _dropDownWebCoding
            // 
            this._dropDownWebCoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._dropDownWebCoding.FormattingEnabled = true;
            this._dropDownWebCoding.Location = new System.Drawing.Point(302, 7);
            this._dropDownWebCoding.Name = "_dropDownWebCoding";
            this._dropDownWebCoding.Size = new System.Drawing.Size(93, 23);
            this._dropDownWebCoding.TabIndex = 10;
            // 
            // _buttonDefault
            // 
            this._buttonDefault.Location = new System.Drawing.Point(485, 7);
            this._buttonDefault.Name = "_buttonDefault";
            this._buttonDefault.Size = new System.Drawing.Size(75, 23);
            this._buttonDefault.TabIndex = 11;
            this._buttonDefault.Text = "default";
            this._buttonDefault.UseVisualStyleBackColor = true;
            this._buttonDefault.Click += new System.EventHandler(this._buttonDefault_Click);
            // 
            // _panelAdvanced
            // 
            this._panelAdvanced.Controls.Add(this._richTextBoxSetting);
            this._panelAdvanced.Controls.Add(this.label2);
            this._panelAdvanced.Controls.Add(this.label1);
            this._panelAdvanced.Controls.Add(this._buttonDefault);
            this._panelAdvanced.Controls.Add(this._dropDownServerCoding);
            this._panelAdvanced.Controls.Add(this._dropDownWebCoding);
            this._panelAdvanced.Location = new System.Drawing.Point(1, 150);
            this._panelAdvanced.Name = "_panelAdvanced";
            this._panelAdvanced.Size = new System.Drawing.Size(649, 234);
            this._panelAdvanced.TabIndex = 12;
            this._panelAdvanced.Visible = false;
            // 
            // _richTextBoxSetting
            // 
            this._richTextBoxSetting.Location = new System.Drawing.Point(6, 37);
            this._richTextBoxSetting.Name = "_richTextBoxSetting";
            this._richTextBoxSetting.Size = new System.Drawing.Size(638, 192);
            this._richTextBoxSetting.TabIndex = 13;
            this._richTextBoxSetting.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "WebCoding";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "ServerCoding";
            // 
            // FormEditWebshell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 148);
            this.Controls.Add(this._panelAdvanced);
            this.Controls.Add(this._buttonAdd);
            this.Controls.Add(this._buttonAdvanced);
            this.Controls.Add(this._textBoxRemark);
            this.Controls.Add(this._textBoxShellPass);
            this.Controls.Add(this._dropDownScritpType);
            this.Controls.Add(this._comboBoxLevel);
            this.Controls.Add(this._textBoxShellPath);
            this.Controls.Add(this._textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditWebshell";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditWebshell";
            this._panelAdvanced.ResumeLayout(false);
            this._panelAdvanced.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _textBoxName;        
        private System.Windows.Forms.ComboBox _comboBoxLevel;
        private System.Windows.Forms.ComboBox _dropDownScritpType;
        private System.Windows.Forms.TextBox _textBoxShellPath;
        private System.Windows.Forms.TextBox _textBoxShellPass;
        private System.Windows.Forms.TextBox _textBoxRemark;
        private System.Windows.Forms.Button _buttonAdvanced;
        private System.Windows.Forms.Button _buttonAdd;

        private System.Windows.Forms.Panel _panelAdvanced;
        private System.Windows.Forms.ComboBox _dropDownServerCoding;
        private System.Windows.Forms.ComboBox _dropDownWebCoding;
        private System.Windows.Forms.Button _buttonDefault;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox _richTextBoxSetting;
    }
}