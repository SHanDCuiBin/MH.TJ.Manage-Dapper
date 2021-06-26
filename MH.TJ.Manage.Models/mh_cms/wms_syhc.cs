

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 剩余耗材（纸张）
    /// </summary>
    public class wms_syhc
    {
        /// <summary>
        /// 剩余耗材（纸张）
        /// </summary>
        public wms_syhc()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// 上传单号(每次上传的一批唯一)
        /// </summary>
        public System.String code { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public System.Int64? product_id { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public System.Decimal? count { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public System.String unit { get; set; }

        /// <summary>
        /// 1.车辆耗材 2.打印纸
        /// </summary>
        public System.SByte? type { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        public System.Int32 create_user_id { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime create_time { get; set; }
    }
}