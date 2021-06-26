

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 软件版本文件对应路径信息表--记录软件更新地址的路径
    /// </summary>
    public class mh_update_info
    {
        /// <summary>
        /// 软件版本文件对应路径信息表--记录软件更新地址的路径
        /// </summary>
        public mh_update_info()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String update_id { get; set; }

        /// <summary>
        /// 软件类型   1 采集  2 审核  3质控软件
        /// </summary>
        public System.String soft_type { get; set; }

        /// <summary>
        /// 修改地址
        /// </summary>
        public System.String update_url { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        public System.String file_name { get; set; }

        /// <summary>
        /// 文件地址
        /// </summary>
        public System.String file_path { get; set; }

        /// <summary>
        /// 1是服务2软件0数据库
        /// </summary>
        public System.Int32? type { get; set; }

        /// <summary>
        /// 修改描述
        /// </summary>
        public System.String description { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? update_time { get; set; }
    }
}