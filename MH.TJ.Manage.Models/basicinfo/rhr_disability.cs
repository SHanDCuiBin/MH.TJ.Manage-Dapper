

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 残疾情况
    /// </summary>
    public class rhr_disability
    {
        /// <summary>
        /// 残疾情况
        /// </summary>
        public rhr_disability()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.UInt32 id { get; set; }

        /// <summary>
        /// 居民健康档案id
        /// </summary>
        public System.String rhr_id { get; set; }

        /// <summary>
        /// 残疾
        /// </summary>
        public System.UInt32 disability { get; set; }

        /// <summary>
        /// 残疾名字
        /// </summary>
        public System.String disability_name { get; set; }

        /// <summary>
        /// 残疾时间
        /// </summary>
        public System.DateTime? disability_time { get; set; }

        /// <summary>
        /// 附加信息(其他说明)
        /// </summary>
        public System.String additional_info { get; set; }

        /// <summary>
        /// 修改者姓名
        /// </summary>
        public System.String update_user_name { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? gmt_modified { get; set; }

        /// <summary>
        /// 创建者姓名
        ///
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 创建地区
        /// </summary>
        public System.String create_org_id { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? gmt_create { get; set; }

        /// <summary>
        /// 分片id
        /// </summary>
        public System.String sharding_id { get; set; }

        /// <summary>
        /// 0为未删除1为已删除
        /// </summary>
        public System.UInt32 deleted { get; set; }
    }
}