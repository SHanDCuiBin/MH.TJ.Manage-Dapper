

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 首营资质表
    /// </summary>
    public class pms_business_qualification
    {
        /// <summary>
        /// 首营资质表
        /// </summary>
        public pms_business_qualification()
        {
        }

        /// <summary>
        /// 主键：首营资质表
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 企业简称
        /// </summary>
        public System.String abbrev { get; set; }

        /// <summary>
        /// 级别
        /// </summary>
        public System.String level { get; set; }

        /// <summary>
        /// 申请人
        /// </summary>
        public System.String applicant { get; set; }

        /// <summary>
        /// 发票类型
        /// </summary>
        public System.Int32? invoice_no { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        public System.Decimal? tax_rate { get; set; }

        /// <summary>
        /// 拟供产品
        /// </summary>
        public System.String supplied_products { get; set; }

        /// <summary>
        /// 企业地址
        /// </summary>
        public System.String business_addr { get; set; }

        /// <summary>
        /// 邮箱号
        /// </summary>
        public System.String mail { get; set; }

        /// <summary>
        /// 邮政编码
        /// </summary>
        public System.Int32? postal_code { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public System.String contacts { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        public System.String contact_number { get; set; }

        /// <summary>
        /// 附件地址
        /// </summary>
        public System.String attachment_addr { get; set; }

        /// <summary>
        /// 企业类别
        /// </summary>
        public System.Int32? category { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.Int32? founder { get; set; }

        /// <summary>
        /// 修改人
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