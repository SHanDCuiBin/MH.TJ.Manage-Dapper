
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 数据修改日志详情表
    /// </summary>
    public class mh_modify_info
    {
        /// <summary>
        /// 数据修改日志详情表
        /// </summary>
        public mh_modify_info()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 主表id
        /// </summary>
        public System.String modify_id { get; set; }

        /// <summary>
        /// 条码号
        /// </summary>
        public System.String tmh { get; set; }

        /// <summary>
        /// 原始数据
        /// </summary>
        public System.String original_data { get; set; }

        /// <summary>
        /// 新数据
        /// </summary>
        public System.String new_data { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public System.DateTime? update_time { get; set; }
    }
}