

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 尿检阳性率
    /// </summary>
    public class qcs_urine_test
    {
        /// <summary>
        /// 尿检阳性率
        /// </summary>
        public qcs_urine_test()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// 查体信息id
        /// </summary>
        public System.String ctxx_id { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        public System.String task_id { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        public System.String city { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        public System.Int32? org_id { get; set; }

        /// <summary>
        /// 机构名
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 负责人id
        /// </summary>
        public System.Int32? user_id { get; set; }

        /// <summary>
        /// 负责名
        /// </summary>
        public System.String user_name { get; set; }

        /// <summary>
        /// 负责人账号
        /// </summary>
        public System.String user { get; set; }

        /// <summary>
        /// 体检日期
        /// </summary>
        public System.DateTime? tjrq { get; set; }

        /// <summary>
        /// 查体总人数
        /// </summary>
        public System.Int32? person_count { get; set; }

        /// <summary>
        /// 尿检查体人数
        /// </summary>
        public System.Int32? urine_test_count { get; set; }

        /// <summary>
        /// 3≤五大项阳性<5
        /// </summary>
        public System.String wdx35 { get; set; }

        /// <summary>
        /// 五大项全为阳性
        /// </summary>
        public System.String wdx { get; set; }

        /// <summary>
        /// 尿蛋白
        /// </summary>
        public System.Int32? urine_protein { get; set; }

        /// <summary>
        /// 尿糖
        /// </summary>
        public System.Int32? urine_sugar { get; set; }

        /// <summary>
        /// 尿潜血
        /// </summary>
        public System.Int32? bld { get; set; }

        /// <summary>
        /// 尿酮体
        /// </summary>
        public System.Int32? KBT { get; set; }

        /// <summary>
        /// 尿白细胞
        /// </summary>
        public System.Int32? lbu { get; set; }

        /// <summary>
        /// 亚硝酸盐
        /// </summary>
        public System.Int32? nitrite { get; set; }

        /// <summary>
        /// 尿胆红素
        /// </summary>
        public System.Int32? BIL { get; set; }

        /// <summary>
        /// 尿胆原
        /// </summary>
        public System.Int32? URO { get; set; }

        /// <summary>
        /// 抗坏血酸
        /// </summary>
        public System.Int32? ascorbic_acid { get; set; }

        /// <summary>
        /// 尿比重
        /// </summary>
        public System.Int32? usg { get; set; }

        /// <summary>
        /// 尿酸碱值
        /// </summary>
        public System.Int32? urine_pH { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? creation_time { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? revision_time { get; set; }
    }
}