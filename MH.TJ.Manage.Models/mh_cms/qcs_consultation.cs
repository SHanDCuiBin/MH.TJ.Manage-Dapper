

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 问诊阳性率
    /// </summary>
    public class qcs_consultation
    {
        /// <summary>
        /// 问诊阳性率
        /// </summary>
        public qcs_consultation()
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
        /// 齿列
        /// </summary>
        public System.Int32? dentition { get; set; }

        /// <summary>
        /// 听力
        /// </summary>
        public System.Int32? hearing { get; set; }

        /// <summary>
        /// 查体
        /// </summary>
        public System.Int32? physical_examination { get; set; }

        /// <summary>
        /// 吸烟
        /// </summary>
        public System.Int32? smoke { get; set; }

        /// <summary>
        /// 现存主要问题
        /// </summary>
        public System.Int32? problem { get; set; }

        /// <summary>
        /// 用药情况
        /// </summary>
        public System.Int32? medication { get; set; }

        /// <summary>
        /// 饮酒
        /// </summary>
        public System.Int32? drink_wine { get; set; }

        /// <summary>
        /// 锻炼
        /// </summary>
        public System.Int32? physical_exercise { get; set; }

        /// <summary>
        /// 饮食
        /// </summary>
        public System.Int32? diet { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? creation_time { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? revision_time { get; set; }

        /// <summary>
        /// 视力
        /// </summary>
        public System.Int32? vision { get; set; }

        /// <summary>
        /// 足背脉搏
        /// </summary>
        public System.Int32? foot_pulse { get; set; }
    }
}