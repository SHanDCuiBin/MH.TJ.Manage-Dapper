

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 产品表
    /// </summary>
    public class pms_product
    {
        /// <summary>
        /// 产品表
        /// </summary>
        public pms_product()
        {
        }

        /// <summary>
        /// 主键：产品表
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 供应商id
        /// </summary>
        public System.Int32? supplier_id { get; set; }

        /// <summary>
        /// 供应商名称
        /// </summary>
        public System.String supplier_name { get; set; }

        /// <summary>
        /// 是否重点养护(重点)
        /// </summary>
        public System.Int32? important { get; set; }

        /// <summary>
        /// 产品类别id
        /// </summary>
        public System.Int32? product_type_id { get; set; }

        /// <summary>
        /// 产品类别名称
        /// </summary>
        public System.String product_type_name { get; set; }

        /// <summary>
        /// (产品)规格型号
        /// </summary>
        public System.String model { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public System.String unit { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public System.Decimal? unit_price { get; set; }

        /// <summary>
        /// 生产批号
        /// </summary>
        public System.String batch_number { get; set; }

        /// <summary>
        /// 申请人
        /// </summary>
        public System.String applicant { get; set; }

        /// <summary>
        /// 贮存条件
        /// </summary>
        public System.String storage_conditions { get; set; }

        /// <summary>
        /// 核算标准
        /// </summary>
        public System.String account_standards { get; set; }

        /// <summary>
        /// 保质期有效天数
        /// </summary>
        public System.Int32? effective_days { get; set; }

        /// <summary>
        /// 保质期预警天数
        /// </summary>
        public System.Int32? warning_days { get; set; }

        /// <summary>
        /// 仓库余量报警
        /// </summary>
        public System.Int32? stock_margin { get; set; }

        /// <summary>
        /// 装箱规格
        /// </summary>
        public System.String pack_specification { get; set; }

        /// <summary>
        /// 产品主要功能及用途
        /// </summary>
        public System.String function { get; set; }

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