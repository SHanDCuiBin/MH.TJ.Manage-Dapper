

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 采购入库详情表
    /// </summary>
    public class pms_purchase_warehousing_details
    {
        /// <summary>
        /// 采购入库详情表
        /// </summary>
        public pms_purchase_warehousing_details()
        {
        }

        /// <summary>
        /// 主键：采购入库详情表
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// 采购入库id
        /// </summary>
        public System.Int32 warehousing_id { get; set; }

        /// <summary>
        /// 产品id
        /// </summary>
        public System.Int32 product_id { get; set; }

        /// <summary>
        /// 产品name
        /// </summary>
        public System.String product_name { get; set; }

        /// <summary>
        /// 产品数量
        /// </summary>
        public System.Int32 number { get; set; }

        /// <summary>
        /// 设备出厂编号
        /// </summary>
        public System.String equip_factory_num { get; set; }

        /// <summary>
        /// 商品来源
        /// </summary>
        public System.String goods_source { get; set; }

        /// <summary>
        /// 生产批号
        /// </summary>
        public System.String batch_number { get; set; }

        /// <summary>
        /// 生产日期
        /// </summary>
        public System.DateTime? manufacture_date { get; set; }

        /// <summary>
        /// 保质日期
        /// </summary>
        public System.DateTime? guarantee_date { get; set; }

        /// <summary>
        /// 失效日期
        /// </summary>
        public System.DateTime? expiration_date { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public System.Int32 status { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        public System.Int32 founder { get; set; }

        /// <summary>
        /// 修改人id
        /// </summary>
        public System.Int32 reviser { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime creation_time { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime revision_time { get; set; }
    }
}