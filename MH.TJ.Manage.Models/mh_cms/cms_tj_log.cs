

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 流程不合格 日志
    /// </summary>
    public class cms_tj_log
    {
        /// <summary>
        /// 流程不合格 日志
        /// </summary>
        public cms_tj_log()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.String ID { get; set; }

        /// <summary>
        /// 体检表id
        /// </summary>
        public System.String TJ_ID { get; set; }

        /// <summary>
        /// 不合格表名
        /// </summary>
        public System.String TABLE_NAME { get; set; }

        /// <summary>
        /// 不合格表id
        /// </summary>
        public System.String TABLE_ID { get; set; }

        /// <summary>
        /// 不合格人id
        /// </summary>
        public System.String BHG_USER_ID { get; set; }

        /// <summary>
        /// 审核人id
        /// </summary>
        public System.String SHR_USER_ID { get; set; }

        /// <summary>
        /// 不合格原因
        /// </summary>
        public System.String BHG_REASON { get; set; }

        /// <summary>
        /// 不合格份数
        /// </summary>
        public System.Int32? BHG_COUNT { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public System.DateTime? TIME { get; set; }

        /// <summary>
        /// 不合格说明
        /// </summary>
        public System.String BHG_SM { get; set; }

        /// <summary>
        /// 不合格人姓名
        /// </summary>
        public System.String BHG_USER_NAME { get; set; }

        /// <summary>
        /// 审核人姓名
        /// </summary>
        public System.String SHR_USER_NAME { get; set; }

        /// <summary>
        /// 不合格位置标记1.报告打印审核2.档案打印审核3.数据处理审核
        /// </summary>
        public System.Int32? BHG_POSITION { get; set; }
    }
}