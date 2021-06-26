using DapperExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MH.TJ.Manage.Utility._Constant;
using System.Data.SqlClient;
using DapperExtensions.Mapper;
using System.Reflection;
using DapperExtensions.Sql;
using MySql.Data.MySqlClient;
using Microsoft.Data.Sqlite;

namespace MH.TJ.Manage.Utility._DapperExtentions
{
    public class DbConnectionFactory
    {
        /// <summary>
        /// 获取数据库连接
        /// </summary>
        /// <returns></returns>
        public static Database CreateConnection(string strConn, DatabaseType databaseType = DatabaseType.Oracle)
        {
            Database connection = null;
            //获取配置进行转换
            switch (databaseType)
            {
                case DatabaseType.SqlServer:
                    var sqlConn = new SqlConnection(strConn);
                    var sqlconfig = new DapperExtensionsConfiguration(typeof(AutoClassMapper<>), new List<Assembly>(), new SqlServerDialect());
                    var sqlGenerator = new SqlGeneratorImpl(sqlconfig);
                    connection = new Database(sqlConn, sqlGenerator);
                    break;
                case DatabaseType.MySql:
                    var mysqlConn = new MySqlConnection(strConn);
                    var mysqlconfig = new DapperExtensionsConfiguration(typeof(AutoClassMapper<>), new List<Assembly>(), new MySqlDialect());
                    var mysqlGenerator = new SqlGeneratorImpl(mysqlconfig);
                    connection = new Database(mysqlConn, mysqlGenerator);
                    break;
                case DatabaseType.Sqlite:
                    var sqlliteConn = new SqliteConnection(strConn);
                    var sqlliteconfig = new DapperExtensionsConfiguration(typeof(AutoClassMapper<>), new List<Assembly>(), new SqliteDialect());
                    var sqlliteGenerator = new SqlGeneratorImpl(sqlliteconfig);
                    connection = new Database(sqlliteConn, sqlliteGenerator);
                    break;     
            }
            return connection;
        }
    }
}
