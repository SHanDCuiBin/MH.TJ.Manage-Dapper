

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 数据完整性
    /// </summary>
    public class qcs_data_integrity
    {
        /// <summary>
        /// 数据完整性
        /// </summary>
        public qcs_data_integrity()
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
        /// 现场照
        /// </summary>
        public System.Int32? scene_photo { get; set; }

        /// <summary>
        /// 证件照
        /// </summary>
        public System.Int32? ID_photo { get; set; }

        /// <summary>
        /// 中医体质
        /// </summary>
        public System.Int32? TCM_system { get; set; }

        /// <summary>
        /// B超
        /// </summary>
        public System.Int32? b_mode { get; set; }

        /// <summary>
        /// B超图片
        /// </summary>
        public System.Int32? b_modepicture { get; set; }

        /// <summary>
        /// 心电图
        /// </summary>
        public System.Int32? ECG { get; set; }

        /// <summary>
        /// 心电图片
        /// </summary>
        public System.Int32? ECG_picture { get; set; }

        /// <summary>
        /// 生化
        /// </summary>
        public System.Int32? biochemistry { get; set; }

        /// <summary>
        /// 血球
        /// </summary>
        public System.Int32? blood_cell { get; set; }

        /// <summary>
        /// 尿检
        /// </summary>
        public System.Int32? urine_test { get; set; }

        /// <summary>
        /// 身高模块
        /// </summary>
        public System.Int32? height { get; set; }

        /// <summary>
        /// 血压模块
        /// </summary>
        public System.Int32? blood_pressure { get; set; }

        /// <summary>
        /// 查体
        /// </summary>
        public System.Int32? physical_examination { get; set; }

        /// <summary>
        /// 症状
        /// </summary>
        public System.Int32? symptom { get; set; }

        /// <summary>
        /// 生活方式
        /// </summary>
        public System.Int32? lifestyle { get; set; }

        /// <summary>
        /// 自理能力
        /// </summary>
        public System.Int32? ability { get; set; }

        /// <summary>
        /// 脏器功能
        /// </summary>
        public System.Int32? viscera { get; set; }

        /// <summary>
        /// 现存主要问题
        /// </summary>
        public System.Int32? problem { get; set; }

        /// <summary>
        /// X光
        /// </summary>
        public System.Int32? X_ray { get; set; }

        /// <summary>
        /// X光图片
        /// </summary>
        public System.Int32? X_raypicture { get; set; }

        /// <summary>
        /// 肿瘤
        /// </summary>
        public System.Int32? tumour { get; set; }

        /// <summary>
        /// 女性人数
        /// </summary>
        public System.Int32? woman { get; set; }

        /// <summary>
        /// 妇科
        /// </summary>
        public System.Int32? gynaecology { get; set; }

        /// <summary>
        /// 乙肝
        /// </summary>
        public System.Int32? hepatitis_B { get; set; }

        /// <summary>
        /// 家医签约
        /// </summary>
        public System.Int32? family_doctor { get; set; }

        /// <summary>
        /// 简易评估
        /// </summary>
        public System.Int32? assessment { get; set; }

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