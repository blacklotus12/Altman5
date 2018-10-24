using System;
using System.Text;
using Altman.Controls;

namespace Plugin_ShellCmder
{
    public class InternalCommand
    {
        private ConsoleBox shellTextBoxCmder;
        private ShellCmder cmdshell;
        public InternalCommand(ConsoleBox shellTextBoxCmder, ShellCmder cmdshell)
        {
            this.shellTextBoxCmder = shellTextBoxCmder;
            this.cmdshell = cmdshell;
        }
        private void PrintCommandResult(string result)
        {
            shellTextBoxCmder.Invoke(new Action(() =>
            {
                shellTextBoxCmder.PrintCommandResult(result);
            }));
        }
        private void Cls()
        {
            shellTextBoxCmder.Invoke(new Action(() =>
            {
                shellTextBoxCmder.ClearContext();
            }));
        }
        private void Help()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("SECTool ShellCmder Demo");
            stringBuilder.Append(System.Environment.NewLine);
            stringBuilder.Append("*******************************************");
            stringBuilder.Append(System.Environment.NewLine);
            stringBuilder.Append("Commands Available");
            stringBuilder.Append(System.Environment.NewLine);
            stringBuilder.Append("sec       - view or edit settings");
            stringBuilder.Append(System.Environment.NewLine);
            stringBuilder.Append("history   - prints history of entered commands");
            stringBuilder.Append(System.Environment.NewLine);
            stringBuilder.Append("cls       - clears the screen");
            stringBuilder.Append(System.Environment.NewLine);

            PrintCommandResult(stringBuilder.ToString());
        }
        private void History()
        {
            string[] commands = shellTextBoxCmder.GetCommandHistory();
            StringBuilder stringBuilder = new StringBuilder(commands.Length);
            foreach (string s in commands)
            {
                stringBuilder.Append(s);
                stringBuilder.Append(System.Environment.NewLine);
            }
            PrintCommandResult(stringBuilder.ToString());
        }
        private void Sec()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Please Input More.Such As:");
            stringBuilder.Append(System.Environment.NewLine);
            stringBuilder.Append("Sec View");
            stringBuilder.Append(System.Environment.NewLine);
            stringBuilder.Append("Sec Set [oldSettingName] [newSetting]");
            stringBuilder.Append(System.Environment.NewLine);
            PrintCommandResult(stringBuilder.ToString());
        }
        private void SecView()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Basic configuration information");
            stringBuilder.Append(System.Environment.NewLine);
            stringBuilder.Append("*******************************************");
            stringBuilder.Append(System.Environment.NewLine);
            stringBuilder.Append("shellUrl      ->  " + cmdshell.ShellUrl);
            stringBuilder.Append(System.Environment.NewLine);
            stringBuilder.Append("shellPwd      ->  " + cmdshell.ShellPwd);
            stringBuilder.Append(System.Environment.NewLine);
            stringBuilder.Append("shellType     ->  " + cmdshell.ShellType);
            stringBuilder.Append(System.Environment.NewLine);
            stringBuilder.Append("shellCoding   ->  " + cmdshell.ShellCoding);
            stringBuilder.Append(System.Environment.NewLine);
            stringBuilder.Append("shellTimeOut  ->  " + cmdshell.ShellTimeOut);
            stringBuilder.Append(System.Environment.NewLine);
            PrintCommandResult(stringBuilder.ToString());
        }
        private void SecSet(string oldSettingName, string newSetting)
        {
            bool flag = false;
            if (oldSettingName == "shellurl")
            {
                cmdshell.ShellUrl = newSetting;
                flag = true;
            }
            else if (oldSettingName == "shellpwd")
            {
                cmdshell.ShellPwd = newSetting;
                flag = true;
            }
            else if (oldSettingName == "shelltype")
            {
                cmdshell.ShellType=newSetting;
                flag = true;
            }
            else if (oldSettingName == "shellcoding")
            {
                cmdshell.ShellCoding = newSetting;
                flag = true;
            }
            else if (oldSettingName == "shelltimetype")
            {
                cmdshell.ShellTimeOut = int.Parse(newSetting);
                flag = true;
            }
            if (flag)
            {
                PrintCommandResult("Set success");
            }
            else
            {
                PrintCommandResult("Set failed");
            }
        }
        private void Setp(string cmdPath = "")
        {
            if (string.IsNullOrEmpty(cmdPath))
            {
                var path = shellTextBoxCmder.IsWin ? "c:\\windows\\system32\\cmd.exe" : "/bin/sh";
                var strShow = $"Current Shell Path: {cmdshell.CmdPath ?? path}";
                PrintCommandResult(strShow);
            }
            else
            {
                cmdshell.CmdPath = cmdPath;
                PrintCommandResult($"Set Shell Path: {cmdPath}");
            }
        }
        /// <summary>
        /// 内部命令
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public bool ProcessInternalCommand(string cmd)
        {
            cmd = cmd.ToLower();
            if (cmd=="cls")
            {
                Cls();
            }
            else if (cmd == "help")
            {
                Help();
            }
            else if (cmd == "history")
            {
                History();
            }
            else if (cmd.StartsWith("setp"))
            {
                var parts = cmd.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2)
                {
                    Setp(parts[1]);
                }
                else
                {
                    Setp();
                }
            }
            else if (cmd.StartsWith("sec"))
            {
                string[] parts = cmd.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length ==2 &&parts[1] == "view")
                {
                    SecView();
                }
                else if (parts.Length == 4)
                {
                    SecSet(parts[2], parts[3]);
                }
                else
                {
                    Sec();
                }
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
