

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 企业资质表
    /// </summary>
    public class pms_enterprise_qualification
    {
        /// <summary>
        /// 企业资质表
        /// </summary>
        public pms_enterprise_qualification()
        {
        }

        /// <summary>
        /// 主键：企业资质表
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// 首营资质id
        /// </summary>
        public System.Int32? qualification_id { get; set; }

        /// <summary>
        /// 许可证名称
        /// </summary>
        public System.String license_name { get; set; }

        /// <summary>
        /// 许可证编号
        /// </summary>
        public System.String license_number { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        public System.String license_qy_name { get; set; }

        /// <summary>
        /// 企业负责人
        /// </summary>
        public System.String ceo { get; set; }

        /// <summary>
        /// 许可证范围
        /// </summary>
        public System.String license_scope { get; set; }

        /// <summary>
        /// 许可证企业地址
        /// </summary>
        public System.String license_qy_addr { get; set; }

        /// <summary>
        /// 许可证发证日期
        /// </summary>
        public System.DateTime? license_issuing_date { get; set; }

        /// <summary>
        /// 许可证有效期
        /// </summary>
        public System.DateTime? license_validity { get; set; }

        /// <summary>
        /// 营业执照企业名称
        /// </summary>
        public System.String b_license_qy_name { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        public System.String unified_social_credit { get; set; }

        /// <summary>
        /// 营业执照法定代表人
        /// </summary>
        public System.String b_license_legal_rep { get; set; }

        /// <summary>
        /// 企业简称
        /// </summary>
        public System.String enterprise_abbrev { get; set; }

        /// <summary>
        /// 营业执照经营范围
        /// </summary>
        public System.String b_license_scope { get; set; }

        /// <summary>
        /// 经营方式
        /// </summary>
        public System.String business_nature { get; set; }

        /// <summary>
        /// 营业执照企业地址
        /// </summary>
        public System.String b_license_qy_addr { get; set; }

        /// <summary>
        /// 营业执照发证日期
        /// </summary>
        public System.DateTime? b_license_issuing_date { get; set; }

        /// <summary>
        /// 营业执照有效期
        /// </summary>
        public System.DateTime? b_license_validity { get; set; }

        /// <summary>
        /// 第二类备案凭证名称
        /// </summary>
        public System.String record_certificate { get; set; }

        /// <summary>
        /// 备案号
        /// </summary>
        public System.String record_number { get; set; }

        /// <summary>
        /// 第二类凭证有效期
        /// </summary>
        public System.DateTime? record_validity { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        public System.String enterprise_name { get; set; }

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

        /// <summary>
        /// 企业资质类别 1为生产相关资质 2为经营相关资质
        /// </summary>
        public System.UInt32? enterprise_qualification_type { get; set; }
    }
}