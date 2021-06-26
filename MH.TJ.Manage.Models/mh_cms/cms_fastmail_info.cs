

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 申请打印存储地址表
    /// </summary>
    public class cms_fastmail_info
    {
        /// <summary>
        /// 申请打印存储地址表
        /// </summary>
        public cms_fastmail_info()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 查体信息id
        /// </summary>
        public System.String ctxx_id { get; set; }

        /// <summary>
        /// 体检机构号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 体检日期
        /// </summary>
        public System.DateTime? tjrq { get; set; }

        /// <summary>
        /// 接收机构号
        /// </summary>
        public System.String js_org_id { get; set; }

        /// <summary>
        /// 接收人姓名
        /// </summary>
        public System.String js_name { get; set; }

        /// <summary>
        /// 接收人电话
        /// </summary>
        public System.String js_phone { get; set; }

        /// <summary>
        /// 接收地址
        /// </summary>
        public System.String js_address { get; set; }

        /// <summary>
        /// 1.报告2.档案
        /// </summary>
        public System.Int32 type { get; set; }

        /// <summary>
        /// 申请人id
        /// </summary>
        public System.Int32? apply_user_id { get; set; }

        /// <summary>
        /// 申请人姓名
        /// </summary>
        public System.String apply_user_name { get; set; }
    }
}