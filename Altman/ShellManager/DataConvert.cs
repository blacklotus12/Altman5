using System.Data;
using Altman.Webshell.Model;

namespace Plugin_ShellManager.Data
{
    public class DataConvert
	{
		public static Shell ConvertDataRowToShellStruct(DataRow row)
		{
            Shell shell = new Shell
            {
                Id = row["id"].ToString(),
                TargetId = row["target_id"].ToString(),
                TargetLevel = row["target_level"].ToString(),
                Status = row["status"].ToString(),

                ShellUrl = row["shell_url"].ToString(),
                ShellPwd = row["shell_pwd"].ToString(),
                ShellType = row["shell_type"].ToString(),
                ShellExtraString = row["shell_extra_setting"].ToString(),
                ServerCoding = row["server_coding"].ToString(),
                WebCoding = row["web_coding"].ToString(),

                Area = row["area"].ToString(),
                Remark = row["remark"].ToString(),
                AddTime = row["add_time"].ToString()
            };

            return shell;
		}

		//public static PluginParameter ConvertShellStructToPluginParameter(Shell shell)
		//{
		//	var param = new PluginParameter();
		//	param.AddParameter("id", shell.Id);
		//	param.AddParameter("target_id", shell.TargetId);
		//	param.AddParameter("target_level", shell.TargetLevel);
		//	param.AddParameter("status", shell.Status);

		//	param.AddParameter("shell_url", shell.ShellUrl);
		//	param.AddParameter("shell_pwd", shell.ShellPwd);
		//	param.AddParameter("shell_type", shell.ShellType);
		//	param.AddParameter("shell_extra_setting", shell.ShellExtraString);
		//	param.AddParameter("server_coding", shell.ServerCoding);
		//	param.AddParameter("web_coding", shell.WebCoding);

		//	param.AddParameter("area", shell.Area);
		//	param.AddParameter("remark", shell.Remark);
		//	param.AddParameter("add_time", shell.AddTime);

		//	return param;
		//}
	}
}
