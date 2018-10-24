using Altman.Resources;
using Altman.Webshell.Model;
using Plugin_ShellManager;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Altman.Forms
{
    public delegate void WebshellWatchEventHandler(object sender, EventArgs e);
    public partial class FormEditWebshell : Form
    {
        private Shell _perShellData;
        private int _perFormHeight;
        public FormEditWebshell()
        {
            InitializeComponent();
            Init();

            //init
            ComboBox_ScriptType_Init();
        }

        void Init()
        {
            this.Text = "Edit WebShell";

            // _buttonAdvanced
            _buttonAdvanced.Text = AltStrRes.GetString("StrAdvanced", "Advanced");

            _dropDownServerCoding.Items.Add("UTF-8");
            _dropDownServerCoding.Items.Add("GB2312");
            _dropDownServerCoding.SelectedIndex = 0;
            _dropDownWebCoding.Items.Add("UTF-8");
            _dropDownWebCoding.Items.Add("GB2312");
            _dropDownWebCoding.SelectedIndex = 0;

            // _buttonDefault
            _buttonDefault.Text = "Default";

            SetHintText(_textBoxName, "*Name");
            SetHintText(_textBoxShellPath, "*Shell Url");
            SetHintText(_textBoxShellPass, "*Pass");
            SetHintText(_textBoxRemark, "*Remark");

            _perFormHeight = this.Height;
        }


        public FormEditWebshell(Shell shellArray)
        {
            InitializeComponent();
            Init();

            _perShellData = shellArray;
            //init
            ComboBox_ScriptType_Init();

            _textBoxName.Text = shellArray.TargetId;
            _comboBoxLevel.Text = shellArray.TargetLevel;
            _comboBoxLevel.Items.Add(shellArray.TargetLevel);
            if (!_dropDownScritpType.Items.Contains(shellArray.ShellType))
            {
                _dropDownScritpType.Items.Add(shellArray.ShellType);
            }
            _dropDownScritpType.SelectedItem = shellArray.ShellType;

            _textBoxShellPath.Text = shellArray.ShellUrl;
            _textBoxShellPass.Text = shellArray.ShellPwd;

            _textBoxRemark.Text = shellArray.Remark;

            if (!_dropDownServerCoding.Items.Contains(shellArray.ServerCoding))
            {
                _dropDownServerCoding.Items.Add(shellArray.ServerCoding);
            }
            _dropDownServerCoding.SelectedItem = shellArray.ServerCoding;

            if (!_dropDownWebCoding.Items.Contains(shellArray.WebCoding))
            {
                _dropDownWebCoding.Items.Add(shellArray.WebCoding);
            }
            _dropDownWebCoding.SelectedItem = shellArray.WebCoding;

            _richTextBoxSetting.Text = shellArray.ShellExtraString;
        }

        private Shell GetShellConfigFromPanel()
        {
            var shell = new Shell();

            shell.Id = this._perShellData?.Id;
            shell.TargetId = _textBoxName.Text.Trim();//*
            shell.TargetLevel = _comboBoxLevel.Text;
            shell.ShellType = _dropDownScritpType.SelectedItem?.ToString() ?? "";//*

            shell.ShellUrl = _textBoxShellPath.Text.Trim();//*
            shell.ShellPwd = _textBoxShellPass.Text.Trim();//*

            shell.ShellExtraString = _richTextBoxSetting.Text;
            shell.Remark = _textBoxRemark.Text;

            shell.ServerCoding = _dropDownServerCoding.SelectedItem?.ToString() ?? "UTF-8";//*
            shell.WebCoding = _dropDownWebCoding.SelectedItem?.ToString() ?? "UTF-8";//*

            var time = DateTime.Now.Date.ToShortDateString();
            if (time.Contains("/"))
            {
                time = time.Replace("/", "-");
            }
            shell.AddTime = time;
            return shell;
        }

        private bool VerifyShell(Shell shell)
        {
            var success = true;
            if (shell.TargetId == ""
                || shell.ShellType == ""
                || shell.ShellUrl == ""
                || shell.ShellPwd == ""
                || shell.ServerCoding == ""
                || shell.WebCoding == "")
            {
                success = false;
                MessageBox.Show(AltStrRes.GetString("StrPleaseFillOutTheProjectWith*", "Please fill out the project with *"),
                                "",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            return success;
        }

        public event WebshellWatchEventHandler WebshellWatchEvent;
        private void OnWebshellChange(EventArgs e)
        {
            if (WebshellWatchEvent != null)
            {
                WebshellWatchEvent(this, e);
            }
        }

        /// <summary>
        /// 初始化可选择的脚本类型
        /// </summary>
        private void ComboBox_ScriptType_Init()
        {
            //获取可用的CustomShellType
            foreach (var type in Altman.Webshell.Service.GetCustomShellTypeNameList())
            {
                _dropDownScritpType.Items.Add(type);
            }
        }

        private void _buttonAdvanced_Click(object sender, EventArgs e)
        {
            _panelAdvanced.Visible = !_panelAdvanced.Visible;
            this.Height = _panelAdvanced.Visible ? _perFormHeight + _panelAdvanced.Height : _perFormHeight;
        }

        private void _buttonAdd_Click(object sender, EventArgs e)
        {
            var shell = GetShellConfigFromPanel();
            //验证Shell是否合法
            if (!VerifyShell(shell))
                return;

            if (_perShellData == null)
            {
                ShellManager.Insert(shell);
            }
            else
            {
                ShellManager.Update(int.Parse(shell.Id), shell);
            }
            
            OnWebshellChange(EventArgs.Empty);
            Close();
        }

        private void _buttonDefault_Click(object sender, EventArgs e)
        {
            if (_dropDownScritpType.SelectedIndex != -1)
            {
                var conns = Altman.Webshell.Service.GetDbNodeInfoList(_dropDownScritpType.SelectedText);
                _richTextBoxSetting.Text = ShellExtraStringHandle.CreateDefaultIniString(conns);
            }
            else
            {
                MessageBox.Show(
                    AltStrRes.GetString("StrPleaseSelectScriptTypeFirst", "Please select script type first"),
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg,
        int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        public static void SetHintText(Control control, string text)
        {
            SendMessage(control.Handle, 0x1501, 0, text);
        }
    }
}
