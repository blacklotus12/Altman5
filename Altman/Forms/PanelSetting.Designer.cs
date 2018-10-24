namespace Altman
{
    partial class PanelSetting
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this._panelBasicSetting = new System.Windows.Forms.TabPage();
            this._dropDownLang = new System.Windows.Forms.ComboBox();
            this._checkBoxIsShowDisclaimer = new System.Windows.Forms.CheckBox();
            this._panelUserAgentSetting = new System.Windows.Forms.TabPage();
            this._useragentlabel = new System.Windows.Forms.Label();
            this._comboBoxUserAgentList = new System.Windows.Forms.ComboBox();
            this._checkBoxIsRandom = new System.Windows.Forms.CheckBox();
            this._panelHttpHeaderSetting = new System.Windows.Forms.TabPage();
            this._gridViewHeader = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._contextMenuRightMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._panelPolicySetting = new System.Windows.Forms.TabPage();
            this._checkBoxIsParamRandom = new System.Windows.Forms.CheckBox();
            this._panelProxySetting = new System.Windows.Forms.TabPage();
            this._radioButtonCustomProxy = new System.Windows.Forms.RadioButton();
            this._radioButtonIeProxy = new System.Windows.Forms.RadioButton();
            this._radioButtonNoProxy = new System.Windows.Forms.RadioButton();
            this._groupBoxSetting = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._textBoxProxyDomain = new System.Windows.Forms.TextBox();
            this._textBoxProxyPasswd = new System.Windows.Forms.TextBox();
            this._textBoxProxyUser = new System.Windows.Forms.TextBox();
            this._textBoxProxyPort = new System.Windows.Forms.TextBox();
            this._textBoxProxyAddr = new System.Windows.Forms.TextBox();
            this._buttonSaveSetting = new System.Windows.Forms.Button();
            this._buttonCancel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this._panelBasicSetting.SuspendLayout();
            this._panelUserAgentSetting.SuspendLayout();
            this._panelHttpHeaderSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridViewHeader)).BeginInit();
            this._contextMenuRightMenu.SuspendLayout();
            this._panelPolicySetting.SuspendLayout();
            this._panelProxySetting.SuspendLayout();
            this._groupBoxSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this._panelBasicSetting);
            this.tabControl1.Controls.Add(this._panelUserAgentSetting);
            this.tabControl1.Controls.Add(this._panelHttpHeaderSetting);
            this.tabControl1.Controls.Add(this._panelPolicySetting);
            this.tabControl1.Controls.Add(this._panelProxySetting);
            this.tabControl1.Location = new System.Drawing.Point(20, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(410, 327);
            this.tabControl1.TabIndex = 0;
            // 
            // _panelBasicSetting
            // 
            this._panelBasicSetting.Controls.Add(this._dropDownLang);
            this._panelBasicSetting.Controls.Add(this._checkBoxIsShowDisclaimer);
            this._panelBasicSetting.Location = new System.Drawing.Point(4, 22);
            this._panelBasicSetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._panelBasicSetting.Name = "_panelBasicSetting";
            this._panelBasicSetting.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._panelBasicSetting.Size = new System.Drawing.Size(402, 301);
            this._panelBasicSetting.TabIndex = 0;
            this._panelBasicSetting.Text = "Basic";
            this._panelBasicSetting.UseVisualStyleBackColor = true;
            // 
            // _dropDownLang
            // 
            this._dropDownLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._dropDownLang.FormattingEnabled = true;
            this._dropDownLang.Location = new System.Drawing.Point(81, 28);
            this._dropDownLang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._dropDownLang.Name = "_dropDownLang";
            this._dropDownLang.Size = new System.Drawing.Size(92, 20);
            this._dropDownLang.TabIndex = 4;
            // 
            // _checkBoxIsShowDisclaimer
            // 
            this._checkBoxIsShowDisclaimer.AutoSize = true;
            this._checkBoxIsShowDisclaimer.Location = new System.Drawing.Point(81, 82);
            this._checkBoxIsShowDisclaimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._checkBoxIsShowDisclaimer.Name = "_checkBoxIsShowDisclaimer";
            this._checkBoxIsShowDisclaimer.Size = new System.Drawing.Size(78, 16);
            this._checkBoxIsShowDisclaimer.TabIndex = 0;
            this._checkBoxIsShowDisclaimer.Text = "checkBox1";
            this._checkBoxIsShowDisclaimer.UseVisualStyleBackColor = true;
            // 
            // _panelUserAgentSetting
            // 
            this._panelUserAgentSetting.Controls.Add(this._useragentlabel);
            this._panelUserAgentSetting.Controls.Add(this._comboBoxUserAgentList);
            this._panelUserAgentSetting.Controls.Add(this._checkBoxIsRandom);
            this._panelUserAgentSetting.Location = new System.Drawing.Point(4, 22);
            this._panelUserAgentSetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._panelUserAgentSetting.Name = "_panelUserAgentSetting";
            this._panelUserAgentSetting.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._panelUserAgentSetting.Size = new System.Drawing.Size(402, 301);
            this._panelUserAgentSetting.TabIndex = 1;
            this._panelUserAgentSetting.Text = "UserAgent";
            this._panelUserAgentSetting.UseVisualStyleBackColor = true;
            // 
            // _useragentlabel
            // 
            this._useragentlabel.AutoSize = true;
            this._useragentlabel.Location = new System.Drawing.Point(80, 68);
            this._useragentlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._useragentlabel.Name = "_useragentlabel";
            this._useragentlabel.Size = new System.Drawing.Size(41, 12);
            this._useragentlabel.TabIndex = 2;
            this._useragentlabel.Text = "label1";
            // 
            // _comboBoxUserAgentList
            // 
            this._comboBoxUserAgentList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxUserAgentList.FormattingEnabled = true;
            this._comboBoxUserAgentList.Location = new System.Drawing.Point(82, 100);
            this._comboBoxUserAgentList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._comboBoxUserAgentList.Name = "_comboBoxUserAgentList";
            this._comboBoxUserAgentList.Size = new System.Drawing.Size(92, 20);
            this._comboBoxUserAgentList.TabIndex = 1;
            // 
            // _checkBoxIsRandom
            // 
            this._checkBoxIsRandom.AutoSize = true;
            this._checkBoxIsRandom.Location = new System.Drawing.Point(82, 35);
            this._checkBoxIsRandom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._checkBoxIsRandom.Name = "_checkBoxIsRandom";
            this._checkBoxIsRandom.Size = new System.Drawing.Size(78, 16);
            this._checkBoxIsRandom.TabIndex = 0;
            this._checkBoxIsRandom.Text = "checkBox1";
            this._checkBoxIsRandom.UseVisualStyleBackColor = true;
            // 
            // _panelHttpHeaderSetting
            // 
            this._panelHttpHeaderSetting.Controls.Add(this._gridViewHeader);
            this._panelHttpHeaderSetting.Location = new System.Drawing.Point(4, 22);
            this._panelHttpHeaderSetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._panelHttpHeaderSetting.Name = "_panelHttpHeaderSetting";
            this._panelHttpHeaderSetting.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._panelHttpHeaderSetting.Size = new System.Drawing.Size(402, 301);
            this._panelHttpHeaderSetting.TabIndex = 2;
            this._panelHttpHeaderSetting.Text = "HttpHead";
            this._panelHttpHeaderSetting.UseVisualStyleBackColor = true;
            // 
            // _gridViewHeader
            // 
            this._gridViewHeader.AllowUserToAddRows = false;
            this._gridViewHeader.AllowUserToDeleteRows = false;
            this._gridViewHeader.BackgroundColor = System.Drawing.Color.White;
            this._gridViewHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._gridViewHeader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Value});
            this._gridViewHeader.ContextMenuStrip = this._contextMenuRightMenu;
            this._gridViewHeader.Location = new System.Drawing.Point(52, 22);
            this._gridViewHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._gridViewHeader.MultiSelect = false;
            this._gridViewHeader.Name = "_gridViewHeader";
            this._gridViewHeader.RowTemplate.Height = 27;
            this._gridViewHeader.Size = new System.Drawing.Size(290, 175);
            this._gridViewHeader.TabIndex = 0;
            this._gridViewHeader.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._gridViewHeader_CellMouseClick);
            // 
            // Key
            // 
            this.Key.HeaderText = "Key";
            this.Key.Name = "Key";
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // _contextMenuRightMenu
            // 
            this._contextMenuRightMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._contextMenuRightMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this._contextMenuRightMenu.Name = "_contextMenuRightMenu";
            this._contextMenuRightMenu.Size = new System.Drawing.Size(114, 48);
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.AddToolStripMenuItem.Text = "Add";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // _panelPolicySetting
            // 
            this._panelPolicySetting.Controls.Add(this._checkBoxIsParamRandom);
            this._panelPolicySetting.Location = new System.Drawing.Point(4, 22);
            this._panelPolicySetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._panelPolicySetting.Name = "_panelPolicySetting";
            this._panelPolicySetting.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._panelPolicySetting.Size = new System.Drawing.Size(402, 301);
            this._panelPolicySetting.TabIndex = 3;
            this._panelPolicySetting.Text = "Policy";
            this._panelPolicySetting.UseVisualStyleBackColor = true;
            // 
            // _checkBoxIsParamRandom
            // 
            this._checkBoxIsParamRandom.AutoSize = true;
            this._checkBoxIsParamRandom.Location = new System.Drawing.Point(59, 27);
            this._checkBoxIsParamRandom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._checkBoxIsParamRandom.Name = "_checkBoxIsParamRandom";
            this._checkBoxIsParamRandom.Size = new System.Drawing.Size(78, 16);
            this._checkBoxIsParamRandom.TabIndex = 0;
            this._checkBoxIsParamRandom.Text = "checkBox1";
            this._checkBoxIsParamRandom.UseVisualStyleBackColor = true;
            // 
            // _panelProxySetting
            // 
            this._panelProxySetting.Controls.Add(this._radioButtonCustomProxy);
            this._panelProxySetting.Controls.Add(this._radioButtonIeProxy);
            this._panelProxySetting.Controls.Add(this._radioButtonNoProxy);
            this._panelProxySetting.Controls.Add(this._groupBoxSetting);
            this._panelProxySetting.Location = new System.Drawing.Point(4, 22);
            this._panelProxySetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._panelProxySetting.Name = "_panelProxySetting";
            this._panelProxySetting.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._panelProxySetting.Size = new System.Drawing.Size(402, 301);
            this._panelProxySetting.TabIndex = 4;
            this._panelProxySetting.Text = "Proxy";
            this._panelProxySetting.UseVisualStyleBackColor = true;
            // 
            // _radioButtonCustomProxy
            // 
            this._radioButtonCustomProxy.AutoSize = true;
            this._radioButtonCustomProxy.Location = new System.Drawing.Point(94, 78);
            this._radioButtonCustomProxy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._radioButtonCustomProxy.Name = "_radioButtonCustomProxy";
            this._radioButtonCustomProxy.Size = new System.Drawing.Size(95, 16);
            this._radioButtonCustomProxy.TabIndex = 6;
            this._radioButtonCustomProxy.TabStop = true;
            this._radioButtonCustomProxy.Text = "radioButton3";
            this._radioButtonCustomProxy.UseVisualStyleBackColor = true;
            // 
            // _radioButtonIeProxy
            // 
            this._radioButtonIeProxy.AutoSize = true;
            this._radioButtonIeProxy.Location = new System.Drawing.Point(94, 46);
            this._radioButtonIeProxy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._radioButtonIeProxy.Name = "_radioButtonIeProxy";
            this._radioButtonIeProxy.Size = new System.Drawing.Size(95, 16);
            this._radioButtonIeProxy.TabIndex = 5;
            this._radioButtonIeProxy.TabStop = true;
            this._radioButtonIeProxy.Text = "radioButton2";
            this._radioButtonIeProxy.UseVisualStyleBackColor = true;
            // 
            // _radioButtonNoProxy
            // 
            this._radioButtonNoProxy.AutoSize = true;
            this._radioButtonNoProxy.Location = new System.Drawing.Point(94, 14);
            this._radioButtonNoProxy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._radioButtonNoProxy.Name = "_radioButtonNoProxy";
            this._radioButtonNoProxy.Size = new System.Drawing.Size(95, 16);
            this._radioButtonNoProxy.TabIndex = 4;
            this._radioButtonNoProxy.TabStop = true;
            this._radioButtonNoProxy.Text = "radioButton1";
            this._radioButtonNoProxy.UseVisualStyleBackColor = true;
            // 
            // _groupBoxSetting
            // 
            this._groupBoxSetting.Controls.Add(this.label6);
            this._groupBoxSetting.Controls.Add(this.label5);
            this._groupBoxSetting.Controls.Add(this.label4);
            this._groupBoxSetting.Controls.Add(this.label3);
            this._groupBoxSetting.Controls.Add(this.label2);
            this._groupBoxSetting.Controls.Add(this._textBoxProxyDomain);
            this._groupBoxSetting.Controls.Add(this._textBoxProxyPasswd);
            this._groupBoxSetting.Controls.Add(this._textBoxProxyUser);
            this._groupBoxSetting.Controls.Add(this._textBoxProxyPort);
            this._groupBoxSetting.Controls.Add(this._textBoxProxyAddr);
            this._groupBoxSetting.Location = new System.Drawing.Point(48, 98);
            this._groupBoxSetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._groupBoxSetting.Name = "_groupBoxSetting";
            this._groupBoxSetting.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._groupBoxSetting.Size = new System.Drawing.Size(262, 187);
            this._groupBoxSetting.TabIndex = 3;
            this._groupBoxSetting.TabStop = false;
            this._groupBoxSetting.Text = "groupBox1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 157);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "Domain: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Passwd: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "User: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Port: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Server: ";
            // 
            // _textBoxProxyDomain
            // 
            this._textBoxProxyDomain.Location = new System.Drawing.Point(76, 154);
            this._textBoxProxyDomain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._textBoxProxyDomain.Name = "_textBoxProxyDomain";
            this._textBoxProxyDomain.Size = new System.Drawing.Size(76, 21);
            this._textBoxProxyDomain.TabIndex = 4;
            // 
            // _textBoxProxyPasswd
            // 
            this._textBoxProxyPasswd.Location = new System.Drawing.Point(76, 122);
            this._textBoxProxyPasswd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._textBoxProxyPasswd.Name = "_textBoxProxyPasswd";
            this._textBoxProxyPasswd.Size = new System.Drawing.Size(76, 21);
            this._textBoxProxyPasswd.TabIndex = 3;
            // 
            // _textBoxProxyUser
            // 
            this._textBoxProxyUser.Location = new System.Drawing.Point(76, 90);
            this._textBoxProxyUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._textBoxProxyUser.Name = "_textBoxProxyUser";
            this._textBoxProxyUser.Size = new System.Drawing.Size(76, 21);
            this._textBoxProxyUser.TabIndex = 2;
            // 
            // _textBoxProxyPort
            // 
            this._textBoxProxyPort.Location = new System.Drawing.Point(76, 54);
            this._textBoxProxyPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._textBoxProxyPort.Name = "_textBoxProxyPort";
            this._textBoxProxyPort.Size = new System.Drawing.Size(76, 21);
            this._textBoxProxyPort.TabIndex = 1;
            // 
            // _textBoxProxyAddr
            // 
            this._textBoxProxyAddr.Location = new System.Drawing.Point(76, 19);
            this._textBoxProxyAddr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._textBoxProxyAddr.Name = "_textBoxProxyAddr";
            this._textBoxProxyAddr.Size = new System.Drawing.Size(76, 21);
            this._textBoxProxyAddr.TabIndex = 0;
            // 
            // _buttonSaveSetting
            // 
            this._buttonSaveSetting.Location = new System.Drawing.Point(260, 356);
            this._buttonSaveSetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._buttonSaveSetting.Name = "_buttonSaveSetting";
            this._buttonSaveSetting.Size = new System.Drawing.Size(56, 22);
            this._buttonSaveSetting.TabIndex = 1;
            this._buttonSaveSetting.Text = "Save";
            this._buttonSaveSetting.UseVisualStyleBackColor = true;
            this._buttonSaveSetting.Click += new System.EventHandler(this._buttonSaveSetting_Click);
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Location = new System.Drawing.Point(346, 356);
            this._buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(56, 22);
            this._buttonCancel.TabIndex = 2;
            this._buttonCancel.Text = "Exit";
            this._buttonCancel.UseVisualStyleBackColor = true;
            this._buttonCancel.Click += new System.EventHandler(this._buttonCancel_Click);
            // 
            // PanelSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 392);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._buttonSaveSetting);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PanelSetting";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PanelSetting";
            this.tabControl1.ResumeLayout(false);
            this._panelBasicSetting.ResumeLayout(false);
            this._panelBasicSetting.PerformLayout();
            this._panelUserAgentSetting.ResumeLayout(false);
            this._panelUserAgentSetting.PerformLayout();
            this._panelHttpHeaderSetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gridViewHeader)).EndInit();
            this._contextMenuRightMenu.ResumeLayout(false);
            this._panelPolicySetting.ResumeLayout(false);
            this._panelPolicySetting.PerformLayout();
            this._panelProxySetting.ResumeLayout(false);
            this._panelProxySetting.PerformLayout();
            this._groupBoxSetting.ResumeLayout(false);
            this._groupBoxSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage _panelBasicSetting;
        private System.Windows.Forms.TabPage _panelUserAgentSetting;
        private System.Windows.Forms.TabPage _panelHttpHeaderSetting;
        private System.Windows.Forms.TabPage _panelPolicySetting;
        private System.Windows.Forms.TabPage _panelProxySetting;

        //
        private System.Windows.Forms.ComboBox _dropDownLang;
        private System.Windows.Forms.CheckBox _checkBoxIsShowDisclaimer;
        private System.Windows.Forms.Label _useragentlabel;
        private System.Windows.Forms.ComboBox _comboBoxUserAgentList;
        private System.Windows.Forms.CheckBox _checkBoxIsRandom;
        private System.Windows.Forms.DataGridView _gridViewHeader;
        private System.Windows.Forms.ContextMenuStrip _contextMenuRightMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.CheckBox _checkBoxIsParamRandom;
        private System.Windows.Forms.GroupBox _groupBoxSetting;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _textBoxProxyDomain;
        private System.Windows.Forms.TextBox _textBoxProxyPasswd;
        private System.Windows.Forms.TextBox _textBoxProxyUser;
        private System.Windows.Forms.TextBox _textBoxProxyPort;
        private System.Windows.Forms.TextBox _textBoxProxyAddr;
        private System.Windows.Forms.RadioButton _radioButtonCustomProxy;
        private System.Windows.Forms.RadioButton _radioButtonIeProxy;
        private System.Windows.Forms.RadioButton _radioButtonNoProxy;
        private System.Windows.Forms.Button _buttonSaveSetting;
        private System.Windows.Forms.Button _buttonCancel;
    }
}