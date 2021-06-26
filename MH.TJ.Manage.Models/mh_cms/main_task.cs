

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 主任务表-
    /// </summary>
    public class main_task
    {
        /// <summary>
        /// 主任务表-
        /// </summary>
        public main_task()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        public System.String orgid { get; set; }

        /// <summary>
        /// 年度
        /// </summary>
        public System.String year { get; set; }

        /// <summary>
        /// 状态 1开始  2结束 3暂停
        /// </summary>
        public System.String status { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public System.DateTime? createdate { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        public System.DateTime? startdate { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        public System.DateTime? enddate { get; set; }

        /// <summary>
        /// 查体类型 1 老年人 2 儿童 幼儿园 3 中小学生 4 教师  5 职工 6  其他 
        /// </summary>
        public System.Int32? checktype { get; set; }
    }
}