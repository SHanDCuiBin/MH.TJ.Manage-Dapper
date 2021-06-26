

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 每日bug数
    /// </summary>
    public class zentao_paper
    {
        /// <summary>
        /// 每日bug数
        /// </summary>
        public zentao_paper()
        {
        }

        /// <summary>
        /// uuid
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        public System.String account { get; set; }

        /// <summary>
        /// 团队
        /// </summary>
        public System.String team { get; set; }

        /// <summary>
        /// 任务总数
        /// </summary>
        public System.Int32? sum { get; set; }

        /// <summary>
        /// 今日已完成数
        /// </summary>
        public System.Int32? finshed { get; set; }

        /// <summary>
        /// 无截止时间任务数
        /// </summary>
        public System.Int32? nodeadline { get; set; }

        /// <summary>
        /// 延期任务数
        /// </summary>
        public System.Int32? postpone { get; set; }

        /// <summary>
        /// 今日新增bug数
        /// </summary>
        public System.Int32? additional { get; set; }

        /// <summary>
        /// 待关闭任务数
        /// </summary>
        public System.Int32? closed { get; set; }

        /// <summary>
        /// 统计日期
        /// </summary>
        public System.DateTime? creat_date { get; set; }
    }
}