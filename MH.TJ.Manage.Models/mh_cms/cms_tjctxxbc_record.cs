

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 查体信息补查人员记录表
    /// </summary>
    public class cms_tjctxxbc_record
    {
        /// <summary>
        /// 查体信息补查人员记录表
        /// </summary>
        public cms_tjctxxbc_record()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 查体信息表id
        /// </summary>
        public System.String ctxx_id { get; set; }

        /// <summary>
        /// 补查人的条码号
        /// </summary>
        public System.String tj_tmh { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime create_date { get; set; }
    }
}