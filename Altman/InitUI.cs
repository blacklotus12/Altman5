using System;
using System.Windows.Forms;
using Altman.Util.Logic;
using Altman.Util.Setting;

namespace Altman
{
    internal class InitUi
    {
	    public static void InitCustomShellType(string customShellTypePath)
	    {
		    try
		    {
			    //初始化CustomShellType
				Altman.Webshell.InitWorker.RegisterCustomShellType(customShellTypePath);
		    }
		    catch (Exception ex)
		    {
			    MessageBox.Show(ex.Message);
		    }
	    }

	    public static void InitGlobalSetting(string settingXmlPath)
        { 
            try
            {
                //初始化GlobalSetting
				InitWorker.InitGlobalSetting(settingXmlPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
