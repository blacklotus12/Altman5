using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Altman.Webshell.Model;
using Plugin_FileManager;
using Plugin_FileManager.Model;
using Altman.Util.Common.AltData;
using System.IO;
using Altman.Util.Common.AltEventArgs;
using System.Drawing;

namespace Altman.Forms
{
    public partial class PageFileManager : UserControl
    {
        private FormMain _mainForm;
        private Shell _shellData;
        private FileManager _fileManager;

        private bool _isWin;
        private string _oldName;
        private string[] _oldFiles;
        private string _oldTime;

        private string _pathSeparator;
        private string _currentDirPath;
        private string _requestDirPath;
        private FileInfoView _copyFileInfo;

        private TreeNode _fullNode;
        private BindingCollection<FileInfoView> _dataStore;

        private List<string> _commonPath = new List<string>
        {
            "C:\\Documents and Settings\\All Users\\",
            "C:\\RECYCLER\\",
            "C:\\ProgramData\\",
            "C:\\WINDOWS\\system32\\",
            "C:\\WINDOWS\\temp\\",
            "C:\\Program Files\\",
            "C:\\Documents and Settings\\",
            "C:\\Users\\Public\\",
            "/tmp/"
        };
        public PageFileManager(FormMain mainForm, Shell shellData)
        {
            InitializeComponent();

            _mainForm = mainForm;
            _shellData = shellData;

            // init StrRes to translate string
            //StrRes.SetHost(_host);
            //Init();

            //
            _fileManager = new FileManager(_shellData);
            _fileManager.GetWwwRootPathCompletedToDo += fileManager_GetWwwRootPathCompletedToDo;
            _fileManager.GetFileTreeCompletedToDo += fileManager_GetFileTreeCompletedToDo;
            _fileManager.DeleteFileOrDirCompletedToDo += fileManager_DeleteFileOrDirCompletedToDo;
            _fileManager.RenameFileOrDirCompletedToDo += fileManager_RenameFileOrDirCompletedToDo;
            _fileManager.CopyFileOrDirCompletedToDo += fileManager_CopyFileOrDirCompletedToDo;
            _fileManager.ModifyFileOrDirTimeCompletedToDo += fileManager_ModifyFileOrDirTimeCompletedToDo;
            _fileManager.CreateDirCompletedToDo += fileManager_CreateDirCompletedToDo;
            _fileManager.WgetCompletedToDo += fileManager_WgetCompletedToDo;
            _fileManager.UpdateUIDelegate += ShowMsgInStatusBar;

            _gridViewFile.AutoGenerateColumns = false;
            _gridViewFile.DataSource = _dataStore = new BindingCollection<FileInfoView>();

            //获取根路径
            _fileManager.GetWwwRootPath();

            _gridViewFile.DoubleBufferedDataGirdView(true);

            //清除自动选中第一行
            _gridViewFile.DataBindingComplete += (s, e) => { _gridViewFile.ClearSelection(); };
            _gridViewFile.Sorted += (s, e) => { _gridViewFile.ClearSelection(); };

            //fill data to ComboBox
            _cbCurrentPath.Items.AddRange(_commonPath.ToArray());
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

        #region ServiceCompletedToDo
        private void fileManager_GetWwwRootPathCompletedToDo(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowMsgInStatusBar("", false);
            if (e.Error != null)
            {
                ShowMsgInStatusBar(e.Error.Message, false);
            }
            else if (e.Result is OsDisk)
            {
                OsDisk disk = (OsDisk)e.Result;
                string shellDir = disk.ShellDir;
                string[] drives;
                if (disk.AvailableDisk == "/")
                {
                    _isWin = false;
                    drives = new string[] { "/" };
                }
                else
                {
                    _isWin = true;
                    drives = disk.AvailableDisk.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                }
                //设置路径分隔符
                _pathSeparator = _treeViewDirs.PathSeparator = _isWin ? "\\" : "/";
                shellDir = shellDir.Replace("/", _pathSeparator).Replace("\\", _pathSeparator);
                _currentDirPath = _cbCurrentPath.Text = shellDir + (shellDir.EndsWith(_pathSeparator) ? "" : _pathSeparator);
                if(!_cbCurrentPath.Items.Contains(_currentDirPath))
                    _cbCurrentPath.Items.Insert(0, _currentDirPath);
                //SetCurrentDirPath(shellDir);
                ShowMsgInStatusBar("Connect success");

                ShowWwwRootDir(_treeViewDirs, drives, shellDir, _isWin);
            }
        }

        private void fileManager_GetFileTreeCompletedToDo(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowMsgInStatusBar("", false);
            if (e.Error != null)
            {
                ShowMsgInStatusBar(e.Error.Message);
            }
            else if (e.Result is List<OsFile>)
            {
                var filetree = e.Result as List<OsFile>;
                var files = new List<OsFile>();
                var dirs = new List<OsFile>();
                foreach (var file in filetree)
                {
                    if (file.FileName.EndsWith("/"))
                        dirs.Add(file);
                    else
                        files.Add(file);
                }
                //success get dir. so current path change.
                if (!string.IsNullOrEmpty(_requestDirPath))
                { 
                    _currentDirPath = _cbCurrentPath.Text =  _requestDirPath;
                    if (!_cbCurrentPath.Items.Contains(_requestDirPath))
                        _cbCurrentPath.Items.Insert(0, _requestDirPath);
                }

                ShowMsgInStatusBar($"Folders[{dirs.Count}] Files[{files.Count}]");
                ShowFilesAndDirs(_fullNode, dirs, files, _isWin);
            }
        }

        private void fileManager_DeleteFileOrDirCompletedToDo(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowMsgInStatusBar("", false);
            if (e.Error != null)
            {
                ShowMsgInStatusBar(e.Error.Message);
            }
            else if (e.Result is bool)
            {
                if (!(bool)e.Result)
                {
                    var msg = "Failed to delete";
                    ShowMsgInStatusBar(msg);
                    ShowMsgInAppDialog(msg);
                }
                _fileManager.GetFileTree(_currentDirPath);
            }
        }

        private void fileManager_RenameFileOrDirCompletedToDo(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowMsgInStatusBar("", false);
            if (e.Error != null)
            {
                ShowMsgInStatusBar(e.Error.Message);
            }
            else if (e.Result is bool)
            {
                if (!(bool)e.Result)
                {
                    var msg = "Failed to rename";
                    ShowMsgInStatusBar(msg);
                    ShowMsgInAppDialog(msg);
                }
                ShowMsgInAppDialog("Rename success");

                _fileManager.GetFileTree(_currentDirPath);
            }
        }

        private void fileManager_CopyFileOrDirCompletedToDo(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowMsgInStatusBar("", false);
            if (e.Error != null)
            {
                ShowMsgInStatusBar(e.Error.Message);
            }
            else if (e.Result is bool)
            {
                if (!(bool)e.Result)
                {
                    var msg = "Failed to copy file";
                    ShowMsgInStatusBar(msg);
                    ShowMsgInAppDialog(msg);
                }
                _fileManager.GetFileTree(_currentDirPath);
            }
        }

        private void fileManager_CreateDirCompletedToDo(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowMsgInStatusBar("", false);
            if (e.Error != null)
            {
                ShowMsgInStatusBar(e.Error.Message);
            }
            else if (e.Result is bool)
            {
                if (!(bool)e.Result)
                {
                    var msg = "Failed to create the folder";
                    ShowMsgInStatusBar(msg);
                    ShowMsgInAppDialog(msg);
                }
                _fileManager.GetFileTree(_currentDirPath);
            }
        }

        private void fileManager_ModifyFileOrDirTimeCompletedToDo(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowMsgInStatusBar("", false);
            if (e.Error != null)
            {
                ShowMsgInStatusBar(e.Error.Message);
            }
            else if (e.Result is bool)
            {
                if (!(bool)e.Result)
                {
                    var msg = "Failed to modify file's time";
                    ShowMsgInStatusBar(msg);
                    ShowMsgInAppDialog(msg);
                }
                _fileManager.GetFileTree(_currentDirPath);
            }
        }

        private void fileManager_WgetCompletedToDo(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowMsgInStatusBar("", false);
            if (e.Error != null)
            {
                ShowMsgInStatusBar(e.Error.Message);
            }
            else if (e.Result is bool)
            {
                string msg = string.Empty;
                if (!(bool)e.Result)
                {
                    msg = "Download file to the remote server:Failed";
                }
                else
                {
                    msg = "Download file to the remote server:Succeed";
                }
                ShowMsgInStatusBar(msg);
                ShowMsgInAppDialog(msg);

                _fileManager.GetFileTree(_currentDirPath);
            }
        }

        private void upload_UploadFileProgressChangedToDo(object sender, AltProgressChangedEventArgs e)
        {
            //ControlProgressBar progressBar = e.UserState as ControlProgressBar;
            //progressBar.Value = e.ProgressPercentage;
        }
        private void upload_UploadFileCompletedToDo(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowMsgInStatusBar("", false);
            if (e.Error != null)
            {
                //ShowResultInProgressBar(false, e);
                ShowMsgInStatusBar(e.Error.Message);
            }
            else if (e.Result is bool)
            {
                string msg = string.Empty;
                if (!(bool)e.Result)
                {
                    msg = "Failed to upload file";
                }
                else
                {
                    msg = "Upload file succeed";
                }
                ShowMsgInStatusBar(msg);
                ShowMsgInAppDialog(msg);

                //ShowResultInProgressBar(true, e);
                _fileManager.GetFileTree(_currentDirPath);
            }
        }

        private void download_DownloadFileProgressChangedToDo(object sender, AltProgressChangedEventArgs e)
        {
            //ShowPercentageInProgressBar(e);
        }
        private void download_DownloadFileCompletedToDo(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowMsgInStatusBar("", false);
            if (e.Error != null)
            {
                //ShowResultInProgressBar(false, e);
                ShowMsgInStatusBar(e.Error.Message);
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                //ShowResultInProgressBar(true,e);
                string msg = "Download file succeed";
                ShowMsgInStatusBar(msg);
            }
        }
        #endregion

        #region Refresh UI
        private void ShowWwwRootDir(TreeView treeView, IEnumerable<string> driveNames, string wwwRootDirPath, bool isWin)
        {
            treeView.ImageList = imageList1;
            _fullNode = new TreeNode();
            foreach (var drive in driveNames)
            {
                TreeNode rootNode = new TreeNode
                {
                    Tag = drive,
                    Text = drive,
                    ImageIndex = 0
                };
                _fullNode.Nodes.Add(rootNode);
            }
            var foot = AddDirInDirTree(_fullNode, wwwRootDirPath, isWin);

            foreach (TreeNode node in _fullNode.Nodes)
            {
                treeView.Nodes.Add(node);
            }
            treeView.ExpandAll();

            // refresh
            //new Actions.ItemRefresh(_status).Execute();
            _fileManager.GetFileTree(_currentDirPath);
        }

        private void AddDrivesInDirTree(TreeNode TreeNode, IEnumerable<string> driveNames)
        {
            foreach (var drive in driveNames)
            {
                var tmp = new TreeNode
                {
                    Text = drive,
                    //Image = Icons.TreeType.DriveIcon
                };
                TreeNode.Nodes.Add(tmp);
            }
        }

        private TreeNode AddDirInDirTree(TreeNode TreeNode, string dirFullPath, bool isWin)
        {
            var result = ConvertTreePathToTreeNode(TreeNode, dirFullPath, isWin);
            if (result.Item2 == null)
            {
                return result.Item1;
            }
            else
            {
                var tmp = result.Item1;
                var dirsList = result.Item2;
                var index = 0;

                while (index < dirsList.Count)
                {
                    var tmpNodeName = dirsList[index];

                    TreeNode find = null;
                    foreach(TreeNode node in tmp.Nodes)
                    {
                        if (node.Text == tmpNodeName)
                        {
                            find = node;
                            break;
                        }
                    }
                    if (find == null)
                    {
                        var newItem = new TreeNode
                        {
                            Text = tmpNodeName,
                            ImageIndex = 1
                            //Image = Icons.TreeType.FloderIcon
                        };
                        tmp.Nodes.Add(newItem);
                        tmp = newItem;
                    }
                    else
                    {
                        tmp = find;
                    }
                    index++;
                }
                return tmp;
            }
        }

        private TreeNode FindDirInDirTree(TreeNode TreeNode, string dirFullPath, bool isWin)
        {
            var result = ConvertTreePathToTreeNode(TreeNode, dirFullPath, isWin);
            return result.Item2 == null ? result.Item1 : null;
        }

        private Tuple<TreeNode, List<string>> ConvertTreePathToTreeNode(TreeNode TreeNode, string dirFullPath, bool isWin)
        {
            var pathsList = dirFullPath.Split(new[] { '/', '\\' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            if (!isWin)
                pathsList.Insert(0, "/");

            TreeNode tmp = TreeNode;
            int index = 0;
            while (index < pathsList.Count)
            {
                string tmpNodeName = pathsList[index];

                TreeNode find = null;
                foreach (TreeNode node in tmp.Nodes)
                {
                    if (node.Text == tmpNodeName)
                    {
                        find = node;
                        break;
                    }
                }
                if (find == null)
                {
                    pathsList.RemoveRange(0, index);
                    return new Tuple<TreeNode, List<string>>(tmp, pathsList);
                }
                else
                    tmp = find;
                index++;
            }
            return new Tuple<TreeNode, List<string>>(tmp, null);
        }

        private TreeNode AddSubDirsInDirTree(TreeNode TreeNode, IEnumerable<string> subDirNames, string currentDirFullPath, bool isWin)
        {
            var selectedNode = FindDirInDirTree(TreeNode, currentDirFullPath, isWin);
            if (selectedNode != null)
            {
                foreach (var dir in subDirNames)
                {
                    //var find = selectedNode.Children.FirstOrDefault(r => r.Text == dir) as TreeNode;
                    TreeNode find = null;
                    foreach (TreeNode node in selectedNode.Nodes)
                    {
                        if (node.Text == dir)
                        {
                            find = node;
                            break;
                        }
                    }
                    if (find == null)
                    {
                        var newItem = new TreeNode
                        {
                            Text = dir,
                            ImageIndex = 1
                            //Image = Icons.TreeType.FloderIcon
                        };
                        selectedNode.Nodes.Add(newItem);
                    }
                }
            }
            return selectedNode;
        }

        private void ShowFilesAndDirs(TreeNode TreeNode, List<OsFile> dirs, List<OsFile> files, bool isWin)
        {
            //show dirs in DirTree
            var newDirs = dirs.Select(dir => dir.FileName.Remove(dir.FileName.Length - 1, 1)).ToList();
            var currentDir = _currentDirPath;
            var selectedNode = AddSubDirsInDirTree(TreeNode, newDirs, currentDir, isWin);
            if (selectedNode == null)
                return;

            //show dirs,files in fileview
            AddDirsInListViewFile(dirs, files, currentDir);

            //expanded
            selectedNode.Expand();// = true;
            //_treeViewDir.RefreshItem(selectedNode);
        }

        private void AddDirsInListViewFile(IEnumerable<OsFile> dirs, IEnumerable<OsFile> files, string parentPath)
        {
            _dataStore.Clear();

            var item = new List<FileInfoView>();
            //显示dirs
            foreach (OsFile dir in dirs)
            {
                //移除最后的'/'符号
                string dirName = dir.FileName.Remove(dir.FileName.Length - 1, 1);
                //添加fileInfo
                string fullName = Path.Combine(new string[] { parentPath, dirName }) + (_isWin ? "\\" : "/");
                item.Add(new FileInfoView(dirName, fullName, true, dir.FileMTime, dir.FileSize, dir.FilePerms));
            }
            //显示files
            foreach (OsFile file in files)
            {
                //添加fileInfo
                string dirName = file.FileName;
                string fullName = Path.Combine(new string[] { parentPath, dirName });
                item.Add(new FileInfoView(dirName, fullName, false, file.FileMTime, file.FileSize, file.FilePerms));
            }
            _dataStore = new BindingCollection<FileInfoView>(item);
            
            _gridViewFile.DataSource = _dataStore;
            _gridViewFile.AutoGenerateColumns = false;
            _gridViewFile.Refresh();
        }

        private string getTreeViewSelectedFullPath()
        {
            var path = string.Empty;
            if (_treeViewDirs.SelectedNode == null)
                return path;
            var treeItem = _treeViewDirs.SelectedNode;
            path = treeItem.Text;
            while ((treeItem = treeItem.Parent) != null && treeItem.Text != null)
            {
                path = treeItem.Text + _pathSeparator + path;
            }
            return path.StartsWith("//") ? path.Remove(0, 1) : path;
        }
        #endregion

        #region Button Event
        private void _buttonDir_Click(object sender, EventArgs e)
        {
            var path = _cbCurrentPath.Text;
            if (path != "")
            {
                path = path.Replace("/", _pathSeparator).Replace("\\", _pathSeparator);
                _requestDirPath = path + (path.EndsWith(_pathSeparator) ? "" : _pathSeparator);
                _fileManager.GetFileTree(_requestDirPath);
            }
        }

        private void _textboxUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _buttonDir.PerformClick();
                _cbCurrentPath.SelectionStart = _cbCurrentPath.Text.Length;
            }
        }

        #endregion 

        #region RightMenu Event
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fileManager.GetFileTree(_currentDirPath);
        }

        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();           
            var filter1 = "All files(*.*)|*.*";
            var filter2 = "Script Files(*.asp,*.aspx,*.php,*.jsp)|*.asp;*.aspx;*.php;*.jsp";
            var filter3 = "Program(*.exe,*.bat)|*.exe;*.bat";
            openFileDialog.Title = "Select File To Upload";
            openFileDialog.Filter = filter1 + "|" + filter2 + "|" + filter3;

            if (openFileDialog.ShowDialog(_gridViewFile) == DialogResult.OK)
            {
                string srcfile = openFileDialog.FileName;
                string currentDirPath = _currentDirPath;
                string fileName = Path.GetFileName(srcfile);
                string targetFilePath = Path.Combine(currentDirPath, fileName);
                try
                {
                    var upload = new FileUploadOrDownload(_shellData, srcfile, targetFilePath);
                    upload.UploadFileProgressChangedToDo += upload_UploadFileProgressChangedToDo;
                    upload.UploadFileCompletedToDo += upload_UploadFileCompletedToDo;
                    upload.StartToUploadFile();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_gridViewFile.SelectedRows.Count < 1) return;
            var selectFile = _gridViewFile.SelectedRows[0].DataBoundItem as FileInfoView;
            if (selectFile != null)
            {
                var webFile = selectFile.FullName;
                var name = Path.GetFileName(webFile);
                var saveFileDialog = new SaveFileDialog
                {
                    Title = "Save File As",
                    FileName = name
                };
                if (DialogResult.OK == saveFileDialog.ShowDialog(_gridViewFile))
                {
                    try
                    {
                        var download = new FileUploadOrDownload(_shellData, webFile, saveFileDialog.FileName);
                        download.DownloadFileProgressChangedToDo += download_DownloadFileProgressChangedToDo;
                        download.DownloadFileCompletedToDo += download_DownloadFileCompletedToDo;
                        download.StartToDownloadFile();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
        }

        private void wgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var wget = new FormWget(_currentDirPath);

            if (DialogResult.OK == wget.ShowDialog(_gridViewFile))
            {
                string urlPath = wget.UrlPath;
                string savePath = wget.SavePath;

                _fileManager.Wget(urlPath, savePath);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_gridViewFile.SelectedRows.Count < 1) return;
            var selectFile = _gridViewFile.SelectedRows[0].DataBoundItem as FileInfoView;
            if (selectFile != null && !selectFile.IsDir)
            {
                var webFile = selectFile.FullName;
                var fileEditer = new PageFileEditer(_mainForm, _shellData, webFile, true);
                _mainForm.CreateTabPage($"FileEdit|{_shellData.TargetId}", fileEditer);
            }
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_gridViewFile.SelectedRows.Count >= 1)
            {
                var row = _gridViewFile.SelectedRows[0];
                _gridViewFile.CurrentCell = row.Cells[1];
                _gridViewFile.BeginEdit(true);
            }
        }

        private void modiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_gridViewFile.SelectedRows.Count >= 1)
            {
                var row = _gridViewFile.SelectedRows[0];
                _gridViewFile.CurrentCell = row.Cells[2];
                _gridViewFile.BeginEdit(true);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_gridViewFile.SelectedRows.Count < 1) return;
            var selectFile = _gridViewFile.SelectedRows[0].DataBoundItem as FileInfoView;
            if (selectFile != null)
            {
                _copyFileInfo = selectFile;
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_currentDirPath)) return;
            if (_copyFileInfo != null)
            {
                var sourceFullName = _copyFileInfo.FullName;
                var targetFullName = _currentDirPath + _pathSeparator + _copyFileInfo.Name;
                if (targetFullName != sourceFullName)
                {
                    _fileManager.CopyFileOrDir(sourceFullName, targetFullName);
                    //clear
                    _copyFileInfo = null;
                }
            }
        }

        private void folderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var newItem = new FileInfoView("NewFolder", "NewFolder", true, time, "0", "0777")
            {
                IsCreateing = true
            };

            _dataStore.Add(newItem);
            //_gridViewFile.Rows.Add(newItem);
            _gridViewFile.Refresh();
            
            var row = _dataStore.IndexOf(newItem);
            _gridViewFile.CurrentCell = _gridViewFile.Rows[_gridViewFile.Rows.Count-1].Cells[1];
            _gridViewFile.BeginEdit(true);
            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newFile = _currentDirPath + _pathSeparator + "NewFile.txt";
            var fileEditer = new PageFileEditer(_mainForm, _shellData, newFile, false);
            _mainForm.CreateTabPage($"FileEdit|{_shellData.TargetId}", fileEditer);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_gridViewFile.SelectedRows.Count < 1) return;
            var selectFile = _gridViewFile.SelectedRows[0].DataBoundItem as FileInfoView;
            if (selectFile != null)
            {
                var msg = string.Format("Will delete {0}, to continue?", selectFile.Name);
                var result = MessageBox.Show(this, msg, "Delete File", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;

                string webDir = selectFile.FullName;
                //提前删除文件夹节点，如果删除失败可能会影响(待解决)
                //RemoveDirInDirTree(treeView_Dirs, webDir, _isWin);
                _fileManager.DeleteFileOrDir(webDir);

                //var item = _status.FileGridView.DataStore as DataStoreCollection;
                //item.RemoveAt(1);
            }
        }
        #endregion

        #region TreeView Event
        private void _treeViewDirs_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView tree = sender as TreeView;

            if (tree != null)
            {
                var path = tree.SelectedNode.FullPath;
                path = path.Replace("/",_pathSeparator).Replace("\\", _pathSeparator);
                _requestDirPath = path + (path.EndsWith(_pathSeparator) ? "" : _pathSeparator);
                //SetCurrentDirPath(path);
                _fileManager.GetFileTree(_requestDirPath);
            }
        }
        #endregion

        #region GridView Event
        private void _gridViewFile_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_gridViewFile.SelectedRows.Count < 1 || e.RowIndex < 0) return;
            //var selectFile = _dataStore[e.RowIndex];
            var selectFile = _gridViewFile.SelectedRows[0].DataBoundItem as FileInfoView;
            if (selectFile != null && selectFile.IsDir)
            {
                var path = selectFile.FullName;
                path = path.Replace("/", _pathSeparator).Replace("\\", _pathSeparator);
                _requestDirPath = path + (path.EndsWith(_pathSeparator) ? "" : _pathSeparator);
                _fileManager.GetFileTree(_requestDirPath);
            }
        }
        private void _gridViewFile_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var gridView = sender as DataGridView;
            if (gridView == null)
                return;
            _oldName = _dataStore[e.RowIndex].Name;
            _oldFiles = _dataStore.Select(r => r.Name).ToArray();
            _oldTime = _dataStore[e.RowIndex].FileMTime;
        }

        private void _gridViewFile_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {         
            var gridView = sender as DataGridView;
            var editFile = gridView.Rows[e.RowIndex].DataBoundItem as FileInfoView;
            // winform: sometimes doubleclick in editing cell also trigger CellEdited event
            if (gridView == null || editFile == null)
                return;
            
            if (e.ColumnIndex == 1) //edit name
            {
                if (editFile.IsCreateing) //create dir
                {
                    var newText = editFile.Name;
                    if (string.IsNullOrEmpty(newText) || newText == _oldName)
                    {
                        Undo(e.RowIndex, _oldName, EditType.CreateDir);
                        return;
                    }
                    if (_oldFiles.FirstOrDefault(r => r == newText) != null)
                    {
                        MessageBox.Show("This name already exists, please rename");
                        Undo(e.RowIndex, _oldName, EditType.CreateDir);
                        return;
                    }
                    //创建文件夹
                    var currentDir = _currentDirPath;
                    string dirName = newText;
                    string dirFullPath = currentDir + _pathSeparator + dirName;
                    _fileManager.CreateDir(dirFullPath);
                }
                else //rename
                {
                    var newText = editFile.Name;
                    if (string.IsNullOrEmpty(newText) || newText == _oldName)
                    {
                        Undo(e.RowIndex, _oldName, EditType.Rename);
                        return;
                    }
                    if (_oldFiles.FirstOrDefault(r => r == newText) != null)
                    {
                        MessageBox.Show("This name already exists, please rename");
                        Undo(e.RowIndex, _oldName, EditType.Rename);
                        return;
                    }
                    //发送重命名请求
                    //oldFileName,newFileName
                    //为了安全起见，这里使用绝对路径
                    var currentDir = _currentDirPath;
                    string oldFileName = _oldName;
                    string newFileName = newText;
                    string oldFileNameFullPath = currentDir + _pathSeparator + oldFileName;
                    string newFileNameFullPath = currentDir + _pathSeparator + newFileName;
                    _fileManager.RenameFileOrDir(oldFileNameFullPath, newFileNameFullPath);
                }
            }
            else if (e.ColumnIndex == 2)//edit mtime
            {
                var newText = editFile.FileMTime;
                if (string.IsNullOrEmpty(newText) || newText == _oldTime)
                {
                    Undo(e.RowIndex, _oldTime, EditType.EditMTime);
                    return;
                }
                if (!DateTime.TryParse(newText, out DateTime result))
                {
                    MessageBox.Show("This time's format is error, please retry");
                    Undo(e.RowIndex, _oldTime, EditType.EditMTime);
                    return;
                }
                //修改时间
                _fileManager.ModifyFileOrDirTime(editFile.FullName, newText);
            }
        }
        enum EditType
        {
            Rename,
            EditMTime,
            CreateDir
        }
        void Undo(int row, string oldText, EditType editType)
        {
            if (editType == EditType.Rename)
            {
                _dataStore[row].Name = oldText;
                //((List<FileInfoView>) dataStore)[row].Name = oldText;
            }
            else if (editType == EditType.EditMTime)
            {
                _dataStore[row].FileMTime = oldText;
                //((List<FileInfoView>) dataStore)[row].FileMTime = oldText;
            }
            else if (editType == EditType.CreateDir)
            {
                _dataStore.RemoveAt(row);
                //Application.Instance.Invoke(() =>((DataStoreCollection)dataStore).RemoveAt(row));
            }

            _gridViewFile.DataSource = _dataStore;
            _gridViewFile.Refresh();
        }

        private void _gridViewFile_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    _gridViewFile.ClearSelection();
                    _gridViewFile.Rows[e.RowIndex].Selected = true;
                    _gridViewFile.CurrentCell = _gridViewFile.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    this._rightMenuFile.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void _gridViewFile_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point clickPoint = new Point(e.X, e.Y);
                this._rightMenuBlank.Show(MousePosition.X, MousePosition.Y);
            }
        }
        #endregion
    }
}
