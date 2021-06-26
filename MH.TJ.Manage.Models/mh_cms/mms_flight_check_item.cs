

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 飞行检查子表
    /// </summary>
    public class mms_flight_check_item
    {
        /// <summary>
        /// 飞行检查子表
        /// </summary>
        public mms_flight_check_item()
        {
        }

        /// <summary>
        /// Id uuid
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 主表id
        /// </summary>
        public System.String check_id { get; set; }

        /// <summary>
        /// 标准
        /// </summary>
        public System.String standard { get; set; }

        /// <summary>
        /// 是否合格1.合格2.不合格
        /// </summary>
        public System.Int32? is_qualified { get; set; }

        /// <summary>
        /// 图片，凭证
        /// </summary>
        public System.String img { get; set; }

        /// <summary>
        /// 顺序
        /// </summary>
        public System.Int32 num { get; set; }
    }
}