namespace Altman.Forms
{
    partial class PageFileManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageFileManager));
            this._buttonDir = new System.Windows.Forms.Button();
            this._treeViewDirs = new System.Windows.Forms.TreeView();
            this._gridViewFile = new System.Windows.Forms.DataGridView();
            this.ColImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAttributes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._rightMenuFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wgetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._cbCurrentPath = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this._rightMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refeshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.uploadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wgetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.folderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this._gridViewFile)).BeginInit();
            this._rightMenuFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this._rightMenuBlank.SuspendLayout();
            this.SuspendLayout();
            // 
            // _buttonDir
            // 
            this._buttonDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonDir.Location = new System.Drawing.Point(652, 2);
            this._buttonDir.Margin = new System.Windows.Forms.Padding(2);
            this._buttonDir.Name = "_buttonDir";
            this._buttonDir.Size = new System.Drawing.Size(56, 18);
            this._buttonDir.TabIndex = 1;
            this._buttonDir.Text = "Read";
            this._buttonDir.UseVisualStyleBackColor = true;
            this._buttonDir.Click += new System.EventHandler(this._buttonDir_Click);
            // 
            // _treeViewDirs
            // 
            this._treeViewDirs.Dock = System.Windows.Forms.DockStyle.Fill;
            this._treeViewDirs.Location = new System.Drawing.Point(0, 0);
            this._treeViewDirs.Margin = new System.Windows.Forms.Padding(2);
            this._treeViewDirs.Name = "_treeViewDirs";
            this._treeViewDirs.Size = new System.Drawing.Size(181, 404);
            this._treeViewDirs.TabIndex = 2;
            this._treeViewDirs.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this._treeViewDirs_AfterSelect);
            // 
            // _gridViewFile
            // 
            this._gridViewFile.AllowDrop = true;
            this._gridViewFile.AllowUserToAddRows = false;
            this._gridViewFile.AllowUserToDeleteRows = false;
            this._gridViewFile.AllowUserToResizeRows = false;
            this._gridViewFile.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._gridViewFile.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._gridViewFile.ColumnHeadersHeight = 20;
            this._gridViewFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColImage,
            this.ColName,
            this.ColTime,
            this.ColSize,
            this.ColAttributes});
            this._gridViewFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gridViewFile.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this._gridViewFile.GridColor = System.Drawing.SystemColors.Window;
            this._gridViewFile.Location = new System.Drawing.Point(0, 0);
            this._gridViewFile.Margin = new System.Windows.Forms.Padding(2);
            this._gridViewFile.Name = "_gridViewFile";
            this._gridViewFile.RowHeadersVisible = false;
            this._gridViewFile.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._gridViewFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._gridViewFile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._gridViewFile.Size = new System.Drawing.Size(527, 404);
            this._gridViewFile.TabIndex = 3;
            this._gridViewFile.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this._gridViewFile_CellBeginEdit);
            this._gridViewFile.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._gridViewFile_CellDoubleClick);
            this._gridViewFile.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this._gridViewFile_CellEndEdit);
            this._gridViewFile.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._gridViewFile_CellMouseDown);
            this._gridViewFile.DragDrop += new System.Windows.Forms.DragEventHandler(this._gridViewFile_DragDrop);
            this._gridViewFile.DragEnter += new System.Windows.Forms.DragEventHandler(this._gridViewFile_DragEnter);
            this._gridViewFile.KeyDown += new System.Windows.Forms.KeyEventHandler(this._gridViewFile_KeyDown);
            this._gridViewFile.MouseClick += new System.Windows.Forms.MouseEventHandler(this._gridViewFile_MouseClick);
            // 
            // ColImage
            // 
            this.ColImage.DataPropertyName = "Image";
            this.ColImage.HeaderText = ">";
            this.ColImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColImage.Name = "ColImage";
            this.ColImage.ReadOnly = true;
            this.ColImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColImage.Width = 30;
            // 
            // ColName
            // 
            this.ColName.DataPropertyName = "Name";
            this.ColName.HeaderText = "FileName";
            this.ColName.MinimumWidth = 100;
            this.ColName.Name = "ColName";
            this.ColName.Width = 300;
            // 
            // ColTime
            // 
            this.ColTime.DataPropertyName = "FileMTime";
            this.ColTime.HeaderText = "Time";
            this.ColTime.Name = "ColTime";
            // 
            // ColSize
            // 
            this.ColSize.DataPropertyName = "FileSize";
            this.ColSize.HeaderText = "Size";
            this.ColSize.Name = "ColSize";
            this.ColSize.ReadOnly = true;
            // 
            // ColAttributes
            // 
            this.ColAttributes.DataPropertyName = "FileAttributes";
            this.ColAttributes.HeaderText = "Attributes";
            this.ColAttributes.Name = "ColAttributes";
            this.ColAttributes.ReadOnly = true;
            // 
            // _rightMenuFile
            // 
            this._rightMenuFile.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._rightMenuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.toolStripSeparator1,
            this.uploadToolStripMenuItem,
            this.downloadToolStripMenuItem,
            this.wgetToolStripMenuItem,
            this.toolStripSeparator2,
            this.editToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.modiToolStripMenuItem,
            this.toolStripSeparator3,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.newToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this._rightMenuFile.Name = "contextMenuStrip1";
            this._rightMenuFile.Size = new System.Drawing.Size(146, 270);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // uploadToolStripMenuItem
            // 
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.uploadToolStripMenuItem.Text = "Upload";
            this.uploadToolStripMenuItem.Click += new System.EventHandler(this.uploadToolStripMenuItem_Click);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.downloadToolStripMenuItem.Text = "Download";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
            // 
            // wgetToolStripMenuItem
            // 
            this.wgetToolStripMenuItem.Name = "wgetToolStripMenuItem";
            this.wgetToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.wgetToolStripMenuItem.Text = "Wget";
            this.wgetToolStripMenuItem.Click += new System.EventHandler(this.wgetToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(142, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // modiToolStripMenuItem
            // 
            this.modiToolStripMenuItem.Name = "modiToolStripMenuItem";
            this.modiToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.modiToolStripMenuItem.Text = "ModifyTime";
            this.modiToolStripMenuItem.Click += new System.EventHandler(this.modiToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(142, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(142, 6);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.folderToolStripMenuItem.Text = "Folder";
            this.folderToolStripMenuItem.Click += new System.EventHandler(this.folderToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(2, 25);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 16, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._treeViewDirs);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._gridViewFile);
            this.splitContainer1.Size = new System.Drawing.Size(711, 404);
            this.splitContainer1.SplitterDistance = 181;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 4;
            // 
            // _cbCurrentPath
            // 
            this._cbCurrentPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbCurrentPath.FormattingEnabled = true;
            this._cbCurrentPath.Location = new System.Drawing.Point(4, 2);
            this._cbCurrentPath.Margin = new System.Windows.Forms.Padding(2);
            this._cbCurrentPath.Name = "_cbCurrentPath";
            this._cbCurrentPath.Size = new System.Drawing.Size(644, 20);
            this._cbCurrentPath.TabIndex = 4;
            this._cbCurrentPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this._textboxUrl_KeyDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "drive.ico");
            this.imageList1.Images.SetKeyName(1, "floder.ico");
            // 
            // _rightMenuBlank
            // 
            this._rightMenuBlank.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._rightMenuBlank.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refeshToolStripMenuItem,
            this.toolStripSeparator5,
            this.uploadToolStripMenuItem1,
            this.wgetToolStripMenuItem1,
            this.toolStripSeparator6,
            this.pasteToolStripMenuItem1,
            this.toolStripSeparator7,
            this.newToolStripMenuItem1});
            this._rightMenuBlank.Name = "_rightMenuBlank";
            this._rightMenuBlank.Size = new System.Drawing.Size(121, 132);
            // 
            // refeshToolStripMenuItem
            // 
            this.refeshToolStripMenuItem.Name = "refeshToolStripMenuItem";
            this.refeshToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.refeshToolStripMenuItem.Text = "Refresh";
            this.refeshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(117, 6);
            // 
            // uploadToolStripMenuItem1
            // 
            this.uploadToolStripMenuItem1.Name = "uploadToolStripMenuItem1";
            this.uploadToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.uploadToolStripMenuItem1.Text = "Upload";
            this.uploadToolStripMenuItem1.Click += new System.EventHandler(this.uploadToolStripMenuItem_Click);
            // 
            // wgetToolStripMenuItem1
            // 
            this.wgetToolStripMenuItem1.Name = "wgetToolStripMenuItem1";
            this.wgetToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.wgetToolStripMenuItem1.Text = "Wget";
            this.wgetToolStripMenuItem1.Click += new System.EventHandler(this.wgetToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(117, 6);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.pasteToolStripMenuItem1.Text = "Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(117, 6);
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolStripMenuItem1,
            this.fileToolStripMenuItem1});
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.newToolStripMenuItem1.Text = "New";
            // 
            // folderToolStripMenuItem1
            // 
            this.folderToolStripMenuItem1.Name = "folderToolStripMenuItem1";
            this.folderToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.folderToolStripMenuItem1.Text = "Folder";
            this.folderToolStripMenuItem1.Click += new System.EventHandler(this.folderToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.fileToolStripMenuItem1.Text = "File";
            this.fileToolStripMenuItem1.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // PageFileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._cbCurrentPath);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this._buttonDir);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PageFileManager";
            this.Size = new System.Drawing.Size(716, 431);
            ((System.ComponentModel.ISupportInitialize)(this._gridViewFile)).EndInit();
            this._rightMenuFile.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this._rightMenuBlank.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button _buttonDir;
        private System.Windows.Forms.TreeView _treeViewDirs;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView _gridViewFile;
        private System.Windows.Forms.ComboBox _cbCurrentPath;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip _rightMenuFile;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wgetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewImageColumn ColImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAttributes;
        private System.Windows.Forms.ContextMenuStrip _rightMenuBlank;
        private System.Windows.Forms.ToolStripMenuItem refeshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wgetToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
    }
}
