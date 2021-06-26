
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 
    /// </summary>
    public class mh_jktj_psychological
    {
        /// <summary>
        /// 
        /// </summary>
        public mh_jktj_psychological()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? age { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String sex { get; set; }

        /// <summary>
        /// 心里咨询系统Uniques字段，沐华条码号
        /// </summary>
        public System.String tmh { get; set; }

        /// <summary>
        /// 测试类型：老年抑郁量表(GDS)
        /// </summary>
        public System.String lbm { get; set; }

        /// <summary>
        /// 体检id
        /// </summary>
        public System.String tjid { get; set; }

        /// <summary>
        /// 机构号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String ysm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String bzf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String jf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String bzc { get; set; }

        /// <summary>
        /// 测试结果
        /// </summary>
        public System.String yj { get; set; }

        /// <summary>
        /// 预警等级（1 三级预警； 2 二级预警； 3 一级预警 ； 0 正常 ； -1 其他预警）
        /// </summary>
        public System.String warting { get; set; }

        /// <summary>
        /// 测试时间
        /// </summary>
        public System.DateTime cssj { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String xx { get; set; }

        /// <summary>
        /// 生活建议
        /// </summary>
        public System.String dailyAdvice { get; set; }

        /// <summary>
        /// 饮食建议
        /// </summary>
        public System.String dietAdvice { get; set; }
    }
}