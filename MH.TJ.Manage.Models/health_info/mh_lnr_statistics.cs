
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 老年人统计总表 ------ 用于老年人数据统计导出
    /// </summary>
    public class mh_lnr_statistics
    {
        /// <summary>
        /// 老年人统计总表 ------ 用于老年人数据统计导出
        /// </summary>
        public mh_lnr_statistics()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 年度
        /// </summary>
        public System.String year { get; set; }

        /// <summary>
        /// 机构名
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 机构号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 总人数
        /// </summary>
        public System.Int32? all_count { get; set; }

        /// <summary>
        /// 男性人数
        /// </summary>
        public System.Int32? man_count { get; set; }

        /// <summary>
        /// 女性人数
        /// </summary>
        public System.Int32? woman_count { get; set; }

        /// <summary>
        /// 年龄段1
        /// </summary>
        public System.String age1 { get; set; }

        /// <summary>
        /// 年龄段1总人数
        /// </summary>
        public System.Int32? age1_count { get; set; }

        /// <summary>
        /// 年龄段1男性人数
        /// </summary>
        public System.Int32? age1_man { get; set; }

        /// <summary>
        /// 年龄段1女性人数
        /// </summary>
        public System.Int32? age1_woman { get; set; }

        /// <summary>
        /// 年龄段2
        /// </summary>
        public System.String age2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? age2_man { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? age2_woman { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? age2_count { get; set; }

        /// <summary>
        /// 年龄段3
        /// </summary>
        public System.String age3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? age3_man { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? age3_woman { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? age3_count { get; set; }

        /// <summary>
        /// 年龄段4
        /// </summary>
        public System.String age4 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? age4_man { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? age4_woman { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? age4_count { get; set; }

        /// <summary>
        /// 年龄段5
        /// </summary>
        public System.String age5 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? age5_man { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? age5_woman { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? age5_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String age6 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? age6_woman { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? age6_man { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? age6_count { get; set; }
    }
}