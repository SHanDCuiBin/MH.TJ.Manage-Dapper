

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 生产商,供应商,客户表
    /// </summary>
    public class wms_firms_client
    {
        /// <summary>
        /// 生产商,供应商,客户表
        /// </summary>
        public wms_firms_client()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 客户/供应商/生产商 名称
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 客户/供应商/生产商 简称
        /// </summary>
        public System.String abbrev { get; set; }

        /// <summary>
        /// 申请人
        /// </summary>
        public System.String applicant { get; set; }

        /// <summary>
        /// 级别  1 一级 2 二级
        /// </summary>
        public System.Int32? level { get; set; }

        /// <summary>
        /// 发票类型：1 增值税普通发票；2 增值税专用发票
        /// </summary>
        public System.Int32? invoice_no { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        public System.Decimal? tax_rate { get; set; }

        /// <summary>
        /// 证件名称
        /// </summary>
        public System.String zj_name { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        public System.String certificate_num { get; set; }

        /// <summary>
        /// 发证时间
        /// </summary>
        public System.DateTime? fzsj { get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        public System.DateTime? expiration_date { get; set; }

        /// <summary>
        /// 证件照片/附件地址
        /// </summary>
        public System.String certificate_url { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public System.String address { get; set; }

        /// <summary>
        /// 1.客户2.供货商 3.生产商 
        /// </summary>
        public System.Int32? type { get; set; }

        /// <summary>
        /// 拟供产品
        /// </summary>
        public System.String supplied_products { get; set; }

        /// <summary>
        /// 机构号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 企业类别 1 生产企业 2 经营企业
        /// </summary>
        public System.Int32? category { get; set; }

        /// <summary>
        /// 1.启用 2作废
        /// </summary>
        public System.Int32? enable { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public System.String lxr { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        public System.String phone_num { get; set; }

        /// <summary>
        /// 邮箱号
        /// </summary>
        public System.String mail { get; set; }

        /// <summary>
        /// 邮政编码
        /// </summary>
        public System.Int32? postal_code { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.Int32? create_user_id { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public System.Int32? reviser { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? revision_time { get; set; }
    }
}