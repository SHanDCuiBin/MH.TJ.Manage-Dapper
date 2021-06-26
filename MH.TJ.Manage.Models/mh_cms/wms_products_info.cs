

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 商品信息表
    /// </summary>
    public class wms_products_info
    {
        /// <summary>
        /// 商品信息表
        /// </summary>
        public wms_products_info()
        {
        }

        /// <summary>
        /// 
        ///
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 产品代码号
        /// </summary>
        public System.String product_code { get; set; }

        /// <summary>
        /// 生产厂商 对应 supplier 的 id
        /// </summary>
        public System.Int32? manufacturer_id { get; set; }

        /// <summary>
        /// 供应商id
        /// </summary>
        public System.Int32? supplier_id { get; set; }

        /// <summary>
        /// 供应商名称
        /// </summary>
        public System.String supplier_name { get; set; }

        /// <summary>
        /// 单位 对应 products_unit
        /// </summary>
        public System.Int32 unit_id { get; set; }

        /// <summary>
        /// 储存条件 对应 products_storage_condition
        /// </summary>
        public System.Int32? storage_condition_id { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 批准文号
        /// </summary>
        public System.String pzwh { get; set; }

        /// <summary>
        /// 全拼
        /// </summary>
        public System.String c_spell { get; set; }

        /// <summary>
        /// 简拼
        /// </summary>
        public System.String s_spell { get; set; }

        /// <summary>
        /// 保质期(有效天数)
        /// </summary>
        public System.Int32? validity_days { get; set; }

        /// <summary>
        /// 用于该商品保质期到期预警，单位 天
        /// </summary>
        public System.Int32? warn_days { get; set; }

        /// <summary>
        /// 用于提醒仓库数量报警
        /// </summary>
        public System.Int32? warn_count { get; set; }

        /// <summary>
        /// 商品类型(小类型) 对应 products_type
        /// </summary>
        public System.Int32? type_id { get; set; }

        /// <summary>
        /// 审核人
        /// </summary>
        public System.Int32? verifier_id { get; set; }

        /// <summary>
        /// 该商品核算标准(利用率用) 单位: 人
        /// </summary>
        public System.Int32? accounting_standards { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        public System.String specifications { get; set; }

        /// <summary>
        /// 子包装数量
        /// </summary>
        public System.Int32? child_size { get; set; }

        /// <summary>
        /// 子包装单位
        /// </summary>
        public System.String child_unit { get; set; }

        /// <summary>
        /// 子包装规格
        /// </summary>
        public System.Int32? child_specifications { get; set; }

        /// <summary>
        /// 是否使用子包装计数 1.是 0.否  默认0
        /// </summary>
        public System.SByte? is_use_child_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime create_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 create_user_id { get; set; }

        /// <summary>
        /// 生产商
        /// </summary>
        public System.String factory { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public System.String unit_str { get; set; }

        /// <summary>
        /// 存储条件
        /// </summary>
        public System.String cctj { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public System.String type_str { get; set; }

        /// <summary>
        /// 审核人
        /// </summary>
        public System.String verifier_name { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 是否为重点养护 1.是 0.否 默认 0
        /// </summary>
        public System.SByte? is_emphasis { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public System.Decimal? unit_price { get; set; }

        /// <summary>
        /// 申请人
        /// </summary>
        public System.String apply_user { get; set; }

        /// <summary>
        /// 申请人id
        /// </summary>
        public System.Int32? apply_user_id { get; set; }

        /// <summary>
        /// 装箱规格
        /// </summary>
        public System.String packing_specifications { get; set; }

        /// <summary>
        /// 产品主要功能及用途
        /// </summary>
        public System.String purpose { get; set; }
    }
}