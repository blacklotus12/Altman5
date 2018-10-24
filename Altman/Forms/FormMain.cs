using Altman.Util.Setting;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Altman
{
    public partial class FormMain : Form
    {
        private string version = "AltMan5 @ 2018.5.13";
        private string title = "AltMan5";


        private bool bnotify = false;
        Altman.Forms.PageShellManager shellManager;
        // IHost _host;
        public FormMain()
        {
            InitializeComponent();


            //目录初始化
            //if (!Directory.Exists(AppEnvironment.AppBinPath))
            //    Directory.CreateDirectory(AppEnvironment.AppBinPath);
            //if (!Directory.Exists(AppEnvironment.AppPluginPath))
            //    Directory.CreateDirectory(AppEnvironment.AppPluginPath);
            //if (!Directory.Exists(AppEnvironment.AppPluginConfigPath))
            //    Directory.CreateDirectory(AppEnvironment.AppPluginConfigPath);
            //if (!Directory.Exists(AppEnvironment.AppLanguagePath))
            //    Directory.CreateDirectory(AppEnvironment.AppLanguagePath);

            //----数据初始化----
            InitUi.InitCustomShellType(AppEnvironment.AppCustomShellTypePath);
            InitUi.InitGlobalSetting(AppEnvironment.AppPath);
            var basicSetting = (GlobalSetting.Setting as Setting).BasicSetting;
            //数据库设置
            Util.Data.Db.Init(Path.Combine(AppEnvironment.AppPath, "data.mdb"), Util.Data.Db.DbType.Access);
            //----数据初始化结束----

            //语言初始化
            var lang = basicSetting.Language;
            //AltLangRes.ReadLanguageResource(lang);
            //AltStrRes.SetTranslatedStrings(AltLangRes.Table);

            //----导入插件----
            //_pluginsImport = new PluginsImport();
            //_host = new Host(this);
            //PluginProvider.Host = _host;
            //PluginProvider.Compose(AppEnvironment.AppPluginPath, AppEnvironment.AppServicePath, basicSetting.IsOpenIPythonSupport);

            //UI处理
            //();
            //LoadPluginsInUi();
            //InitPlugins(PluginProvider.Plugins);
            //----导入插件结束----

            //显示免责声明
            //InitUi.InitWelcome();

            //auto call services
            //AutoLoadServices(PluginProvider.Services);

            //LoadServicesInUi();

            //auto load plugins
            //AutoLoadPlugins(PluginProvider.Plugins);

            shellManager = new Altman.Forms.PageShellManager(this)
            {
                Dock = DockStyle.Fill
            };
            _tabShellManager.Controls.Add(shellManager);

            //var filemanage = new Altman.Forms.PageFileManage(this);
            //filemanage.Dock = DockStyle.Fill;
            //tabPage1.Controls.Add(filemanage);

            this.Text = title;
            this.notifyIcon1.Visible = false;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelSetting panel = new PanelSetting();
            panel.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //asc.controllInitializeSize(this);
            this._showMsgLabel.Text = "Ready";
            this._showVersionLabel.Text = version;
            this._lodingSpinner.Visible = false;
            this._lodingSpinner.Enabled = false;

            var item = shellManager.ShellData;
            _showMsgLabel.Text = $"All Type Shell ({item.Count})";


            this.Size = new Size(900, 560);

        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            //asc.controlAutoSize(this);
        }

        public string MsgInStatusBar
        {
            get { return _showMsgLabel.Text; }
            set { _showMsgLabel.Text = value; }
        }

        #region ShowOrHideLoadingInStatusBar
        private int _loadingCount = 0;
        private void ShowOrHideLoadingIcon()
        {
            if (_loadingCount > 0)
            {
                this._lodingSpinner.Visible = true;
                this._lodingSpinner.Enabled = true;
            }
            else
            {
                this._lodingSpinner.Enabled = false;
                this._lodingSpinner.Visible = false;
            }
        }

        public void ShowLoadingInStatusBar()
        {
            _loadingCount += 1;
            ShowOrHideLoadingIcon();
        }

        public void HideLoadingInStatusBar()
        {
            _loadingCount -= 1;
            ShowOrHideLoadingIcon();
        }
        #endregion

        public void CreateTabPage(string name, object userControl)
        {
            //create new tabpage
            var newTabpage = new TabPage
            {
                Name = name,
                Text = name
            };
            (userControl as Control).Dock = DockStyle.Fill;
            newTabpage.Controls.Add(userControl as Control);


            var tab = _tabControl;
            if (tab != null)
            {
                tab.DisplayStyleProvider.ShowTabCloser = true;
                tab.TabPages.Add(newTabpage);
                tab.SelectedTab = newTabpage;
            }
        }

        public void CloseTabPage(string tabPageName)
        {

            var tab = _tabControl;
            if (tab.Controls.Count < 1) return;
            foreach (TabPage page in tab.TabPages)
            {
                if (page != null && page.Name == tabPageName)
                {
                    tab.TabPages.Remove(page);
                }
            }

        }


        private void _tabControl_TabClosing(object sender, TabControlCancelEventArgs e)
        {

        }

        private void _tabControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < _tabControl.TabPages.Count; i++)
                {
                    if (_tabControl.GetTabRect(i).Contains(new Point(e.X, e.Y)))
                    {
                        _tabControl.SelectedTab = _tabControl.TabPages[i];
                    }
                }
            }
        }

        private void FormMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && _tabControl.TabPages.Count == 0)
            {
                _tabControl.TabPages.Clear();
                shellManager = new Altman.Forms.PageShellManager(this)
                {
                    Dock = DockStyle.Fill
                };
                CreateTabPage("ShellManager", shellManager);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bnotify)
            {
                e.Cancel = true;
                this.Hide();
                this.notifyIcon1.Visible = true;
                return;
            }
            var dr = MessageBox.Show("Close App?\r\nClick no will minimize the taskbar.", "AltMan", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
                this.Hide();
                this.notifyIcon1.Visible = true;
                bnotify = true;
            }
            else if(dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        #region notifyIcon
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
                notifyIcon1.Visible = false; 
                this.Close();
                this.Dispose();
                Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.notifyIcon1.Visible = false;
        }
        #endregion
    }
}
