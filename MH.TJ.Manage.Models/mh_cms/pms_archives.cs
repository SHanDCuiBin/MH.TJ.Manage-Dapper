

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 档案表
    /// </summary>
    public class pms_archives
    {
        /// <summary>
        /// 档案表
        /// </summary>
        public pms_archives()
        {
        }

        /// <summary>
        /// 主键：档案表
        /// </summary>
        public System.Int64 id { get; set; }

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
        /// 产品类别id
        /// </summary>
        public System.Int32? product_type_id { get; set; }

        /// <summary>
        /// 产品类别名称
        /// </summary>
        public System.String product_type_name { get; set; }

        /// <summary>
        /// 产品注册证号
        /// </summary>
        public System.String certificate_no { get; set; }

        /// <summary>
        /// 申请人
        /// </summary>
        public System.String applicant { get; set; }

        /// <summary>
        /// 注册证有效期始
        /// </summary>
        public System.DateTime? valid_start { get; set; }

        /// <summary>
        /// 注册证有效期止
        /// </summary>
        public System.DateTime? valid_end { get; set; }

        /// <summary>
        /// 注册证批准日期
        /// </summary>
        public System.DateTime? approval_date { get; set; }

        /// <summary>
        /// 产品主要功能及用途
        /// </summary>
        public System.String function { get; set; }

        /// <summary>
        /// 附件地址
        /// </summary>
        public System.String attachment_addr { get; set; }

        /// <summary>
        /// 产品参数
        /// </summary>
        public System.String product_parameters { get; set; }

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