

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 物品领用申请子表
    /// </summary>
    public class wms_products_apply_items
    {
        /// <summary>
        /// 物品领用申请子表
        /// </summary>
        public wms_products_apply_items()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 物品申请表id
        /// </summary>
        public System.String apply_id { get; set; }

        /// <summary>
        /// 物品领用模板id
        /// </summary>
        public System.Int32 products_template_id { get; set; }

        /// <summary>
        /// 申请数量
        /// </summary>
        public System.Int32 apply_num { get; set; }

        /// <summary>
        /// 实际领取数量
        /// </summary>
        public System.Int32? get_num { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public System.String unit { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public System.Int32? number { get; set; }

        /// <summary>
        /// 状态，是否出库，0未出，1已出
        /// </summary>
        public System.Int32 state { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        public System.String products_id { get; set; }

        /// <summary>
        /// 人员类型
        /// </summary>
        public System.Int32 ry_type { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public System.String products_name { get; set; }

        /// <summary>
        /// 整套的模板id（按套出的模块）
        /// </summary>
        public System.Int32? template_id { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        public System.String template_name { get; set; }

        /// <summary>
        /// 模板数量
        /// </summary>
        public System.Int32? template_num { get; set; }
    }
}