

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 跟班记录表
    /// </summary>
    public class cms_partnerrecord
    {
        /// <summary>
        /// 跟班记录表
        /// </summary>
        public cms_partnerrecord()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        public System.String taskid { get; set; }

        /// <summary>
        /// 跟班人id
        /// </summary>
        public System.String userid { get; set; }

        /// <summary>
        /// 跟班人姓名
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public System.DateTime? createdate { get; set; }

        /// <summary>
        /// 调离日期
        /// </summary>
        public System.DateTime? leavedate { get; set; }

        /// <summary>
        /// 状态 1正常工作 0 暂停   2结束 3未开始  4调配，不在该任务中工作 5作废（未开始被调配）
        /// </summary>
        public System.String status { get; set; }

        /// <summary>
        /// 绩效分配占比
        /// </summary>
        public System.Int32 flag { get; set; }
    }
}