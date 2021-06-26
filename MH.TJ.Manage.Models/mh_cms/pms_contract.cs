

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 合同表
    /// </summary>
    public class pms_contract
    {
        /// <summary>
        /// 合同表
        /// </summary>
        public pms_contract()
        {
        }

        /// <summary>
        /// 主键：合同表
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// 合同编码
        /// </summary>
        public System.String contract_code { get; set; }

        /// <summary>
        /// 产品id
        /// </summary>
        public System.Int32? product_id { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public System.String product_name { get; set; }

        /// <summary>
        /// 供应商id
        /// </summary>
        public System.Int32? supplier_id { get; set; }

        /// <summary>
        /// 供应商名称
        /// </summary>
        public System.String supplier_name { get; set; }

        /// <summary>
        /// 申请人
        /// </summary>
        public System.String applicant { get; set; }

        /// <summary>
        /// 合同有效期始
        /// </summary>
        public System.DateTime? valid_start { get; set; }

        /// <summary>
        /// 合同有效期止
        /// </summary>
        public System.DateTime? valid_end { get; set; }

        /// <summary>
        /// 签订日期
        /// </summary>
        public System.DateTime? signing_date { get; set; }

        /// <summary>
        /// 交货地点
        /// </summary>
        public System.String delivery_place { get; set; }

        /// <summary>
        /// 交货日期
        /// </summary>
        public System.DateTime? delivery_date { get; set; }

        /// <summary>
        /// 交易方式
        /// </summary>
        public System.String delivery_type { get; set; }

        /// <summary>
        /// 附件地址
        /// </summary>
        public System.String attachment_addr { get; set; }

        /// <summary>
        /// 合同信息
        /// </summary>
        public System.String msg { get; set; }

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