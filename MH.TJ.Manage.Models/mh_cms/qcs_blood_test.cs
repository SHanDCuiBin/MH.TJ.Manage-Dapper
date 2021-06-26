

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 血检逻辑性
    /// </summary>
    public class qcs_blood_test
    {
        /// <summary>
        /// 血检逻辑性
        /// </summary>
        public qcs_blood_test()
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
        /// 尿糖与血糖
        /// </summary>
        public System.Int32? usugar_bsugar { get; set; }

        /// <summary>
        /// 总胆与高密度+低密
        /// </summary>
        public System.Int32? c_hdl_ldl { get; set; }

        /// <summary>
        /// 尿素+肌酐
        /// </summary>
        public System.Int32? UC { get; set; }

        /// <summary>
        /// 谷丙+谷草
        /// </summary>
        public System.Int32? saa_sgot { get; set; }

        /// <summary>
        /// 白细胞五分类计数
        /// </summary>
        public System.Int32? white_blood { get; set; }

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