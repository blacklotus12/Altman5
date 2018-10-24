using System;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Altman.Resources;
using Plugin_ShellManager;
using Plugin_ShellManager.Data;
using Altman.Webshell.Model;
using System.Threading;
using System.Net;

namespace Altman.Forms
{
    public partial class PageShellManager : UserControl
    {
        public BindingList<Shell> ShellData { get { return _shellData; } set { _shellData = value; } }
        private BindingList<Shell> _shellData;
        private FormMain _mainForm;

        public PageShellManager(FormMain formMain)
        {
            InitializeComponent();

            Init();
            //数据库初始化
            
            _mainForm = formMain;
            ShellManager.Init();
            // 注册事件
            ShellManager.GetDataTableCompletedToDo += ShellManagerGetDataTableCompletedToDo;
            ShellManager.DeleteCompletedToDo += ShellManagerDeleteCompletedToDo;
            ShellManager.InsertCompletedToDo += ShellManagerInsertCompletedToDo;
            ShellManager.UpdateCompletedToDo += ShellManagerUpdateCompletedToDo;

            // 载入shell数据
            LoadWebshellData();

            // 添加插件到右键菜单
            //foreach (var plugin in PluginProvider.GetPlugins())
            //{
            //    // IsShowInRightContext
            //    if (plugin.PluginSetting.LoadPath.ToLower() == "shellmanager")
            //    {
            //        string title = plugin.PluginInfo.Name;

            //        // 添加到Tsmi_Plugins中
            //        var pluginItem = new ToolStripMenuItem();
            //        pluginItem.Name = title;
            //        pluginItem.Text = title;
            //        pluginItem.Click += pluginItem_Click;
            //        pluginItem.Tag = plugin;

            //        _rightMenuWebshell.Items.Add(pluginItem);
            //    }
            //}

            _gridViewShell.DoubleBufferedDataGirdView(true);
        }

        public void Init()
        {
            //_itemRefreshStatus
            _itemRefreshStatus.Text = AltStrRes.GetString("StrRefreshStatus", "Refresh Status");
            _itemCopyServerCode.Text = AltStrRes.GetString("StrCopyServerCode", "Copy ServerCode");
            _itemAdd.Text = AltStrRes.GetString("StrAdd", "Add");
            _itemEdit.Text = AltStrRes.GetString("StrEdit", "Edit");
            _itemDelete.Text = AltStrRes.GetString("StrDelete", "Delete");

            foreach (DataGridViewColumn column in this._gridViewShell.Columns)
            {
                //设置自动排序
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            //清除自动选中第一行
            _gridViewShell.DataBindingComplete += (s, e) => { _gridViewShell.ClearSelection(); };
            _gridViewShell.Sorted += (s, e) => { _gridViewShell.ClearSelection(); };
        }
        /*plugin funtion
        void pluginItem_Click(object sender, EventArgs e)
        {
            if (_gridViewShell.Rows.Count > 0)
            {
                var item = sender as MenuItem;
                if (item != null)
                {
                    var plugin = item.Tag as IPlugin;

                    //var shell = (Shell)_gridViewShell.SelectedItem;
                    var shell = _gridViewShell.SelectedRows[0].DataBoundItem as Shell;
                    shell.TimeOut = 8000;

                    var param = new PluginParameter();
                    param.AddParameter("shell", shell);

                    if (plugin is IControlPlugin)
                    {
                        object view = (plugin as IControlPlugin).Show(param);
                        //创建新的tab标签
                        //设置标题为FileManager|TargetId
                        string title = plugin.PluginInfo.Name + "|" + shell.TargetId;
                        //FormMain.o(title, view);
                    }
                    else if (plugin is IFormPlugin)
                    {
                        var form = (Form)(plugin as IFormPlugin).Show(param);
                        form.Show();
                    }
                }
            }
        }
        */

        /// <summary>
        /// 载入webshell数据
        /// </summary>
        public void LoadWebshellData()
        {
            DataTable dataTable = ShellManager.GetDataTable();
            if (dataTable == null)
            {
                return;
            }
            var item = new BindingCollection<Shell>();
            foreach (DataRow row in dataTable.Rows)
            {
                Shell shell = DataConvert.ConvertDataRowToShellStruct(row);
                item.Add(shell);
            }

            _shellData = item;
            _gridViewShell.AutoGenerateColumns = false;
            _gridViewShell.DataSource = item;
            _gridViewShell.Refresh();
            _gridViewShell.ClearSelection();
        }

        #region 数据获取/插入/删除/更新事件
        private void ShellManagerUpdateCompletedToDo(object sender, ShellManager.CompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
        }
        private void ShellManagerInsertCompletedToDo(object sender, ShellManager.CompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
        }
        private void ShellManagerDeleteCompletedToDo(object sender, ShellManager.CompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
        }
        private void ShellManagerGetDataTableCompletedToDo(object sender, ShellManager.CompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
        }

        #endregion

        #region 右键菜单事件
        private void OnWebshellChange(object sender, EventArgs e)
        {
            LoadWebshellData();
        }
        private void _itemAdd_Click(object sender, EventArgs e)
        {
            var editwebshell = new FormEditWebshell();
            editwebshell.WebshellWatchEvent += OnWebshellChange;
            editwebshell.ShowDialog();
        }
        private void _itemEdit_Click(object sender, EventArgs e)
        {
            if (_gridViewShell.SelectedRows.Count > 0)
            {
                // only get first row
                //Shell shell = (Shell)_gridViewShell.SelectedItem;
                //int index = _gridViewShell.CurrentRow.Index;
                var shell = _gridViewShell.SelectedRows[0].DataBoundItem as Shell;


                FormEditWebshell editwebshell = new FormEditWebshell(shell);
                editwebshell.WebshellWatchEvent += OnWebshellChange;
                editwebshell.ShowDialog();
            }
        }
        private void _itemDelete_Click(object sender, EventArgs e)
        {
            if (_gridViewShell.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection rows = _gridViewShell.SelectedRows;
                // can multi-row
                foreach (DataGridViewRow row in rows)
                {
                    //this.BStudent.RemoveAt(row.Index);
                    var shell = row.DataBoundItem as Shell;
                    int id = int.Parse(shell.Id);
                    ShellManager.Delete(id);
                }
                LoadWebshellData();
            }
        }
        private void _itemCopyServerCode_Click(object sender, EventArgs e)
        {
            if (_gridViewShell.SelectedRows.Count > 0)
            {
                // only get first row
                //var shell = _gridViewShell.SelectedItem as Shell;
                //int index = _gridViewShell.CurrentRow.Index;

                var shell = _gridViewShell.SelectedRows[0].DataBoundItem as Shell;
                string code = Altman.Webshell.Service.GetCustomShellTypeServerCode(shell.ShellType);

                if (string.IsNullOrWhiteSpace(code))
                {
                    MessageBox.Show("ServerCode is NULL!");
                }
                //new Clipboard().Text = code;
                Clipboard.SetDataObject(code);
            }
        }

        private void _fileManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var shell = _gridViewShell.SelectedRows[0].DataBoundItem as Shell;
            shell.TimeOut = 8000;
            var filemanage = new PageFileManager(_mainForm, shell);

            _mainForm.CreateTabPage($"FileManage|{shell.TargetId}", filemanage);
        }

        private void _shellCmderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var shell = _gridViewShell.SelectedRows[0].DataBoundItem as Shell;
            shell.TimeOut = 8000;
            var shellcmder = new PageShellCmder(_mainForm, shell);

            _mainForm.CreateTabPage($"ShellCmder|{shell.TargetId}", shellcmder);
        }

        private void _dBManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var shell = _gridViewShell.SelectedRows[0].DataBoundItem as Shell;
            shell.TimeOut = 8000;
            var dbmanager = new PageDbManager(_mainForm, shell);

            _mainForm.CreateTabPage($"PageDbManager|{shell.TargetId}", dbmanager);
        }

        private void _optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelSetting panel = new PanelSetting();
            panel.ShowDialog();
        }

        private void _aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var strArr = new StringBuilder();
            strArr.AppendLine("Version");
            strArr.AppendLine("2018.5");
            strArr.AppendLine("AltMan License");

            MessageBox.Show(_mainForm, strArr.ToString(), "About");
        }
        #endregion

        #region 批量检测shell状态
        void _itemRefreshStatus_Click(object sender, EventArgs e)
        {
            RefreshStatusOfSelectedRows();
        }
        private void RefreshStatusOfSelectedRows()
        {
            if (_gridViewShell.SelectedRows.Count > 0)
            {
                // can multi-row
                DataGridViewSelectedRowCollection rows = _gridViewShell.SelectedRows;
                // can multi-row
                foreach (DataGridViewRow row in rows)
                {
                    //this.BStudent.RemoveAt(row.Index);
                    var shell = row.DataBoundItem as Shell;
                    Thread thread = new Thread(RefreshStatus);
                    thread.Start(shell);
                }
            }
            else
            {
                MessageBox.Show(_gridViewShell, "please select at least one shell");
            }
        }
        private void RefreshStatus(object shellData)
        {
            var shell = shellData as Shell;
            string shellUrl = shell.ShellUrl;

            HttpWebRequest myRequest = null;
            HttpWebResponse myResponse = null;
            try
            {
                System.Net.ServicePointManager.DefaultConnectionLimit = 1024;
                myRequest = (HttpWebRequest)WebRequest.Create(shellUrl);
                myRequest.Method = "HEAD";
                myRequest.Timeout = 5000;
                myRequest.KeepAlive = false;
                myRequest.UseDefaultCredentials = true;
                myRequest.AllowAutoRedirect = false;
                myResponse = (HttpWebResponse)myRequest.GetResponse();
            }
            catch (WebException ex)
            {
                myResponse = (HttpWebResponse)ex.Response;
            }
            finally
            {
                if (myRequest != null)
                    myRequest.Abort();
                if (myResponse != null)
                    myResponse.Close();
            }
            if (myResponse == null)
            {
                RefreshShellStatusInListView(shell, "-1");
            }
            else
            {
                RefreshShellStatusInListView(shell, Convert.ToInt32(myResponse.StatusCode).ToString());
            }
        }

        private void RefreshShellStatusInListView(Shell item, string status)
        {
            // update status to database
            item.Status = status;
            ShellManager.Update(int.Parse(item.Id), item);
            // refresh
            _mainForm.Invoke(new Action(LoadWebshellData));
        }
        #endregion

        #region GridView Event

        private void _gridViewShell_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_gridViewShell.SelectedRows.Count > 0 && e.RowIndex >= 0)
            {
                var shell = _gridViewShell.SelectedRows[0].DataBoundItem as Shell;
                shell.TimeOut = 8000;
                var filemanage = new PageFileManager(_mainForm, shell);

                _mainForm.CreateTabPage($"FileManage|{shell.TargetId}", filemanage);
            }
        }

        private void _gridViewShell_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    int index = _gridViewShell.FirstDisplayedScrollingRowIndex;
                    int displayedCount = _gridViewShell.DisplayedRowCount(true);
                    if (index + displayedCount - 1 < 0)
                    {
                        this._rightMenuBlank.Show(MousePosition.X, MousePosition.Y);
                        return;
                    }
                    Rectangle rect = _gridViewShell.GetRowDisplayRectangle(index + displayedCount - 1, true);
                    //_gridViewShell.ContextMenuStrip = this._rightMenuBlank;
                    if (e.Y > rect.Y)
                    {
                        this._rightMenuBlank.Show(MousePosition.X, MousePosition.Y);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void _gridViewShell_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    //_gridViewShell.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                    _gridViewShell.ClearSelection();
                    _gridViewShell.Rows[e.RowIndex].Selected = true;
                    _gridViewShell.CurrentCell = _gridViewShell.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    this._rightMenuWebshell.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void _gridViewShell_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)  //点击的是鼠标右键，并且不是表头
            {
                if (e.ColumnIndex > -1 && e.RowIndex > -1)
                {
                    //右键选中单元格
                    //this._gridViewShell.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                }
                this._rightMenuWebshell.Show(MousePosition.X, MousePosition.Y); //MousePosition.X, MousePosition.Y 是为了让菜单在所选行的位置显示
            }
        }

        #endregion

        private void _itemUpdate_Click(object sender, EventArgs e)
        {
            InitUi.InitCustomShellType(AppEnvironment.AppCustomShellTypePath);
            _mainForm.MsgInStatusBar = "ReLoad Custom Type Success";
        }
    }
}
