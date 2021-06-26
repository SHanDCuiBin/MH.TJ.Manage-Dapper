
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 
    /// </summary>
    public class mh_jktj_eyescreening
    {
        /// <summary>
        /// 
        /// </summary>
        public mh_jktj_eyescreening()
        {
        }

        /// <summary>
        /// 检查ID
        /// </summary>
        public System.String exam_id { get; set; }

        /// <summary>
        /// 条码号
        /// </summary>
        public System.String tmh { get; set; }

        /// <summary>
        /// 身份证
        /// </summary>
        public System.String id_card { get; set; }

        /// <summary>
        /// I：身份证,P：护照,O：军官证
        /// </summary>
        public System.String id_type { get; set; }

        /// <summary>
        /// 沐华档案号
        /// </summary>
        public System.String mh_card { get; set; }

        /// <summary>
        /// 性别 1男；2女
        /// </summary>
        public System.String gender { get; set; }

        /// <summary>
        /// 患者姓名
        /// </summary>
        public System.String patient_name { get; set; }

        /// <summary>
        /// 患者手机号
        /// </summary>
        public System.String telephone { get; set; }

        /// <summary>
        /// 检查时间
        /// </summary>
        public System.DateTime exam_create_date { get; set; }

        /// <summary>
        /// 诊断结果
        /// </summary>
        public System.String exam_result { get; set; }

        /// <summary>
        /// 检查类型
        /// </summary>
        public System.String exam_type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime create_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? update_time { get; set; }

        /// <summary>
        /// 右眼眼底状态(正常/异常）
        /// </summary>
        public System.String OD_state { get; set; }

        /// <summary>
        /// 左眼眼底状态(正常/异常)
        /// </summary>
        public System.String OS_state { get; set; }

        /// <summary>
        /// 患者创建时间
        /// </summary>
        public System.DateTime? patient_create_date { get; set; }

        /// <summary>
        /// 左眼图1
        /// </summary>
        public System.String img_left1 { get; set; }

        /// <summary>
        /// 左眼图2
        /// </summary>
        public System.String img_left2 { get; set; }

        /// <summary>
        /// 右眼图1
        /// </summary>
        public System.String img_right1 { get; set; }

        /// <summary>
        /// 右眼图2
        /// </summary>
        public System.String img_right2 { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public System.DateTime? birthday { get; set; }
    }
}