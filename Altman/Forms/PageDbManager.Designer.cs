namespace Altman.Forms
{
    partial class PageDbManager
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageDbManager));
            this._gridViewResult = new System.Windows.Forms.ListView();
            this._cbAreaSql = new System.Windows.Forms.ComboBox();
            this._buttonRunScript = new System.Windows.Forms.Button();
            this._buttonConnect = new System.Windows.Forms.Button();
            this._dropDownDbs = new System.Windows.Forms.ComboBox();
            this._treeViewDbs = new System.Windows.Forms.TreeView();
            this._treeViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.getCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.query20LineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._buttonDisconnect = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this._listViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyCellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._treeViewMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this._listViewMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _gridViewResult
            // 
            this._gridViewResult.ContextMenuStrip = this._listViewMenu;
            this._gridViewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gridViewResult.FullRowSelect = true;
            this._gridViewResult.GridLines = true;
            this._gridViewResult.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this._gridViewResult.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this._gridViewResult.Location = new System.Drawing.Point(0, 0);
            this._gridViewResult.Name = "_gridViewResult";
            this._gridViewResult.ShowGroups = false;
            this._gridViewResult.Size = new System.Drawing.Size(637, 473);
            this._gridViewResult.TabIndex = 1;
            this._gridViewResult.UseCompatibleStateImageBehavior = false;
            this._gridViewResult.View = System.Windows.Forms.View.Details;
            // 
            // _textAreaSql
            // 
            this._cbAreaSql.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbAreaSql.FormattingEnabled = true;
            this._cbAreaSql.Location = new System.Drawing.Point(269, 4);
            this._cbAreaSql.Name = "_textAreaSql";
            this._cbAreaSql.Size = new System.Drawing.Size(569, 23);
            this._cbAreaSql.TabIndex = 5;
            // 
            // _buttonRunScript
            // 
            this._buttonRunScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonRunScript.Location = new System.Drawing.Point(841, 4);
            this._buttonRunScript.Name = "_buttonRunScript";
            this._buttonRunScript.Size = new System.Drawing.Size(74, 23);
            this._buttonRunScript.TabIndex = 6;
            this._buttonRunScript.Text = "execult";
            this._buttonRunScript.UseVisualStyleBackColor = true;
            this._buttonRunScript.Click += new System.EventHandler(this._buttonRunScript_Click);
            // 
            // _buttonConnect
            // 
            this._buttonConnect.Location = new System.Drawing.Point(2, 3);
            this._buttonConnect.Name = "_buttonConnect";
            this._buttonConnect.Size = new System.Drawing.Size(58, 23);
            this._buttonConnect.TabIndex = 3;
            this._buttonConnect.Text = "Connect";
            this._buttonConnect.UseVisualStyleBackColor = true;
            this._buttonConnect.Click += new System.EventHandler(this._buttonConnect_Click);
            // 
            // _dropDownDbs
            // 
            this._dropDownDbs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._dropDownDbs.FormattingEnabled = true;
            this._dropDownDbs.Location = new System.Drawing.Point(129, 4);
            this._dropDownDbs.Name = "_dropDownDbs";
            this._dropDownDbs.Size = new System.Drawing.Size(135, 23);
            this._dropDownDbs.TabIndex = 4;
            // 
            // _treeViewDbs
            // 
            this._treeViewDbs.ContextMenuStrip = this._treeViewMenu;
            this._treeViewDbs.Dock = System.Windows.Forms.DockStyle.Fill;
            this._treeViewDbs.Location = new System.Drawing.Point(0, 0);
            this._treeViewDbs.Name = "_treeViewDbs";
            this._treeViewDbs.Size = new System.Drawing.Size(274, 473);
            this._treeViewDbs.TabIndex = 0;
            this._treeViewDbs.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this._treeViewDbs_NodeMouseDoubleClick);
            this._treeViewDbs.MouseDown += new System.Windows.Forms.MouseEventHandler(this._treeViewDbs_MouseDown);
            // 
            // _treeViewMenu
            // 
            this._treeViewMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._treeViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getCountToolStripMenuItem,
            this.query20LineToolStripMenuItem,
            this.dropTableToolStripMenuItem,
            this.copyNameToolStripMenuItem});
            this._treeViewMenu.Name = "treeViewMenu";
            this._treeViewMenu.Size = new System.Drawing.Size(186, 100);
            // 
            // getCountToolStripMenuItem
            // 
            this.getCountToolStripMenuItem.Name = "getCountToolStripMenuItem";
            this.getCountToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.getCountToolStripMenuItem.Text = "Get Count";
            this.getCountToolStripMenuItem.Click += new System.EventHandler(this.getCountToolStripMenuItem_Click);
            // 
            // query20LineToolStripMenuItem
            // 
            this.query20LineToolStripMenuItem.Name = "query20LineToolStripMenuItem";
            this.query20LineToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.query20LineToolStripMenuItem.Text = "Query 20 Lines";
            this.query20LineToolStripMenuItem.Click += new System.EventHandler(this.query20LineToolStripMenuItem_Click);
            // 
            // dropTableToolStripMenuItem
            // 
            this.dropTableToolStripMenuItem.Name = "dropTableToolStripMenuItem";
            this.dropTableToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.dropTableToolStripMenuItem.Text = "Drop Table";
            this.dropTableToolStripMenuItem.Click += new System.EventHandler(this.dropTableToolStripMenuItem_Click);
            // 
            // copyNameToolStripMenuItem
            // 
            this.copyNameToolStripMenuItem.Name = "copyNameToolStripMenuItem";
            this.copyNameToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.copyNameToolStripMenuItem.Text = "Copy Name";
            this.copyNameToolStripMenuItem.Click += new System.EventHandler(this.copyNameToolStripMenuItem_Click);
            // 
            // _buttonDisconnect
            // 
            this._buttonDisconnect.Location = new System.Drawing.Point(64, 3);
            this._buttonDisconnect.Name = "_buttonDisconnect";
            this._buttonDisconnect.Size = new System.Drawing.Size(61, 23);
            this._buttonDisconnect.TabIndex = 2;
            this._buttonDisconnect.Text = "DisConnect";
            this._buttonDisconnect.UseVisualStyleBackColor = true;
            this._buttonDisconnect.Click += new System.EventHandler(this._buttonDisconnect_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 33);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._treeViewDbs);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._gridViewResult);
            this.splitContainer1.Size = new System.Drawing.Size(912, 473);
            this.splitContainer1.SplitterDistance = 274;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0.database_start.ico");
            this.imageList1.Images.SetKeyName(1, "1.database_failed.ico");
            this.imageList1.Images.SetKeyName(2, "2.database.ico");
            this.imageList1.Images.SetKeyName(3, "3.table.ico");
            this.imageList1.Images.SetKeyName(4, "4.table_failed.ico");
            this.imageList1.Images.SetKeyName(5, "5.column.ico");
            // 
            // _listViewMenu
            // 
            this._listViewMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._listViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyCellToolStripMenuItem,
            this.copyRowToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.exportCSVToolStripMenuItem});
            this._listViewMenu.Name = "contextMenuStrip2";
            this._listViewMenu.Size = new System.Drawing.Size(167, 100);
            // 
            // copyCellToolStripMenuItem
            // 
            this.copyCellToolStripMenuItem.Name = "copyCellToolStripMenuItem";
            this.copyCellToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.copyCellToolStripMenuItem.Text = "Copy Cell";
            this.copyCellToolStripMenuItem.Click += new System.EventHandler(this.copyCellToolStripMenuItem_Click);
            // 
            // copyRowToolStripMenuItem
            // 
            this.copyRowToolStripMenuItem.Name = "copyRowToolStripMenuItem";
            this.copyRowToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.copyRowToolStripMenuItem.Text = "Copy Row";
            this.copyRowToolStripMenuItem.Click += new System.EventHandler(this.copyRowToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.exportToolStripMenuItem.Text = "Export Html";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // exportCSVToolStripMenuItem
            // 
            this.exportCSVToolStripMenuItem.Name = "exportCSVToolStripMenuItem";
            this.exportCSVToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.exportCSVToolStripMenuItem.Text = "Export CSV";
            this.exportCSVToolStripMenuItem.Click += new System.EventHandler(this.exportCSVToolStripMenuItem_Click);
            // 
            // PageDbManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._buttonRunScript);
            this.Controls.Add(this._buttonDisconnect);
            this.Controls.Add(this._cbAreaSql);
            this.Controls.Add(this._dropDownDbs);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this._buttonConnect);
            this.Name = "PageDbManager";
            this.Size = new System.Drawing.Size(918, 509);
            this._treeViewMenu.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this._listViewMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView _gridViewResult;
        private System.Windows.Forms.ComboBox _cbAreaSql;
        private System.Windows.Forms.Button _buttonRunScript;
        private System.Windows.Forms.Button _buttonConnect;
        private System.Windows.Forms.ComboBox _dropDownDbs;
        private System.Windows.Forms.TreeView _treeViewDbs;
        private System.Windows.Forms.Button _buttonDisconnect;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip _treeViewMenu;
        private System.Windows.Forms.ToolStripMenuItem getCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem query20LineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyNameToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip _listViewMenu;
        private System.Windows.Forms.ToolStripMenuItem copyCellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportCSVToolStripMenuItem;
    }
}
