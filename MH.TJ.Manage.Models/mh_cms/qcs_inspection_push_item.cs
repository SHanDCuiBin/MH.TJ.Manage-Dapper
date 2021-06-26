

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 微信推送与指控信息中间表
    /// </summary>
    public class qcs_inspection_push_item
    {
        /// <summary>
        /// 微信推送与指控信息中间表
        /// </summary>
        public qcs_inspection_push_item()
        {
        }

        /// <summary>
        /// id
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 质控信息id
        /// </summary>
        public System.String mh_qclo_id { get; set; }

        /// <summary>
        /// 推送信息id
        /// </summary>
        public System.Int32? qcs_push_id { get; set; }
    }
}