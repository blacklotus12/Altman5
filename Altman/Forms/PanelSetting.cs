using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Altman.Resources;
using Altman.Util.Logic;
using Altman.Util.Setting;

namespace Altman
{
    public partial class PanelSetting : Form
    {
        class HeaderItem
        {
            public string Key { get; private set; }

            public string Value { get; private set; }

            public HeaderItem(string key, string value)
            {
                this.Key = key;
                this.Value = value;
            }

            public override string ToString()
            {
                return this.Value;
            }
        }
        public PanelSetting()
        {
            InitializeComponent();

            LoadSetting((Setting)GlobalSetting.Setting);
            Init();
        }

        void Init()
        {
            // buttons
            _buttonSaveSetting = new Button() { Text = AltStrRes.SaveAndExit };

            _buttonCancel = new Button() { Text = AltStrRes.Cancel };

            //BaseSetting
            _dropDownLang.Width = 200;
            _dropDownLang.Items.Add("EN");
            _dropDownLang.Items.Add("CN");
            _dropDownLang.SelectedIndex = 0;
            _checkBoxIsShowDisclaimer.Text = AltStrRes.IsShowDisclaimer;

            //UserAgent
            _checkBoxIsRandom.Text = AltStrRes.IsUserAgentRandom;
            _comboBoxUserAgentList.Width = 300;
            _checkBoxIsShowDisclaimer.Text = AltStrRes.IsShowDisclaimer;
            _useragentlabel.Text = AltStrRes.UserAgentList;

            //HttpHeader

            //Policy
            _checkBoxIsParamRandom.Text = AltStrRes.IsParamRandom;

            //Proxy
            // radioButton_noProxy
            _radioButtonNoProxy.Text = AltStrRes.NotUseProxy;
            _radioButtonNoProxy.CheckedChanged += delegate
            {
                if (_radioButtonNoProxy.Checked)
                {
                    _groupBoxSetting.Enabled = false;
                }
            };

            // radioButton_ieProxy
            _radioButtonIeProxy.Text = AltStrRes.UseSystemProxySetting;
            _radioButtonIeProxy.CheckedChanged += delegate
            {
                if (_radioButtonIeProxy.Checked)
                {
                    _groupBoxSetting.Enabled = false;
                }
            };

            // radioButton_customProxy
            _radioButtonCustomProxy.Text = AltStrRes.UseCustomProxySetting;
            _radioButtonCustomProxy.CheckedChanged += delegate
            {
                if (_radioButtonCustomProxy.Checked)
                {
                    _groupBoxSetting.Enabled = true;
                }
            };

            _groupBoxSetting.Text = AltStrRes.Setting;
        }

        private void _gridViewHeader_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)  //点击的是鼠标右键，并且不是表头
            {
                if (e.ColumnIndex > -1 && e.RowIndex > -1)
                {
                    //右键选中单元格
                    this._gridViewHeader.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                }
                this._contextMenuRightMenu.Show(MousePosition.X, MousePosition.Y); //MousePosition.X, MousePosition.Y 是为了让菜单在所选行的位置显示
            }
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = new DataGridViewRow();
            int index = this._gridViewHeader.Rows.Add();
            _gridViewHeader.Rows[index].Cells[0].Value = "NewKey";
            _gridViewHeader.Rows[index].Cells[1].Value = "";
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_gridViewHeader.SelectedRows.Count >= 1)
            {
                var rows = _gridViewHeader.SelectedRows;
                foreach (DataGridViewRow row in rows)
                {
                    _gridViewHeader.Rows.RemoveAt(row.Index);
                }
            }
        }


        void LoadSetting(Setting setting)
        {
            //BasicSetting
            var basic = setting.BasicSetting;
            _dropDownLang.SelectedText = basic.Language;
            _checkBoxIsShowDisclaimer.Checked = basic.IsShowDisclaimer;

            //UserAgentSetting
            var userAgent = setting.UserAgentSetting;
            _checkBoxIsRandom.Checked = userAgent.IsRandom;
            foreach (var i in userAgent.UserAgentList)
            {
                var item = new HeaderItem(i.Key, i.Value);
                _comboBoxUserAgentList.Items.Add(item);
            }
            //var selecteditem = new HeaderItem(userAgent.Selected.Key, userAgent.Selected.Value);
            //var id = _comboBoxUserAgentList.Items.IndexOf(selecteditem);
            foreach (HeaderItem item in _comboBoxUserAgentList.Items)
            {
                if (item.Key == userAgent.Selected.Key)
                {
                    _comboBoxUserAgentList.SelectedItem = item;
                    break;
                }
            }

            //HttpHeaderSetting
            var header = setting.HttpHeaderSetting;
            if (header.HttpHeaderList != null)
            {
                foreach (var i in header.HttpHeaderList)
                {
                    int index = this._gridViewHeader.Rows.Add();
                    _gridViewHeader.Rows[index].Cells[0].Value = i.Key;
                    _gridViewHeader.Rows[index].Cells[1].Value = i.Value;
                }
            }

            //PolicySetting
            var policy = setting.PolicySetting;
            _checkBoxIsParamRandom.Checked = policy.IsParamRandom;

            //ProxySetting
            var proxy = setting.ProxySetting;
            switch (proxy.IsNoOrIeOrCustomProxy)
            {
                case 0:
                    _radioButtonNoProxy.Checked = true;
                    break;
                case 1:
                    _radioButtonIeProxy.Checked = true;
                    break;
                case 2:
                    _radioButtonCustomProxy.Checked = true;
                    break;
                default:
                    _radioButtonNoProxy.Checked = true;
                    break;
            }
            _textBoxProxyAddr.Text = proxy.ProxyAddr;
            _textBoxProxyPort.Text = proxy.ProxyPort;
            _textBoxProxyUser.Text = proxy.ProxyUser;
            _textBoxProxyPasswd.Text = proxy.ProxyPassword;
            _textBoxProxyDomain.Text = proxy.ProxyDomain;

        }

        void SaveSetting()
        {
            //BasicSetting
            var basic = new Setting.BasicStruct
            {
                Language = _dropDownLang.SelectedText,
                IsShowDisclaimer = _checkBoxIsShowDisclaimer.Checked == true,
                IsOpenIPythonSupport = false
            };

            //UserAgentSetting
            var userAgent = new Setting.UserAgentStruct();
            userAgent.UserAgentList = new Dictionary<string, string>();
            //获取随机化开关
            userAgent.IsRandom = _checkBoxIsRandom.Checked == true;
            //获取选中项
            int index = _comboBoxUserAgentList.SelectedIndex;
            var headeritem = _comboBoxUserAgentList.Items[index < 0 ? 0 : index] as HeaderItem;
            userAgent.Selected = new KeyValuePair<string, string>(headeritem.Key, headeritem.Value);
            //获取所有列表
            foreach (HeaderItem item in _comboBoxUserAgentList.Items)
            {
                userAgent.UserAgentList.Add(item.Key, item.Value);
            }

            //HttpHeaderSetting
            var httpHeader = new Setting.HttpHeaderStruct();
            httpHeader.HttpHeaderList = new Dictionary<string, string>();
            if (_gridViewHeader.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in _gridViewHeader.Rows)
                {
                    var key = item.Cells[0].Value.ToString();
                    var value = item.Cells[1].Value.ToString();
                    if (!httpHeader.HttpHeaderList.ContainsKey(key))
                    {
                        httpHeader.HttpHeaderList.Add(key, value);
                    }
                }
            }

            //PolicySetting
            var policy = new Setting.PolicyStruct
            {
                IsParamRandom = _checkBoxIsParamRandom.Checked == true
            };

            //ProxySetting
            var _isProxy = 0;
            if (_radioButtonNoProxy.Checked)
            {
                _isProxy = 0;
            }
            else if (_radioButtonIeProxy.Checked)
            {
                _isProxy = 1;
            }
            else if (_radioButtonCustomProxy.Checked)
            {
                _isProxy = 2;
            }
            var proxy = new Setting.ProxyStruct
            {
                IsNoOrIeOrCustomProxy = _isProxy,
                ProxyAddr = _textBoxProxyAddr.Text.Trim(),
                ProxyPort = _textBoxProxyPort.Text.Trim(),
                ProxyUser = _textBoxProxyUser.Text.Trim(),
                ProxyPassword = _textBoxProxyPasswd.Text.Trim(),
                ProxyDomain = _textBoxProxyDomain.Text.Trim()
            };

            var setting = new Setting(basic, userAgent, httpHeader, policy, proxy);
            // save Setting to xml
            InitWorker.SaveSettingToXml(AppEnvironment.AppPath, setting);
            // reinit GlobalSetting
            InitWorker.InitGlobalSetting(AppEnvironment.AppPath);
        }

        private void _buttonSaveSetting_Click(object sender, EventArgs e)
        {
            SaveSetting();
            Close();
        }

        private void _buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
