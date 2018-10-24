using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plugin_FileManager;
using Altman.Webshell.Model;

namespace Altman
{
    public partial class PageFileEditer : UserControl
    {
        string Body
        {
            get { return _textAreaBody.Text; }
            set { _textAreaBody.Text = value; }
        }
        string Url
        {
            get { return _textBoxUrl.Text; }
            set { _textBoxUrl.Text = value; }
        }

        private FormMain _mainForm;
        private Shell _shellData;
        private FileManager _fileManager;
        public PageFileEditer(FormMain mainForm, Shell shellData, string filePath, bool autoLoadContent)
        {
            InitializeComponent();

            _mainForm = mainForm;
            _shellData = shellData;

            _fileManager = new FileManager(_shellData);
            _fileManager.ReadFileCompletedToDo += fileManager_LoadFileContentCompletedToDo;
            _fileManager.WriteFileCompletedToDo += fileManager_SaveFileCompletedToDo;

            if (filePath != null)
            {
                Url = filePath;
                if (autoLoadContent)
                    LoadFileContent(filePath);
            }

            _panelSearch.Visible = false;
            if (!_panelSearch.Visible)
            {
                _textAreaBody.Height += 28;
            }
        }

        private void ShowMsgInStatusBar(string msg, bool? isShowLoadingIcon = null)
        {
            _mainForm.Invoke(new Action(() =>
            {
                _mainForm.MsgInStatusBar = msg;
                if (isShowLoadingIcon ?? true) return;
                if (isShowLoadingIcon.HasValue && isShowLoadingIcon.Value)
                    _mainForm.ShowLoadingInStatusBar();
                else
                    _mainForm.HideLoadingInStatusBar();
            }));
        }

        public void ShowMsgInAppDialog(string msg)
        {
            MessageBox.Show(_mainForm, msg, "Message");
        }

        #region Event
        /// <summary>
        /// 载入完成事件
        /// </summary>
        void fileManager_LoadFileContentCompletedToDo(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowMsgInStatusBar("", false);
            if (e.Error != null)
            {
                ShowMsgInStatusBar(e.Error.Message);
            }
            else
            {
                string msg;
                if (e.Result is string)
                {
                    msg = "Load file success";

                    var content = e.Result as string;
                    Body = content;
                    _textAreaBody.Focus();
                    _textAreaBody.SelectionStart = 0;
                }
                else
                {
                    msg = "Load file success";
                }

                ShowMsgInStatusBar(msg);
            }
        }

        /// <summary>
        /// 保存文件完成事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void fileManager_SaveFileCompletedToDo(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowMsgInStatusBar("", false);
            if (e.Error != null)
            {
                ShowMsgInStatusBar(e.Error.Message);
            }
            else
            {
                string msg;
                if ((bool)e.Result)
                {
                    msg = "Save file success";
                }
                else
                {
                    msg = "Save file failed";
                }

                ShowMsgInAppDialog(msg);
                ShowMsgInStatusBar(msg);
            }
        }
        #endregion

        public void LoadFileContent(string filePath)
        {
            Body = "loading";
            _fileManager.ReadFile(filePath);
        }

        public void SaveFileContent(string filePath, string fileData)
        {
            _fileManager.WriteFile(filePath, fileData);
        }

        private void _buttonReadFile_Click(object sender, EventArgs e)
        {

        }
        private void _buttonSaveFile_Click(object sender, EventArgs e)
        {
            if (Url != null)
            {
                SaveFileContent(Url, Body);
            }
            else
            {
                MessageBox.Show("the url is null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void _textAreaBody_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers.CompareTo(Keys.Control) == 0 && e.KeyCode == Keys.F)
            {
                _panelSearch.Visible = !_panelSearch.Visible;
                if (_panelSearch.Visible)
                {
                    _textSearch.Focus();
                    _textAreaBody.Height -= 28;
                }else
                    _textAreaBody.Height += 28;

            }
        }

        private void _textSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && _panelSearch.Visible == true && !string.IsNullOrWhiteSpace(_textSearch.Text))
            {
                string searchText;
                var isUp = false;
                var caseSensitive = _checkCaseSensitive.Checked;
                var findContent = _textSearch.Text.Trim();
                var curIndex = _textAreaBody.SelectionStart;

                if (_textAreaBody.SelectedText.Length < 0)
                {
                    _textAreaBody.SelectionStart = 0;
                }
                // pre
                if (isUp)
                {
                    searchText = _textAreaBody.Text.Substring(0, curIndex);
                }
                else
                {
                    curIndex += _textAreaBody.SelectedText.Length;
                    searchText = _textAreaBody.Text.Substring(curIndex);
                }

                if (!caseSensitive)
                {
                    searchText = searchText.ToLower();
                    findContent = findContent.ToLower();
                }

                // find
                var index = isUp
                    ? searchText.LastIndexOf(findContent, StringComparison.Ordinal)
                    : searchText.IndexOf(findContent, StringComparison.Ordinal);
                if (index != -1)
                {
                    var selectionStart = isUp ? index : index + curIndex;
                    _textAreaBody.Select(selectionStart, findContent.Length);
                    _textAreaBody.Focus();

                    ShowMsgInStatusBar($"Find the text \"{findContent}\", start postion {selectionStart}");
                }
                else
                {
                    _textAreaBody.SelectionStart = 0;
                    ShowMsgInStatusBar($"Not Found \"{findContent}\" ");
                }
            }
        }
    }
}
