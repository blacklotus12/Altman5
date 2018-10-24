using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Altman.Webshell.Model;
using System.Threading;
using Plugin_ShellCmder;
using Altman.Util.Common.AltData;
using Altman.Controls;

namespace Altman.Forms
{
    public partial class PageShellCmder : UserControl
    {

        private FormMain _mainForm;
        private Shell _shellData;

        private ShellCmder _shellCmder;
        private InternalCommand _internalCommand;

        private bool _isWin;
        private string _currentDir;

        public PageShellCmder(FormMain mainForm, Shell shellData)
        {
            InitializeComponent();
            Init();

            _mainForm = mainForm;
            _shellData = shellData;

            ConnectOneShell();
        }

        private void Init()
        {
            _consoleBoxCmder.IsWin = true;
            _consoleBoxCmder.Prompt = ">>>";
            _consoleBoxCmder.ShellTextBackColor = Color.Black;
            _consoleBoxCmder.ShellTextForeColor = Color.FromArgb(192, 192, 192);
            _consoleBoxCmder.ShellTextFont = new Font(Font.FontFamily, 10, style: FontStyle.Bold);

            _consoleBoxCmder.CommandEntered += ConsoleBoxCmderCommandEntered;
            _consoleBoxCmder.Prompt = "AltmanCmder";
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

        private void ConsoleBoxCmderCommandEntered(object sender, ConsoleBox.CommandEnteredEventArgs e)
        {
            string command = e.Command;
            var thread = new Thread(() => ExecuteCmd(command));
            thread.SetApartmentState(ApartmentState.STA);
            thread.IsBackground = true;
            thread.Start();
        }

        private void ConnectOneShell()
        {
            try
            {
                //初始化ShellCmder
                _shellCmder = new ShellCmder(_shellData);
                //初始化内部命令
                _internalCommand = new InternalCommand(_consoleBoxCmder, _shellCmder);
                //获取系统信息
                var info = _shellCmder.GetSysInfo();
                var str = string.Format("{0}: {1}\n{2}: {3}",
                    "Platform",
                    info.Platform,
                    "CurrentUser",
                    info.CurrentUser);
                //设置系统平台
                _isWin = info.DirSeparators == @"\";
                //设置当前目录
                _currentDir = info.ShellDir;
                //cmder的系统平台
                _consoleBoxCmder.IsWin = _isWin;
                //设置提示信息
                _consoleBoxCmder.Prompt = _isWin ? _currentDir.Replace("/", "\\") : _currentDir.Replace("\\", "/");
                _consoleBoxCmder.PrintCommandResult(str);
                //
                _shellCmder.CmdPath = _isWin ? "cmd" : "/bin/sh";
                ShowMsgInStatusBar("Connect success");
            }
            catch (Exception ex)
            {
                _consoleBoxCmder.PrintCommandResult(ex.Message);
                ShowMsgInStatusBar("Connect failed");
            }
        }

        private void ExecuteCmd(string command)
        {
            if (!_internalCommand.ProcessInternalCommand(command))
            {
                try
                {
                    ShowMsgInStatusBar("Executing...", true);

                    if (_shellCmder != null)
                    {
                        CmdResult cmdResult = _shellCmder.ExecuteCmd("", command, _currentDir, _isWin);
                        //设置当前目录
                        _currentDir = cmdResult.CurrentDir;
                        //设置提示信息
                        _consoleBoxCmder.Invoke(new Action(() =>
                        {
                            _consoleBoxCmder.Prompt = _isWin ? _currentDir.Replace("/", "\\") : _currentDir.Replace("\\", "/"); ;
                            _consoleBoxCmder.PrintCommandResult(cmdResult.Result);
                        }));
                        ShowMsgInStatusBar("Execute success", false);
                    }
                }
                catch (Exception ex)
                {
                    _consoleBoxCmder.Invoke(new Action(() =>
                    {
                        _consoleBoxCmder.PrintCommandResult("[Error]:" + ex.Message);
                    }));
                    ShowMsgInStatusBar("Execute failed", false);
                }
            }
        }
    }
}
