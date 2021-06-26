
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 老年人体检采集  自理能力表
    /// </summary>
    public class mh_zlnl
    {
        /// <summary>
        /// 老年人体检采集  自理能力表
        /// </summary>
        public mh_zlnl()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String mh_card { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 year { get; set; }

        /// <summary>
        /// 评分1
        /// </summary>
        public System.Int32? pf1 { get; set; }

        /// <summary>
        /// 评分2
        /// </summary>
        public System.Int32? pf2 { get; set; }

        /// <summary>
        /// 评分3
        /// </summary>
        public System.Int32? pf3 { get; set; }

        /// <summary>
        /// 评分4
        /// </summary>
        public System.Int32? pf4 { get; set; }

        /// <summary>
        /// 评分5
        /// </summary>
        public System.Int32? pf5 { get; set; }

        /// <summary>
        /// 总评分
        /// </summary>
        public System.Int32? zpf { get; set; }

        /// <summary>
        /// 随访日期
        /// </summary>
        public System.DateTime? sfrq { get; set; }

        /// <summary>
        /// 下次随访日期
        /// </summary>
        public System.DateTime? xcsfrq { get; set; }

        /// <summary>
        /// 随方医生签名
        /// </summary>
        public System.String sfysqm { get; set; }

        /// <summary>
        /// 机构号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 创建机构名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 创建人ID号
        /// </summary>
        public System.String create_user_id { get; set; }

        /// <summary>
        /// 录入人姓名
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 更新人ID号
        /// </summary>
        public System.String update_user_id { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public System.DateTime? update_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String remark { get; set; }
    }
}