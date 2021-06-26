

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 周计划表
    /// </summary>
    public class soc_week_plan
    {
        /// <summary>
        /// 周计划表
        /// </summary>
        public soc_week_plan()
        {
        }

        /// <summary>
        /// ID 主键
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// (月计划表 month_plan)计划单号: MHMP201911001
        /// </summary>
        public System.String mp_code { get; set; }

        /// <summary>
        /// 周计划单号(唯一):
        ///MHWP2019111001
        ///(mu hua week plan 201911月 第一周 001号计划)
        /// </summary>
        public System.String wp_code { get; set; }

        /// <summary>
        /// 月份 例: ’2019-11’
        /// </summary>
        public System.String month { get; set; }

        /// <summary>
        /// 1.第一周 
        ///2.第二周 
        ///3.第三周
        ///第四周
        /// </summary>
        public System.Int32? week_num { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        public System.DateTime? start_date { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        public System.DateTime? end_date { get; set; }

        /// <summary>
        /// 总项目数(计划数量)
        /// </summary>
        public System.Int32? total_count { get; set; }

        /// <summary>
        /// 完成数量
        /// </summary>
        public System.Int32? complete_count { get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        public System.Int32? dept_id { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public System.String dept_name { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 创建人Id
        /// </summary>
        public System.Int64? create_user_id { get; set; }

        /// <summary>
        /// 创建人姓名
        /// </summary>
        public System.String create_user_name { get; set; }
    }
}