

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 
    /// </summary>
    public class child_area
    {
        /// <summary>
        /// 
        /// </summary>
        public child_area()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 机构号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 级别 3区 4街道 5社区
        /// </summary>
        public System.Int32? level { get; set; }

        /// <summary>
        /// 公卫机构号
        /// </summary>
        public System.String gw_org_id { get; set; }

        /// <summary>
        /// 地区名
        /// </summary>
        public System.String name { get; set; }
    }
}