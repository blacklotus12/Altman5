using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Altman.Util.Data
{
    public static class Db
    {
        public enum DbType
        {
            Access,
            SQLite
        }
        public static DbType MyDbType { get { return _dbtype; } }
        private static string _databasePath = "";
        private static string _connectionString = "";
        private static DbType _dbtype;

        public static void Init(string databasePath, DbType type)
        {
            _databasePath = databasePath;
            _dbtype = type;
            if (string.IsNullOrEmpty(_databasePath) && type == DbType.SQLite)
            {
                _databasePath = "data.db3";
            }
            else if (string.IsNullOrEmpty(_databasePath) && type == DbType.Access)
            {
                _databasePath = "data.mdb";
            }
            //初始化数据库
            CheckDb(_databasePath);
	    }

        /// <summary>
        /// 检查数据库文件
        /// </summary>
        private static void CheckDb(string dbPath)
        {
            //如果不存在数据库文件，则创建该数据库文件
            if (!File.Exists(dbPath))
            {
                //创建数据库
                if (_dbtype == DbType.Access)
                    AccessHelper.CreateDb(dbPath);
                else if (_dbtype == DbType.SQLite)
                    SqliteHelper.CreateDb(dbPath);
            }
            if (_dbtype == DbType.Access)
                //设置数据库连接语句
                _connectionString = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={_databasePath};Persist Security Info=False";
                //_connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={_databasePath};Jet OLEDB:Database Password=123456";
            else if (_dbtype == DbType.SQLite)
                _connectionString = $"Data Source={_databasePath}";
        }
        /// <summary>
        /// 检查数据库表
        /// </summary>
        public static bool CheckTable(string tableName)
        {
            DataTable dt = null;
            //判断数据库是否含有指定表
            if (_dbtype == DbType.Access)
                dt = AccessHelper.GetSchema(_connectionString);
            else if(_dbtype == DbType.SQLite)
			    dt = SqliteHelper.GetSchema(_connectionString);

            bool isAvailableDb = false;
            foreach (DataRow row in dt?.Rows)
            {
                if (row["TABLE_NAME"].ToString() == tableName && row["TABLE_TYPE"].ToString().ToLower() == "table")
                {
                    isAvailableDb = true;
                    break;
                }
            }
            return isAvailableDb;
        }
        /// <summary>
        /// 创建表
        /// </summary>
        public static bool? InitTable(string tableName, string[] definition)
        {
            if (CheckTable(tableName))
                return null;

            var rt = false;
            if (_dbtype == DbType.Access)
                rt = AccessHelper.CreateTable(_connectionString, tableName, definition);
            else if (_dbtype == DbType.SQLite)
                rt = SqliteHelper.CreateTable(_connectionString, tableName, definition);
            return rt;
        }
        /// <summary>
        /// 删除数据
        /// </summary>
        public static bool Delete(string tableName, KeyValuePair<string,object> where)
        {
            var rt = false;
            if (_dbtype == DbType.Access)
                rt = AccessHelper.Delete(_connectionString, tableName, where);
            else if (_dbtype == DbType.SQLite)
                rt = SqliteHelper.Delete(_connectionString, tableName, where);
            return rt;
        }
        /// <summary>
        /// 插入数据
        /// </summary>
        public static bool Insert(string tableName, Dictionary<string, object> data)
        {
            var rt = false;
            if (_dbtype == DbType.Access)
                rt = AccessHelper.Insert(_connectionString, tableName, data);
            else if (_dbtype == DbType.SQLite)
                rt = SqliteHelper.Insert(_connectionString, tableName, data);
            return rt;
        }
        /// <summary>
        /// 更新数据
        /// </summary>
        public static bool Update(string tableName, Dictionary<string, object> data, KeyValuePair<string,object> where)
        {
            var rt = false;
            if (_dbtype == DbType.Access)
                rt = AccessHelper.Update(_connectionString, tableName, data, where);
            else if (_dbtype == DbType.SQLite)
                rt = SqliteHelper.Update(_connectionString, tableName, data, where);
            return rt;
        }
        /// <summary>
        /// 获取数据库表
        /// </summary>
        public static DataTable GetDataTable(string tableName)
        {
            string sql = string.Format("select * from {0};", tableName);
            DataTable rt = null;
            if (_dbtype == DbType.Access)
                rt = AccessHelper.GetDataTable(new System.Data.OleDb.OleDbCommand(sql));
            else if (_dbtype == DbType.SQLite)
                rt = SqliteHelper.ExecuteDataTable(_connectionString, sql, null);
            return rt;
        }
    }
}
