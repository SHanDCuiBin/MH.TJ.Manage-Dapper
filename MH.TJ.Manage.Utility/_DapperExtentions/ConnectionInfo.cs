using MH.TJ.Manage.Utility._Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH.TJ.Manage.Utility._DapperExtentions
{
    public class ConnectionInfo
    {
        /// <summary>
        /// 链接编号
        /// </summary>
        public string connId { get; set; }

        /// <summary>
        /// 数据库类型
        /// </summary>
        public DatabaseType databaseType { get; set; }

        /// <summary>
        /// 业务库类型
        /// </summary>
        public BunissDataBaseEmum bunissDataBaseEmum { get; set; }

        /// <summary>
        /// 数据库链接字符串
        /// </summary>
        public string connsctionstring { get; set; }
    }
}
