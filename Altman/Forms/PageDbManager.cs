using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Plugin_DbManager;
using Altman.Webshell.Model;
using System.IO;
using System.Text;
using System.Drawing;

namespace Altman.Forms
{
    public partial class PageDbManager : UserControl
    {
        private FormMain _mainForm;
        private Shell _shellData;

        private struct ShellSqlConnection
        {
            public string type;
            public string conn;
        }

        private ShellSqlConnection _shellSqlConn;
        private DbManager _dbManager;
        private DataTable _dataTableResult;
        public PageDbManager(FormMain mainForm, Shell shellData)
        {
            InitializeComponent();

            _mainForm = mainForm;
            _shellData = shellData;

            _shellSqlConn = GetShellSqlConn();

            //绑定事件
            _dbManager = new DbManager(_shellData, _shellSqlConn.type);
            _dbManager.ConnectDbCompletedToDo += DbManagerConnectDbCompletedToDo;
            _dbManager.GetDbNameCompletedToDo += DbManagerGetDbNameCompletedToDo;
            _dbManager.GetDbTableNameCompletedToDo += DbManagerGetTableNameCompletedToDo;
            _dbManager.GetColumnTypeCompletedToDo += DbManagerGetColumnTypeCompletedToDo;
            _dbManager.ExecuteReaderCompletedToDo += DbManagerExecuteReaderCompletedToDo;
            _dbManager.ExecuteNonQueryCompletedToDo += DbManagerExecuteNonQueryCompletedToDo;

            RefreshServerStatus(false);


            if (string.IsNullOrEmpty(_shellSqlConn.type) || string.IsNullOrEmpty(_shellSqlConn.conn))
            {
                MessageBox.Show("shell's sqlConnection is null or space");
            }
            else
            {
                //连接数据库
                _dbManager.ConnectDb(_shellSqlConn.conn);
            }
        }

        private ShellSqlConnection GetShellSqlConn()
        {
            var res = Altman.Webshell.Service.GetShellSqlConnection(_shellData);
            return new ShellSqlConnection { type = res[0] ?? "", conn = res[1] ?? "" };
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

        #region ServiceCompletedToDo
        private void DbManagerExecuteNonQueryCompletedToDo(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                ShowMsgInStatusBar(e.Error.Message);
            }
            else if (e.Result is DataTable)
            {
                RefreshGridViewResult((e.Result as DataTable));
                ShowMsgInStatusBar((e.Result as DataTable).Rows[0][0].ToString());
            }
        }
        private void DbManagerExecuteReaderCompletedToDo(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                ShowMsgInStatusBar(e.Error.Message);
            }
            else if (e.Result is DataTable)
            {
                RefreshGridViewResult((e.Result as DataTable));

                ShowMsgInStatusBar(string.Format("{0} rows", (e.Result as DataTable).Rows.Count));
            }
        }
        private void DbManagerGetColumnTypeCompletedToDo(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                ShowMsgInStatusBar(e.Error.Message);

                //更改table为失败的图标
                //_treeViewDbs.SelectedItem.Image = Icons.Database.TableFailedIcon;
            }
            else if (e.Result is string[])
            {
                string[] columns = e.Result as string[];
                if (columns.Length > 0)
                {
                    RefreshColumnsInDbTree(_treeViewDbs.SelectedNode, columns);
                }
                ShowMsgInStatusBar(string.Format("{0} columns", columns.Length));
            }
        }
        private void DbManagerGetTableNameCompletedToDo(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                ShowMsgInStatusBar(e.Error.Message);

                //更改db为失败的图标
                //_treeViewDbs.SelectedItem.Image = Icons.Database.DatabaseFailedIcon;
            }
            else if (e.Result is string[])
            {
                var tables = e.Result as string[];
                if (tables.Length > 0)
                {
                    RefreshTablesInDbTree(_treeViewDbs.SelectedNode, tables);
                }
                ShowMsgInStatusBar(string.Format("{0} tables", tables.Length));
            }
        }
        private void DbManagerGetDbNameCompletedToDo(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                ShowMsgInStatusBar(e.Error.Message);
                //更改root为失败的图标
                RefreshRootInDbTree(false);
            }
            else if (e.Result is string[])
            {
                var dbs = e.Result as string[];
                if (dbs.Length > 0)
                {
                    RefreshDbsInDbTree(_treeViewDbs.SelectedNode, dbs);
                }
                ShowMsgInStatusBar(string.Format("{0} databases", dbs.Length));
            }
        }
        private void DbManagerConnectDbCompletedToDo(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                ShowMsgInStatusBar(e.Error.Message);
                //更改root为失败的图标
                RefreshRootInDbTree(false);
            }
            else if (e.Result is bool)
            {
                if ((bool)e.Result)
                {
                    ShowMsgInStatusBar("Connect Successed");
                    RefreshServerStatus(true);
                    RefreshRootInDbTree(true);
                }
                else
                {
                    ShowMsgInStatusBar("Connect Failed");
                    //更改root为失败的图标
                    RefreshRootInDbTree(false);
                }
            }
        }

        #endregion

        #region Refresh UI
        private void RefreshGridViewResult(DataTable dataTable)
        {
            int RowCount, ColCount, i, j;

            if (dataTable == null) return;
            RowCount = dataTable.Rows.Count;
            ColCount = dataTable.Columns.Count;

            _gridViewResult.Columns.Clear();
            foreach (var col in dataTable.Columns.Cast<DataColumn>())
            {
                _gridViewResult.Columns.Add(col.Caption.Trim(), 80, HorizontalAlignment.Left);
            }

            _gridViewResult.Items.Clear();
            if (RowCount == 0) return;
            for (i = 0; i < RowCount; i++)
            {
                var dr = dataTable.Rows[i];
                var lvi = new ListViewItem(dr[0].ToString().Trim());
                for (j = 1; j < ColCount; j++)
                {
                    lvi.SubItems.Add(dr[j].ToString().Trim());
                }

                _gridViewResult.Items.Add(lvi);
            }


            //var tmp = dataTable.Rows.Cast<DataRow>().Select(x => x.ItemArray.Select(y => y.ToString()).ToArray());
            //_gridViewResult.DataStore = tmp;

            _dataTableResult = dataTable;
        }
        private void RefreshServerStatus(bool isConnected)
        {
            if (isConnected)
            {
                _buttonConnect.Enabled = false;
                _buttonDisconnect.Enabled = true;
            }
            else
            {
                _buttonConnect.Enabled = true;
                _buttonDisconnect.Enabled = false;
            }
        }
        private void RefreshRootInDbTree(bool isSuccess)
        {
            _treeViewDbs.ImageList = imageList1;
            var rootnode = new TreeNode
            {
                Text = "(local)",
                Tag = "root",
                ImageIndex = isSuccess ? 0 : 1
            };
            _treeViewDbs.Nodes.Clear();
            _treeViewDbs.Nodes.Add(rootnode);
        }
        private void RefreshDbsInDbTree(TreeNode selected, string[] dbs)
        {
            selected.Nodes.Clear();
            foreach (var db in dbs)
            {
                var node = new TreeNode
                {
                    Text = db,
                    Tag = "db",
                    ImageIndex = 2
                };
                selected.Nodes.Add(node);
            }
            selected.Expand();
            //_treeViewDbs.RefreshItem(selected);
            //刷新数据库选择框
            _dropDownDbs.Items.Clear();
            _dropDownDbs.Items.AddRange(dbs);
        }
        private void RefreshTablesInDbTree(TreeNode selected, string[] tables)
        {
            selected.Nodes.Clear();
            foreach (var table in tables)
            {
                var node = new TreeNode
                {
                    Text = table,
                    Tag = "table",
                    ImageIndex = 3
                };
                selected.Nodes.Add(node);
            }
            selected.Expand();
            //_treeViewDbs.RefreshItem(selected);
        }
        private void RefreshColumnsInDbTree(TreeNode selected, string[] columns)
        {
            selected.Nodes.Clear();
            foreach (var column in columns)
            {
                var node = new TreeNode
                {
                    Text = column,
                    Tag = "column",
                    ImageIndex = 5
                };
                selected.Nodes.Add(node);
            }
            selected.Expand();
            //_treeViewDbs.RefreshItem(selected);
        }
        #endregion

        #region TreeView Event
        private void _treeViewDbs_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == null) return;
            var name = e.Node.Text;
            var type = e.Node.Tag.ToString() ?? "";
            if (name != "")
            {
                if (type == "root")
                {        
                    _dbManager.GetDbName(_shellSqlConn.conn);
                }
                else if (type == "db")
                {
                    _dropDownDbs.SelectedItem = name;
                    _dbManager.GetTableName(_shellSqlConn.conn, name);
                }
                else if (type == "table")
                {
                    var dbname = e.Node.Parent.Text;

                    _dbManager.GetColumnType(_shellSqlConn.conn, dbname, name);
                }
            }
        }
        void _treeViewDbs_SelectionChanged(object sender, EventArgs e)
        {
            if (_treeViewDbs.SelectedNode == null) return;
            var select = _treeViewDbs.SelectedNode;
            var type = select.Tag.ToString() ?? "";
            if (type == "db")
            {
                _dropDownDbs.SelectedItem = select.Text;
            }
        }
        #endregion

        #region Button Event
        /// <summary>
        /// 连接数据库
        /// </summary>
		void _buttonConnect_Click(object sender, EventArgs e)
		{
			_dbManager.ConnectDb(_shellSqlConn.conn);
		}
        /// <summary>
        /// 断开数据库
        /// </summary>
		void _buttonDisconnect_Click(object sender, EventArgs e)
        {
			RefreshServerStatus(false);
			RefreshRootInDbTree(false);
		}
        /// <summary>
        /// 执行sql语句
        /// </summary>
		void _buttonRunScript_Click(object sender, EventArgs e)
		{
			var sql = _cbAreaSql.Text;
			if (string.IsNullOrWhiteSpace(sql))
			{
				MessageBox.Show("the query sql cannot be empty");
			}
			else if (_dropDownDbs.SelectedIndex == -1)
			{
				MessageBox.Show("please select one database");
			}
			else
			{
				//执行前先清空之前结果
				//_gridViewResult.Columns.Clear();

				var dbName = _dropDownDbs.SelectedItem.ToString();
                if(!_cbAreaSql.Items.Contains(sql))
                    _cbAreaSql.Items.Insert(0, sql);
                if (sql.ToLower().StartsWith("select"))
				{
					_dbManager.ExecuteReader(_shellSqlConn.conn, dbName, sql);
				}
				else
				{
					_dbManager.ExecuteNonQuery(_shellSqlConn.conn, dbName, sql);
				}
			}
		}

        #endregion

        #region RightMenu Event
        private void getCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_treeViewDbs.SelectedNode == null) return;
            var table = _treeViewDbs.SelectedNode.Text.Trim();
            var strSql = $"Select Count(*) As CNT From {table}";

            _cbAreaSql.Text = strSql;
            _buttonRunScript.PerformClick();
        }

        private void query20LineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_treeViewDbs.SelectedNode == null) return;
            var table = _treeViewDbs.SelectedNode.Text.Trim();
            var strSql = "";
            if (_shellSqlConn.type == "mysql")
            {
                strSql = $"Select * From `{table}` Order By 1 Limit 0,20";
            }else if(_shellSqlConn.type == "mssql_sqlsrv")
            {
                strSql = $"Select Top 20 * From {table} Order By 1";
            }
            
            _cbAreaSql.Text = strSql;
            _buttonRunScript.PerformClick();
        }

        private void copyNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_treeViewDbs.SelectedNode == null) return;

            var text = _treeViewDbs.SelectedNode.Text.Trim();
            Clipboard.SetDataObject(text, true);

            ShowMsgInStatusBar($"Copy {text} OK.");
        }

        private void dropTableToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copyCellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_gridViewResult.SelectedItems.Count < 1) return;
            //var cell = _gridViewResult.SelectedItems[0].
        }

        private void copyRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_gridViewResult.SelectedItems.Count < 1) return;

            var text = "";
            var col = this._gridViewResult.SelectedItems[0].SubItems.Count;
            foreach (ListViewItem.ListViewSubItem item in _gridViewResult.SelectedItems[0].SubItems)
            {
                text += item.Text + " | ";
            }
            text = text.Remove(text.Length - 3);
            Clipboard.SetDataObject(text, true);

            ShowMsgInStatusBar($"Copy Row Content OK.");
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = _dataTableResult;
            if (data != null)
            {
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV(Comma Separated Values)|*.csv";
                saveFileDialog.Filter += "|TSV(Tab Separated Values)|*.txt";
                saveFileDialog.FilterIndex = 1;
                if (DialogResult.OK == saveFileDialog.ShowDialog(_gridViewResult))
                {
                    var fileName = saveFileDialog.FileName;
                    switch (saveFileDialog.FilterIndex)
                    {
                        case 1:
                            SaveAs(data, fileName);
                            break;
                        case 2:
                            SaveAs(data, fileName, "\t");
                            break;
                    }
                }
            }
        }

        private void _treeViewDbs_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point clickPoint = new Point(e.X, e.Y);
                TreeNode treeNode = _treeViewDbs.GetNodeAt(clickPoint);
                if (treeNode != null)
                {
                    _treeViewDbs.SelectedNode = treeNode;
                    switch (treeNode.Tag.ToString())
                    {
                        case "table":
                            _treeViewMenu.Items[0].Visible = true;
                            _treeViewMenu.Items[1].Visible = true;
                            _treeViewMenu.Items[2].Visible = true;
                            break;
                        default:
                            _treeViewMenu.Items[0].Visible = false;
                            _treeViewMenu.Items[1].Visible = false;
                            _treeViewMenu.Items[2].Visible = false;
                            break;
                    }
                }
                else
                    _treeViewMenu.Visible = false;
            }
        }
        #endregion

        private void SaveAs(DataTable dt, string fileName, string separator = ",")
        {
            var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            var sw = new StreamWriter(fs, Encoding.Default);
            var data = string.Empty;

            //columns name
            for (var i = 0; i < dt.Columns.Count; i++)
            {
                data += dt.Columns[i].ColumnName;
                if (i < dt.Columns.Count - 1)
                {
                    data += separator;
                }
            }
            sw.WriteLine(data);

            //rows data
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                data = "";
                for (var j = 0; j < dt.Columns.Count; j++)
                {
                    data += dt.Rows[i][j].ToString();
                    if (j < dt.Columns.Count - 1)
                    {
                        data += separator;
                    }
                }
                sw.WriteLine(data);
            }

            sw.Close();
            fs.Close();

            MessageBox.Show("Save Ok!");
        }


    }
}
