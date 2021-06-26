using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH.TJ.Manage.Utility._Constant
{
    /// <summary>
    /// 业务数据库类型
    /// </summary>
    public enum BunissDataBaseEmum
    {
        basicinfoDB,                      //basicinfo库
        mhcmsDB,                          //mh_cms库
        healthInfoDB,                     //health_info库
        sysConfigDB                       //sys_config库
    }

    /// <summary>
    /// 数据库引擎类型
    /// </summary>
    public enum DatabaseType
    {
        SqlServer,  //SQLServer数据库
        MySql,      //Mysql数据库
        Oracle,     //Oracle数据库
        Sqlite,     //SQLite数据库
    }
}
