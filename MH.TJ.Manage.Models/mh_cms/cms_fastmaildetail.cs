

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 快递明细表
    /// </summary>
    public class cms_fastmaildetail
    {
        /// <summary>
        /// 快递明细表
        /// </summary>
        public cms_fastmaildetail()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String fastmailid { get; set; }

        /// <summary>
        /// 查体信息id
        /// </summary>
        public System.String ctxxId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String detailname { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public System.Int32? num { get; set; }

        /// <summary>
        /// 类型 1报告 2档案 3耗材 4其他
        /// </summary>
        public System.String type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String remark { get; set; }
    }
}