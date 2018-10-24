using System.Drawing;

namespace Plugin_FileManager.Resources
{
	public static class Icons
	{
		public static string Prefix = "Properties.Resource.FileIcons.";
		public static class TreeType
		{
			public static Image DriveIcon
			{
				get { return Image.FromHbitmap(Altman.Properties.Resources.drive.ToBitmap().GetHbitmap()); }
			}
			public static Image FolderIcon
			{
				get { return Image.FromHbitmap(Altman.Properties.Resources.floder.ToBitmap().GetHbitmap()); }
            }
		}

		public static class FileType
		{
			public static Image GetIcon(string name)
			{
				//Icon ico = Altman.Properties.Resources.ResourceManager.GetObject(name, Altman.Properties.Resources.Culture) as Icon;
                var img = GetResource.GetImage(name);
                if (img == null)
                {
                    img = GetResource.GetImage("_0_unknow_32");
                }

                return img;
			}
		}

        public static class Database
        {
            public static Image DatabaseStartIcon
            {
                get { return GetResource.GetImage("_0.database_start"); }
            }
            public static Image DatabaseFailedIcon
            {
                get { return GetResource.GetImage("_1.database_failed.ico"); }
            }
            public static Image DatabaseIcon
            {
                get { return GetResource.GetImage("_2.database.ico"); }
            }
            public static Image TableIcon
            {
                get { return GetResource.GetImage("_3.table.ico"); }
            }
            public static Image TableFailedIcon
            {
                get { return GetResource.GetImage("_4.table_failed.ico"); }
            }
            public static Image ColumnIcon
            {
                get { return GetResource.GetImage("_5.column.ico"); }
            }
        }

        public static class GetResource
        {
            public static Image GetImage(string name)
            {
                var ico = Altman.Properties.Resources.ResourceManager.GetObject(name, Altman.Properties.Resources.Culture) as Icon;

                return ico == null ? null : Image.FromHbitmap(ico.ToBitmap().GetHbitmap());
            }
        }
    }
}
