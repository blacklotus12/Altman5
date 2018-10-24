namespace Altman.Forms
{
    partial class PageShellManager
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
            this.components = new System.ComponentModel.Container();
            this._gridViewShell = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTargetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTargetLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColShellUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColShellType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAddTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._rightMenuWebshell = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._itemRefreshStatus = new System.Windows.Forms.ToolStripMenuItem();
            this._itemCopyServerCode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._itemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this._itemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this._itemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this._itemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fileManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shellCmderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this._itemFind = new System.Windows.Forms.ToolStripMenuItem();
            this._itemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this._rightMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.updateCustomTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this._gridViewShell)).BeginInit();
            this._rightMenuWebshell.SuspendLayout();
            this._rightMenuBlank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _gridViewShell
            // 
            this._gridViewShell.AllowUserToAddRows = false;
            this._gridViewShell.AllowUserToDeleteRows = false;
            this._gridViewShell.AllowUserToResizeRows = false;
            this._gridViewShell.BackgroundColor = System.Drawing.SystemColors.Window;
            this._gridViewShell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._gridViewShell.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColTargetId,
            this.ColTargetLevel,
            this.ColStatus,
            this.ColShellUrl,
            this.ColShellType,
            this.ColRemark,
            this.ColAddTime});
            this._gridViewShell.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gridViewShell.GridColor = System.Drawing.SystemColors.Window;
            this._gridViewShell.Location = new System.Drawing.Point(0, 0);
            this._gridViewShell.Name = "_gridViewShell";
            this._gridViewShell.RowHeadersVisible = false;
            this._gridViewShell.RowTemplate.Height = 23;
            this._gridViewShell.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._gridViewShell.Size = new System.Drawing.Size(1091, 534);
            this._gridViewShell.TabIndex = 0;
            this._gridViewShell.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._gridViewShell_CellDoubleClick);
            this._gridViewShell.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._gridViewShell_CellMouseClick);
            this._gridViewShell.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._gridViewShell_CellMouseDown);
            this._gridViewShell.MouseClick += new System.Windows.Forms.MouseEventHandler(this._gridViewShell_MouseClick);
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "Id";
            this.ColId.HeaderText = "Id";
            this.ColId.MaxInputLength = 1000;
            this.ColId.MinimumWidth = 10;
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Width = 40;
            // 
            // ColTargetId
            // 
            this.ColTargetId.DataPropertyName = "TargetId";
            this.ColTargetId.HeaderText = "Name";
            this.ColTargetId.Name = "ColTargetId";
            this.ColTargetId.ReadOnly = true;
            // 
            // ColTargetLevel
            // 
            this.ColTargetLevel.DataPropertyName = "TargetLevel";
            this.ColTargetLevel.HeaderText = "Level";
            this.ColTargetLevel.MinimumWidth = 10;
            this.ColTargetLevel.Name = "ColTargetLevel";
            this.ColTargetLevel.ReadOnly = true;
            this.ColTargetLevel.Width = 60;
            // 
            // ColStatus
            // 
            this.ColStatus.DataPropertyName = "Status";
            this.ColStatus.HeaderText = "Status";
            this.ColStatus.MinimumWidth = 10;
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.ReadOnly = true;
            this.ColStatus.Width = 60;
            // 
            // ColShellUrl
            // 
            this.ColShellUrl.DataPropertyName = "ShellUrl";
            this.ColShellUrl.HeaderText = "ShellUrl";
            this.ColShellUrl.MinimumWidth = 100;
            this.ColShellUrl.Name = "ColShellUrl";
            this.ColShellUrl.ReadOnly = true;
            this.ColShellUrl.Width = 300;
            // 
            // ColShellType
            // 
            this.ColShellType.DataPropertyName = "ShellType";
            this.ColShellType.HeaderText = "ShellType";
            this.ColShellType.Name = "ColShellType";
            this.ColShellType.ReadOnly = true;
            // 
            // ColRemark
            // 
            this.ColRemark.DataPropertyName = "Remark";
            this.ColRemark.HeaderText = "Remark";
            this.ColRemark.Name = "ColRemark";
            this.ColRemark.ReadOnly = true;
            // 
            // ColAddTime
            // 
            this.ColAddTime.DataPropertyName = "AddTime";
            this.ColAddTime.HeaderText = "AddTime";
            this.ColAddTime.Name = "ColAddTime";
            this.ColAddTime.ReadOnly = true;
            // 
            // _rightMenuWebshell
            // 
            this._rightMenuWebshell.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._rightMenuWebshell.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._itemRefreshStatus,
            this._itemCopyServerCode,
            this.toolStripSeparator1,
            this._itemEdit,
            this._itemAdd,
            this._itemDelete,
            this._itemCopy,
            this.toolStripSeparator2,
            this.fileManageToolStripMenuItem,
            this.shellCmderToolStripMenuItem,
            this.dBManageToolStripMenuItem,
            this.toolStripSeparator3,
            this._itemFind,
            this._itemUpdate});
            this._rightMenuWebshell.Name = "contextMenuStrip1";
            this._rightMenuWebshell.Size = new System.Drawing.Size(225, 286);
            // 
            // _itemRefreshStatus
            // 
            this._itemRefreshStatus.Name = "_itemRefreshStatus";
            this._itemRefreshStatus.Size = new System.Drawing.Size(224, 24);
            this._itemRefreshStatus.Text = "Refresh Status";
            this._itemRefreshStatus.Click += new System.EventHandler(this._itemRefreshStatus_Click);
            // 
            // _itemCopyServerCode
            // 
            this._itemCopyServerCode.Name = "_itemCopyServerCode";
            this._itemCopyServerCode.Size = new System.Drawing.Size(224, 24);
            this._itemCopyServerCode.Text = "Copy ServerCode";
            this._itemCopyServerCode.Click += new System.EventHandler(this._itemCopyServerCode_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // _itemEdit
            // 
            this._itemEdit.Name = "_itemEdit";
            this._itemEdit.Size = new System.Drawing.Size(224, 24);
            this._itemEdit.Text = "Edit";
            this._itemEdit.Click += new System.EventHandler(this._itemEdit_Click);
            // 
            // _itemAdd
            // 
            this._itemAdd.Name = "_itemAdd";
            this._itemAdd.Size = new System.Drawing.Size(224, 24);
            this._itemAdd.Text = "Add";
            this._itemAdd.Click += new System.EventHandler(this._itemAdd_Click);
            // 
            // _itemDelete
            // 
            this._itemDelete.Name = "_itemDelete";
            this._itemDelete.Size = new System.Drawing.Size(224, 24);
            this._itemDelete.Text = "Delete";
            this._itemDelete.Click += new System.EventHandler(this._itemDelete_Click);
            // 
            // _itemCopy
            // 
            this._itemCopy.Name = "_itemCopy";
            this._itemCopy.Size = new System.Drawing.Size(224, 24);
            this._itemCopy.Text = "Copy";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // fileManageToolStripMenuItem
            // 
            this.fileManageToolStripMenuItem.Name = "fileManageToolStripMenuItem";
            this.fileManageToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.fileManageToolStripMenuItem.Text = "FileManage";
            this.fileManageToolStripMenuItem.Click += new System.EventHandler(this._fileManageToolStripMenuItem_Click);
            // 
            // shellCmderToolStripMenuItem
            // 
            this.shellCmderToolStripMenuItem.Name = "shellCmderToolStripMenuItem";
            this.shellCmderToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.shellCmderToolStripMenuItem.Text = "ShellCmder";
            this.shellCmderToolStripMenuItem.Click += new System.EventHandler(this._shellCmderToolStripMenuItem_Click);
            // 
            // dBManageToolStripMenuItem
            // 
            this.dBManageToolStripMenuItem.Name = "dBManageToolStripMenuItem";
            this.dBManageToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.dBManageToolStripMenuItem.Text = "DBManage";
            this.dBManageToolStripMenuItem.Click += new System.EventHandler(this._dBManageToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(221, 6);
            // 
            // _itemFind
            // 
            this._itemFind.Name = "_itemFind";
            this._itemFind.Size = new System.Drawing.Size(224, 24);
            this._itemFind.Text = "Find";
            // 
            // _itemUpdate
            // 
            this._itemUpdate.Name = "_itemUpdate";
            this._itemUpdate.Size = new System.Drawing.Size(224, 24);
            this._itemUpdate.Text = "UpdateCustomType";
            this._itemUpdate.Click += new System.EventHandler(this._itemUpdate_Click);
            // 
            // _rightMenuBlank
            // 
            this._rightMenuBlank.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._rightMenuBlank.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.updateCustomTypeToolStripMenuItem});
            this._rightMenuBlank.Name = "_rightMenuBlank";
            this._rightMenuBlank.Size = new System.Drawing.Size(225, 128);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this._itemAdd_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this._aboutToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this._optionsToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._gridViewShell);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.treeView1);
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(1091, 534);
            this.splitContainer1.SplitterDistance = 887;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(96, 100);
            this.treeView1.TabIndex = 0;
            // 
            // updateCustomTypeToolStripMenuItem
            // 
            this.updateCustomTypeToolStripMenuItem.Name = "updateCustomTypeToolStripMenuItem";
            this.updateCustomTypeToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.updateCustomTypeToolStripMenuItem.Text = "UpdateCustomType";
            this.updateCustomTypeToolStripMenuItem.Click += new System.EventHandler(this._itemUpdate_Click);
            // 
            // PageShellManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.splitContainer1);
            this.Name = "PageShellManager";
            this.Size = new System.Drawing.Size(1091, 534);
            ((System.ComponentModel.ISupportInitialize)(this._gridViewShell)).EndInit();
            this._rightMenuWebshell.ResumeLayout(false);
            this._rightMenuBlank.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _gridViewShell;
        private System.Windows.Forms.ContextMenuStrip _rightMenuWebshell;
        private System.Windows.Forms.ToolStripMenuItem _itemAdd;
        private System.Windows.Forms.ToolStripMenuItem _itemEdit;
        private System.Windows.Forms.ToolStripMenuItem _itemDelete;
        private System.Windows.Forms.ToolStripMenuItem _itemRefreshStatus;
        private System.Windows.Forms.ToolStripMenuItem _itemCopyServerCode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTargetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTargetLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColShellUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColShellType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAddTime;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem fileManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shellCmderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dBManageToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip _rightMenuBlank;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _itemCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem _itemFind;
        private System.Windows.Forms.ToolStripMenuItem _itemUpdate;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem updateCustomTypeToolStripMenuItem;
    }
}
