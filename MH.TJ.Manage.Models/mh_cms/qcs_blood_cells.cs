

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 血球阳性率
    /// </summary>
    public class qcs_blood_cells
    {
        /// <summary>
        /// 血球阳性率
        /// </summary>
        public qcs_blood_cells()
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
        /// 血检人数
        /// </summary>
        public System.Int32? blood_count { get; set; }

        /// <summary>
        /// 白细胞计数
        /// </summary>
        public System.Int32? WBC { get; set; }

        /// <summary>
        /// 白细胞计数最大值
        /// </summary>
        public System.Double? H_WBC { get; set; }

        /// <summary>
        /// 白细胞计数最小值
        /// </summary>
        public System.Double? L_WBC { get; set; }

        /// <summary>
        /// 红细胞计数
        /// </summary>
        public System.Int32? RBC { get; set; }

        /// <summary>
        /// 红细胞计数最大值
        /// </summary>
        public System.Double? H_RBC { get; set; }

        /// <summary>
        /// 红细胞计数最大值
        /// </summary>
        public System.Double? L_RBC { get; set; }

        /// <summary>
        /// 血红蛋白浓度
        /// </summary>
        public System.Int32? HGB { get; set; }

        /// <summary>
        /// 血红蛋白浓度最大值
        /// </summary>
        public System.Double? H_HGB { get; set; }

        /// <summary>
        /// 血红蛋白浓度最小值
        /// </summary>
        public System.Double? L_HGB { get; set; }

        /// <summary>
        /// 血小板计数
        /// </summary>
        public System.Int32? PLT { get; set; }

        /// <summary>
        /// 血小板计数最大值
        /// </summary>
        public System.Double? H_PLT { get; set; }

        /// <summary>
        /// 血小板计数最小值
        /// </summary>
        public System.Double? L_PLT { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? creation_time { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? revision_time { get; set; }

        /// <summary>
        /// 白细胞偏高计数
        /// </summary>
        public System.Int32? WBC_H { get; set; }

        /// <summary>
        /// 白细胞偏低计数
        /// </summary>
        public System.Int32? WBC_L { get; set; }

        /// <summary>
        /// 红细胞偏高计数
        /// </summary>
        public System.Int32? RBC_H { get; set; }

        /// <summary>
        /// 红细胞偏低计数
        /// </summary>
        public System.Int32? RBC_L { get; set; }

        /// <summary>
        /// 血红蛋白偏高计数
        /// </summary>
        public System.Int32? HGB_H { get; set; }

        /// <summary>
        /// 血红蛋白偏低计数
        /// </summary>
        public System.Int32? HGB_L { get; set; }

        /// <summary>
        /// 血小板偏高计数
        /// </summary>
        public System.Int32? PLT_H { get; set; }

        /// <summary>
        /// 血小板偏低计数
        /// </summary>
        public System.Int32? PLT_L { get; set; }
    }
}