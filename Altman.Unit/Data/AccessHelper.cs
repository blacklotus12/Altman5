using ADOX;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;

namespace Altman.Util.Data
{
    /// <summary>
    ///access数据库帮助类
    /// </summary>
	public static class AccessHelper
    {
		private static string _connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=data.mdb";
        private static OleDbConnection _conn = null;


        /// <summary>
        /// 创建access数据库
        /// </summary>
        /// <param name="filePath">数据库文件的全路径，如 D:\\NewDb.mdb</param>
        public static bool CreateAccessDb(string filePath)
        {
            ADOX.Catalog catalog = new Catalog();
            if (!File.Exists(filePath))
            {
                try
                {
                    catalog.Create($"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={filePath}");
                    //catalog.Create($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filePath};Jet OLEDB:Database Password=123456");
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    System.Runtime.InteropServices.Marshal.FinalReleaseComObject(catalog.ActiveConnection);
                    System.Runtime.InteropServices.Marshal.FinalReleaseComObject(catalog);
                }
            }
            return true;
        }

        /// <summary>
        /// 在access数据库中创建表
        /// </summary>
        /// <param name="filePath">数据库表文件全路径如D:\\NewDb.mdb 没有则创建 </param> 
        /// <param name="tableName">表名</param>
        /// <param name="colums">ADOX.Column对象数组</param>
        public static void CreateAccessTable(string filePath, string tableName, params ADOX.Column[] colums)
        {
            ADOX.Catalog catalog = new Catalog();
            //数据库文件不存在则创建
            if (!File.Exists(filePath))
            {
                try
                {
                    catalog.Create("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Jet OLEDB:Engine Type=5");
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
            ADODB.Connection cn = new ADODB.Connection();
            cn.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath, null, null, -1);
            catalog.ActiveConnection = cn;
            ADOX.Table table = new ADOX.Table();
            table.Name = tableName;
            foreach (var column in colums)
            {
                table.Columns.Append(column);
            }
            // column.ParentCatalog = catalog; 
            //column.Properties["AutoIncrement"].Value = true; //设置自动增长
            //table.Keys.Append("FirstTablePrimaryKey", KeyTypeEnum.adKeyPrimary, column, null, null); //定义主键
            catalog.Tables.Append(table);
            cn.Close();
        }

        /// <summary>
        /// 打开数据库
        /// </summary>
        private static void OpenConnection()
        {
            _conn = new OleDbConnection(_connString); //创建实例
            if (_conn.State == ConnectionState.Closed)
            {
                try
                {
                    _conn.Open();
                }
                catch (Exception e)
                { 
                    throw new Exception(e.Message); 
                }

            }

        }
        /// <summary>
        /// 关闭数据库
        /// </summary>
        private static void CloseConnection()
        {
			if (_conn!=null && _conn.State == ConnectionState.Open)
            {
                _conn.Close();
                _conn.Dispose();
            }
        }

	    public static string ConnString
	    {
			get { return _connString; }
			set { _connString = value; }
	    }

        /// <summary>
        /// 执行sql语句
        /// </summary>
        public static bool ExcuteSql(OleDbCommand cmd)
        {
            bool flag;
            try
            {
                OpenConnection();
                cmd.Connection = _conn;
                cmd.ExecuteNonQuery();
                flag = true;
            }
            catch (Exception e)
            {
                flag = false;
                throw new Exception(e.Message);
            }
            finally
            { 
                CloseConnection(); 
            }
            return flag;
        }

        public static bool ExcuteSqlParameter(OleDbCommand cmd)
        {
            bool flag;
            try
            {
                OpenConnection();
                cmd.Connection = _conn;

                if (Convert.ToInt32(cmd.ExecuteNonQuery()) > 0)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            catch (Exception e)
            {
                flag = false;
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
            return flag;

        }

		public static string ExecuteScalar(OleDbCommand cmd)
		{
			try
			{
				OpenConnection();
				cmd.Connection = _conn;
				object value = cmd.ExecuteScalar();
				return value != null ? value.ToString() : "";
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
			finally
			{
				CloseConnection();
			}
		}

        /// <summary>
        /// 返回指定sql语句的OleDbDataReader对象，使用时请注意关闭这个对象
        /// </summary>
        public static OleDbDataReader GetDataReader(OleDbCommand cmd)
        {
            OleDbDataReader dr = null;
            try
            {
                OpenConnection();
                cmd.Connection = _conn;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch
            {
                try
                {
                    dr.Close();
                    CloseConnection();
                }
                catch { }
            }
            return dr;
        }
        /// <summary>
        /// 返回指定sql语句的OleDbDataReader对象,使用时请注意关闭
        /// </summary>
        public static void GetDataReader(OleDbCommand cmd, ref OleDbDataReader dr)
        {
            try
            {
                OpenConnection();
                cmd.Connection = _conn;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch
            {
                try
                {
                    if (dr != null && !dr.IsClosed)
                        dr.Close();
                }
                catch{ }
                finally
                {
                    CloseConnection();
                }
            }
        }
        /// <summary>
        /// 返回指定sql语句的dataset
        /// </summary>
        public static DataSet GetDataSet(OleDbCommand cmd)
        {
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();
            try
            {            
                OpenConnection();
                cmd.Connection = _conn;
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
            return ds;
        }
        /// <summary>
        /// 返回指定sql语句的dataset
        /// </summary>
        public static void GetDataSet(OleDbCommand cmd, ref DataSet ds)
        {
            OleDbDataAdapter da = new OleDbDataAdapter();
            try
            {
                OpenConnection();
                cmd.Connection = _conn;
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        /// <summary>
        /// 返回指定sql语句的datatable
        /// </summary>
        public static DataTable GetDataTable(OleDbCommand cmd)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter();
            try
            {
                OpenConnection();
                cmd.Connection = _conn;
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
            return dt;
        }
        /// <summary>
        /// 返回指定sql语句的datatable
        /// </summary>
        public static void GetDataTable(OleDbCommand cmd, ref DataTable dt)
        {
            OleDbDataAdapter da = new OleDbDataAdapter();
            try
            {
                OpenConnection();
                cmd.Connection = _conn;
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        /// <summary>
        /// 返回指定sql语句的dataview
        /// </summary>
        public static DataView GetDataView(OleDbCommand cmd)
        {
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            DataView dv;
            try
            {
                OpenConnection();
                cmd.Connection = _conn;
                da.SelectCommand = cmd;
                da.Fill(ds);
                dv = ds.Tables[0].DefaultView;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
            return dv;
        }
        /// <summary>
        /// 获取所有数据类型信息
        /// </summary>
        /// <returns></returns>
        public static DataTable GetSchema(string connectionString)
        {
            _connString = connectionString;
            try
            {
                OpenConnection();
                DataTable dt = _conn.GetSchema("TABLES");
                return dt;
            }
            catch (Exception)
            {
                throw;
            }          
        }
        private static string ConvertToType(object obj)
        {
            var text = "";
            string type = (obj == null) ? typeof(Nullable).ToString() : obj.GetType().ToString();
            switch (type)
            {
                case ("DBNull"):
                case ("Char"):
                case ("SByte"):
                case ("UInt16"):
                case ("UInt32"):
                case ("UInt64"):
                    throw new SystemException("Invalid data type");
                case ("System.Nullable"):
                    text = "Null";
                    break;
                case ("System.String"):
                case ("System.DateTime"):
                case ("System.Boolean"):
                case ("System.Object"):
                    text = $"'{obj}'";
                    break;
                case ("System.Byte[]"):
                    text = ((byte[])obj).ToString();
                    break;
                case ("System.Int32"):
                case ("System.Double"):
                case ("System.Decimal"):
                case ("System.Guid"):
                    text = obj.ToString();
                    break;
                default:
                    throw new SystemException("Value is of unknown data type");
            } // end switch
            return text;
        }

            /// <summary>
            /// 更新操作
            /// </summary>
            /// <param name="connectionString"></param>
            /// <param name="tableName">表名</param>
            /// <param name="data">需要更新的键值对（列名，列值）</param>
            /// <param name="where">判断表达式</param>
            /// <returns></returns>
        public static bool Update(string connectionString, string tableName, Dictionary<string, object> data, KeyValuePair<string, object> where)
        {
            var returnCode = true;

            var setStr = string.Join(", ", data.Select(o => $"[{o.Key}]={ConvertToType(o.Value)}"));

            var whereStr = $" [{where.Key}]={ConvertToType(where.Value)} ";
            try
            {
                var sql = $"update {tableName} set {setStr} where {whereStr};";
                _connString = connectionString;
                returnCode = ExcuteSql(new OleDbCommand(sql));
            }
            catch
            {
                returnCode = false;
            }
            return returnCode;
        }

        /// <summary>
        /// 删除操作
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="tableName">表名</param>
        /// <param name="where">判断表达式</param>
        /// <returns></returns>
        public static bool Delete(string connectionString, string tableName, KeyValuePair<string, object> where)
        {
            var returnCode = true;

            var whereStr = $" [{where.Key}]={ConvertToType(where.Value)} ";
            try
            {
                var sql = $"delete from {tableName} where {whereStr};";
                _connString = connectionString;
                returnCode = ExcuteSql(new OleDbCommand(sql));
            }
            catch
            {
                returnCode = false;
            }
            return returnCode;
        }

        /// <summary>
        /// 插入操作
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="tableName">表名</param>
        /// <param name="data">需要插入的键值对（列名，列值）</param>
        /// <returns></returns>
        public static bool Insert(string connectionString, string tableName, Dictionary<string, object> data)
        {
            var returnCode = true;

            var columnsStr = string.Join(", ", data.Keys.Select(o => $"[{o}]"));
            var valuesStr = string.Join(", ", data.Values.Select(o => ConvertToType(o)));
            try
            {
                string sql = $"insert into {tableName}({columnsStr}) values({valuesStr});";
                _connString = connectionString;
                returnCode = ExcuteSql(new OleDbCommand(sql));
            }
            catch
            {
                returnCode = false;
            }
            return returnCode;
        }
        /// <summary>
        /// 创建数据库
        /// </summary>
        /// <param name="dbName">数据名</param>
        /// <returns></returns>
        public static bool CreateDb(string dbName)
        {
            return CreateAccessDb(dbName);
        }

        /// <summary>
        /// 创建表
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="tableName">表名</param>
        /// <param name="definition">表的定义</param>
        /// <returns></returns>
        public static bool CreateTable(string connectionString, string tableName, string[] definition)
        {
            bool returnCode = true;
            try
            {
                string values = string.Join(", ", definition);
                string sql = string.Format("create table {0}({1});", tableName, values);
                _connString = connectionString;
                returnCode = ExcuteSql(new OleDbCommand(sql));
            }
            catch
            {
                returnCode = false;
            }
            return returnCode;
        }

        /// <summary>
        /// 清空表
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="tableName">表名</param>
        /// <returns></returns>
        public static bool ClearTable(string connectionString, string tableName)
        {
            bool returnCode = true;
            try
            {
                string sql = string.Format("delete from {0};", tableName);
                _connString = connectionString;
                returnCode = ExcuteSql(new OleDbCommand(sql));
            }
            catch
            {
                returnCode = false;
            }
            return returnCode;
        }
        /// <summary>
        /// 清空数据库
        /// </summary>
        /// <returns></returns>
        public static bool ClearDb(string connectionString)
        {
            bool returnCode = true;
            try
            {
                string sql = "SELECT MSysObjects.Name FROM MsysObjects WHERE (Left([Name],1)<>\"~\") AND (Left$([Name],4) <> \"Msys\") AND (MSysObjects.Type)=1 ORDER BY MSysObjects.Name;";
                _connString = connectionString;
                DataTable tables = GetDataTable(new OleDbCommand(sql));
                foreach (DataRow table in tables.Rows)
                {
                    ClearTable(connectionString, table["NAME"].ToString());
                }
            }
            catch
            {
                returnCode = false;
            }
            return returnCode;
        }
    }
}
