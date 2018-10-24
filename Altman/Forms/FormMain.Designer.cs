namespace Altman
{
    partial class FormMain
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this._showMsgLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._lodingSpinner = new System.Windows.Forms.ToolStripProgressBar();
            this._showVersionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._tabControl = new System.Windows.Forms.TabControlExtra();
            this._tabShellManager = new System.Windows.Forms.TabPage();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuNotify.SuspendLayout();
            this._tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // _showMsgLabel
            // 
            this._showMsgLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this._showMsgLabel.Name = "_showMsgLabel";
            this._showMsgLabel.Size = new System.Drawing.Size(813, 24);
            this._showMsgLabel.Spring = true;
            this._showMsgLabel.Text = "111111111111111111111";
            this._showMsgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _lodingSpinner
            // 
            this._lodingSpinner.Name = "_lodingSpinner";
            this._lodingSpinner.Size = new System.Drawing.Size(100, 23);
            // 
            // _showVersionLabel
            // 
            this._showVersionLabel.Name = "_showVersionLabel";
            this._showVersionLabel.Size = new System.Drawing.Size(153, 24);
            this._showVersionLabel.Text = "2222222222222222";
            this._showVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._showMsgLabel,
            this._lodingSpinner,
            this._showVersionLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 564);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1083, 29);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.exitToolStripMenuItem.Text = "Quit";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1083, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuNotify;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "AltMan";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuNotify
            // 
            this.contextMenuNotify.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.contextMenuNotify.Name = "contextMenuNotify";
            this.contextMenuNotify.Size = new System.Drawing.Size(119, 52);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // _tabControl
            // 
            this._tabControl.Controls.Add(this._tabShellManager);
            this._tabControl.DisplayStyle = System.Windows.Forms.TabStyle.Rectangular;
            // 
            // 
            // 
            this._tabControl.DisplayStyleProvider.BlendStyle = System.Windows.Forms.BlendStyle.Normal;
            this._tabControl.DisplayStyleProvider.BorderColorDisabled = System.Drawing.SystemColors.Control;
            this._tabControl.DisplayStyleProvider.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this._tabControl.DisplayStyleProvider.BorderColorHighlighted = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this._tabControl.DisplayStyleProvider.BorderColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._tabControl.DisplayStyleProvider.BorderColorUnselected = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this._tabControl.DisplayStyleProvider.CloserButtonFillColorFocused = System.Drawing.Color.Empty;
            this._tabControl.DisplayStyleProvider.CloserButtonFillColorFocusedActive = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this._tabControl.DisplayStyleProvider.CloserButtonFillColorHighlighted = System.Drawing.Color.Empty;
            this._tabControl.DisplayStyleProvider.CloserButtonFillColorHighlightedActive = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(176)))), ((int)(((byte)(239)))));
            this._tabControl.DisplayStyleProvider.CloserButtonFillColorSelected = System.Drawing.Color.Empty;
            this._tabControl.DisplayStyleProvider.CloserButtonFillColorSelectedActive = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this._tabControl.DisplayStyleProvider.CloserButtonFillColorUnselected = System.Drawing.Color.Empty;
            this._tabControl.DisplayStyleProvider.CloserButtonOutlineColorFocused = System.Drawing.Color.Empty;
            this._tabControl.DisplayStyleProvider.CloserButtonOutlineColorFocusedActive = System.Drawing.Color.Empty;
            this._tabControl.DisplayStyleProvider.CloserButtonOutlineColorHighlighted = System.Drawing.Color.Empty;
            this._tabControl.DisplayStyleProvider.CloserButtonOutlineColorHighlightedActive = System.Drawing.Color.Empty;
            this._tabControl.DisplayStyleProvider.CloserButtonOutlineColorSelected = System.Drawing.Color.Empty;
            this._tabControl.DisplayStyleProvider.CloserButtonOutlineColorSelectedActive = System.Drawing.Color.Empty;
            this._tabControl.DisplayStyleProvider.CloserButtonOutlineColorUnselected = System.Drawing.Color.Empty;
            this._tabControl.DisplayStyleProvider.CloserColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this._tabControl.DisplayStyleProvider.CloserColorFocusedActive = System.Drawing.Color.White;
            this._tabControl.DisplayStyleProvider.CloserColorHighlighted = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(195)))), ((int)(((byte)(241)))));
            this._tabControl.DisplayStyleProvider.CloserColorHighlightedActive = System.Drawing.Color.White;
            this._tabControl.DisplayStyleProvider.CloserColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(112)))));
            this._tabControl.DisplayStyleProvider.CloserColorSelectedActive = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this._tabControl.DisplayStyleProvider.CloserColorUnselected = System.Drawing.Color.Empty;
            this._tabControl.DisplayStyleProvider.FocusTrack = false;
            this._tabControl.DisplayStyleProvider.HotTrack = true;
            this._tabControl.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._tabControl.DisplayStyleProvider.Opacity = 1F;
            this._tabControl.DisplayStyleProvider.Overlap = 0;
            this._tabControl.DisplayStyleProvider.Padding = new System.Drawing.Point(6, 5);
            this._tabControl.DisplayStyleProvider.PageBackgroundColorDisabled = System.Drawing.SystemColors.Control;
            this._tabControl.DisplayStyleProvider.PageBackgroundColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this._tabControl.DisplayStyleProvider.PageBackgroundColorHighlighted = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this._tabControl.DisplayStyleProvider.PageBackgroundColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._tabControl.DisplayStyleProvider.PageBackgroundColorUnselected = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this._tabControl.DisplayStyleProvider.SelectedTabIsLarger = false;
            this._tabControl.DisplayStyleProvider.ShowTabCloser = true;
            this._tabControl.DisplayStyleProvider.TabColorDisabled1 = System.Drawing.SystemColors.Control;
            this._tabControl.DisplayStyleProvider.TabColorDisabled2 = System.Drawing.SystemColors.Control;
            this._tabControl.DisplayStyleProvider.TabColorFocused1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this._tabControl.DisplayStyleProvider.TabColorFocused2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this._tabControl.DisplayStyleProvider.TabColorHighLighted1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this._tabControl.DisplayStyleProvider.TabColorHighLighted2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this._tabControl.DisplayStyleProvider.TabColorSelected1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._tabControl.DisplayStyleProvider.TabColorSelected2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._tabControl.DisplayStyleProvider.TabColorUnSelected1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this._tabControl.DisplayStyleProvider.TabColorUnSelected2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this._tabControl.DisplayStyleProvider.TabPageMargin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._tabControl.DisplayStyleProvider.TextColorFocused = System.Drawing.Color.White;
            this._tabControl.DisplayStyleProvider.TextColorHighlighted = System.Drawing.Color.White;
            this._tabControl.DisplayStyleProvider.TextColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this._tabControl.DisplayStyleProvider.TextColorUnselected = System.Drawing.Color.Black;
            this._tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tabControl.HotTrack = true;
            this._tabControl.Location = new System.Drawing.Point(0, 0);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(1083, 564);
            this._tabControl.TabIndex = 3;
            this._tabControl.TabClosing += new System.EventHandler<System.Windows.Forms.TabControlCancelEventArgs>(this._tabControl_TabClosing);
            this._tabControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this._tabControl_MouseClick);
            // 
            // _tabShellManager
            // 
            this._tabShellManager.Location = new System.Drawing.Point(4, 30);
            this._tabShellManager.Name = "_tabShellManager";
            this._tabShellManager.Padding = new System.Windows.Forms.Padding(3);
            this._tabShellManager.Size = new System.Drawing.Size(1075, 530);
            this._tabShellManager.TabIndex = 0;
            this._tabShellManager.Text = "Shell";
            this._tabShellManager.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 593);
            this.Controls.Add(this._tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseClick);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuNotify.ResumeLayout(false);
            this._tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.ToolStripStatusLabel _showMsgLabel;
        private System.Windows.Forms.ToolStripProgressBar _lodingSpinner;
        private System.Windows.Forms.ToolStripStatusLabel _showVersionLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabPage _tabShellManager;
        private System.Windows.Forms.TabControlExtra _tabControl;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuNotify;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}

