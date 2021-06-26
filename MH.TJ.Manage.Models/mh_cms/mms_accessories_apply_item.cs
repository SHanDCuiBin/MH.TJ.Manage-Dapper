

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 配件申请子表（记录详细配件）
    /// </summary>
    public class mms_accessories_apply_item
    {
        /// <summary>
        /// 配件申请子表（记录详细配件）
        /// </summary>
        public mms_accessories_apply_item()
        {
        }

        /// <summary>
        /// Id uuid
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 配件申请主表id
        /// </summary>
        public System.String accessories_apply_id { get; set; }

        /// <summary>
        /// 配件名称
        /// </summary>
        public System.String accessories_name { get; set; }

        /// <summary>
        /// 配件数量
        /// </summary>
        public System.Int32? accessories_num { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        public System.String specification { get; set; }
    }
}