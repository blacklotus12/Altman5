using System.Collections.Generic;
using System.IO;

namespace Altman.Webshell.Core
{
    internal class XmlHelper
    {
        /// <summary>
        /// ����xml�ļ��б�
        /// </summary>
        public static List<string> LoadXMlList(string basePathDir, string extension)
        {
            List<string> xmlList = new List<string>();
            DirectoryInfo theFolder = new DirectoryInfo(basePathDir);
            FileInfo[] fileInfos = theFolder.GetFiles();
            //�����ļ���
            foreach (FileInfo file in fileInfos)
            {
                if (file.Name.EndsWith("." + extension))
                    xmlList.Add(file.Name);
            }
            return xmlList;
        }
    }
}