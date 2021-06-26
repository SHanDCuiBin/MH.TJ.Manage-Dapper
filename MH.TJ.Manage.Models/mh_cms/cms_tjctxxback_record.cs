

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 查体信息状态回退记录表
    /// </summary>
    public class cms_tjctxxback_record
    {
        /// <summary>
        /// 查体信息状态回退记录表
        /// </summary>
        public cms_tjctxxback_record()
        {
        }

        /// <summary>
        /// id
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 查体信息表id
        /// </summary>
        public System.String ctxx_id { get; set; }

        /// <summary>
        /// 回退说明原因 条码号,原因;
        /// </summary>
        public System.String back_msg { get; set; }

        /// <summary>
        /// 回退人id
        /// </summary>
        public System.Int32 back_user_id { get; set; }

        /// <summary>
        /// 回退人姓名
        /// </summary>
        public System.String back_user_name { get; set; }

        /// <summary>
        /// 回退位置（在哪一步进行的回退）
        /// </summary>
        public System.String back_state { get; set; }

        /// <summary>
        /// 回退时间
        /// </summary>
        public System.DateTime back_date { get; set; }
    }
}