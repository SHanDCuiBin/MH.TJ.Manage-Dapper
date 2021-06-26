

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 软件版本管理信息表--记录软件的版本信息
    /// </summary>
    public class mh_update_task
    {
        /// <summary>
        /// 软件版本管理信息表--记录软件的版本信息
        /// </summary>
        public mh_update_task()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String board_serial { get; set; }

        /// <summary>
        /// 软件类型   采集 /审核
        /// </summary>
        public System.String soft_type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String is_master { get; set; }

        /// <summary>
        /// 使用过的版本号
        /// </summary>
        public System.String full_version { get; set; }

        /// <summary>
        /// 当前最新版本号
        /// </summary>
        public System.String main_version { get; set; }

        /// <summary>
        /// 是否启动0禁止，1启动
        /// </summary>
        public System.String flag { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? update_time { get; set; }
    }
}