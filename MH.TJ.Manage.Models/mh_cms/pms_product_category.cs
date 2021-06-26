

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 产品类别表
    /// </summary>
    public class pms_product_category
    {
        /// <summary>
        /// 产品类别表
        /// </summary>
        public pms_product_category()
        {
        }

        /// <summary>
        /// 主键：产品类别表
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// 类别
        /// </summary>
        public System.String type { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String remarks { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        public System.Int32? founder { get; set; }

        /// <summary>
        /// 修改人id
        /// </summary>
        public System.Int32? reviser { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? creation_time { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? revision_time { get; set; }
    }
}