

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 生化阳性率
    /// </summary>
    public class qcs_biochemical
    {
        /// <summary>
        /// 生化阳性率
        /// </summary>
        public qcs_biochemical()
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
        public System.String org_id { get; set; }

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
        /// 生化查体人数
        /// </summary>
        public System.Double? biochemical_count { get; set; }

        /// <summary>
        /// GLU>6.11
        /// </summary>
        public System.Int32? GLU6 { get; set; }

        /// <summary>
        /// 6.11<GLU≤7
        /// </summary>
        public System.Int32? GLU67 { get; set; }

        /// <summary>
        /// GLU>7
        /// </summary>
        public System.Int32? GLU7 { get; set; }

        /// <summary>
        /// 血糖最大值
        /// </summary>
        public System.Double? H_GLU { get; set; }

        /// <summary>
        /// 血糖最小值
        /// </summary>
        public System.Double? L_GLU { get; set; }

        /// <summary>
        /// 谷丙转氨酶
        /// </summary>
        public System.Int32? ALT { get; set; }

        /// <summary>
        /// 谷草转氨酶
        /// </summary>
        public System.Int32? AST { get; set; }

        /// <summary>
        /// 血尿素氮
        /// </summary>
        public System.Int32? UREA { get; set; }

        /// <summary>
        /// 血清肌酐
        /// </summary>
        public System.Int32? CRE { get; set; }

        /// <summary>
        /// 甘油三酯
        /// </summary>
        public System.Int32? TG { get; set; }

        /// <summary>
        /// 总胆固醇
        /// </summary>
        public System.Int32? TC { get; set; }

        /// <summary>
        /// 低密度脂蛋白
        /// </summary>
        public System.Double? LDL_C { get; set; }

        /// <summary>
        /// 高密度脂蛋白
        /// </summary>
        public System.Double? HDL_C { get; set; }

        /// <summary>
        /// 总胆红素
        /// </summary>
        public System.Int32? TBIL { get; set; }

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