
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 肺结核筛查信息表 （陕西合阳使用）--记录肺结核筛查的数据
    /// </summary>
    public class mh_fjhsc
    {
        /// <summary>
        /// 肺结核筛查信息表 （陕西合阳使用）--记录肺结核筛查的数据
        /// </summary>
        public mh_fjhsc()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String fjhid { get; set; }

        /// <summary>
        /// 老年人沐华编号
        /// </summary>
        public System.String mh_card { get; set; }

        /// <summary>
        /// 年度
        /// </summary>
        public System.String year { get; set; }

        /// <summary>
        /// 条码号
        /// </summary>
        public System.String tmh { get; set; }

        /// <summary>
        /// 体检日期
        /// </summary>
        public System.DateTime? tjrq { get; set; }

        /// <summary>
        /// 机构编号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 肺结核可疑症状
        /// </summary>
        public System.String fjh_kyzz { get; set; }

        /// <summary>
        /// 高危因素
        /// </summary>
        public System.String fjh_gwys { get; set; }

        /// <summary>
        /// 肺结核X光检查描述
        /// </summary>
        public System.String fjh_xguang_ms { get; set; }

        /// <summary>
        /// 肺结核X光检查结论
        /// </summary>
        public System.String fjh_xguang { get; set; }

        /// <summary>
        /// 肺结核X光检查医生
        /// </summary>
        public System.String fjh_xgys { get; set; }

        /// <summary>
        /// 初步筛查结果
        /// </summary>
        public System.String fjh_scjg { get; set; }

        /// <summary>
        /// 初步筛查医生
        /// </summary>
        public System.String fjh_scys { get; set; }

        /// <summary>
        /// 初步筛查日期
        /// </summary>
        public System.DateTime? fjh_scrq { get; set; }

        /// <summary>
        /// 肺结核处理  转诊单位
        /// </summary>
        public System.String fjh_zzdw { get; set; }

        /// <summary>
        /// 转诊医生
        /// </summary>
        public System.String fjh_zzys { get; set; }

        /// <summary>
        /// 转诊日期
        /// </summary>
        public System.DateTime? fjh_zzrq { get; set; }

        /// <summary>
        /// 定点医院诊断结论
        /// </summary>
        public System.String fjh_ddyyzd { get; set; }

        /// <summary>
        /// 定点医院诊断医生
        /// </summary>
        public System.String fjh_zdys { get; set; }

        /// <summary>
        /// 定点医院诊断日期
        /// </summary>
        public System.DateTime? fjh_zdrq { get; set; }

        /// <summary>
        /// 肺结核备注
        /// </summary>
        public System.String fjh_remark { get; set; }
    }
}