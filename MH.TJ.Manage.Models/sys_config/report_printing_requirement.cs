

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 报告需求采集表
    /// </summary>
    public class report_printing_requirement
    {
        /// <summary>
        /// 报告需求采集表
        /// </summary>
        public report_printing_requirement()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 年度
        /// </summary>
        public System.Int32? year { get; set; }

        /// <summary>
        /// 机构号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 机构名
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 创建时间  系统自动创建，不需要创建人
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 更新人
        /// </summary>
        public System.String update_user_name { get; set; }

        /// <summary>
        /// 更新人账号
        /// </summary>
        public System.String update_user_id { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public System.DateTime? update_time { get; set; }

        /// <summary>
        /// 是否已提供信息 0为未提供 1为已提供
        /// </summary>
        public System.Int32? is_provide_info { get; set; }

        /// <summary>
        /// 是否确认 0为未确认 1为已确认
        /// </summary>
        public System.Int32? is_confirm { get; set; }

        /// <summary>
        /// 确认手机号
        /// </summary>
        public System.String confirm_phone { get; set; }

        /// <summary>
        /// 确认验证码
        /// </summary>
        public System.String confirm_verify_code { get; set; }

        /// <summary>
        /// 确认验证码发送时间
        /// </summary>
        public System.DateTime? confirm_send_time { get; set; }

        /// <summary>
        /// 确认人
        /// </summary>
        public System.String confirm_user_name { get; set; }

        /// <summary>
        /// 确认人账号
        /// </summary>
        public System.String confirm_user_id { get; set; }

        /// <summary>
        /// 确认时间
        /// </summary>
        public System.DateTime? confirm_time { get; set; }

        /// <summary>
        /// 是否已上传报告模板 0为未上传 1为已上传
        /// </summary>
        public System.Int32? is_upload_template { get; set; }

        /// <summary>
        /// 报告模板上传人
        /// </summary>
        public System.String upload_template_user_name { get; set; }

        /// <summary>
        /// 报告模板上传人账号
        /// </summary>
        public System.String upload_template_user_id { get; set; }

        /// <summary>
        /// 报告模板上传时间
        /// </summary>
        public System.DateTime? upload_template_time { get; set; }

        /// <summary>
        /// 上传的文件名字
        /// </summary>
        public System.String upload_template_name { get; set; }

        /// <summary>
        /// 报告模板阿里云的保存地址
        /// </summary>
        public System.String upload_template_url { get; set; }

        /// <summary>
        /// 模板医院全名
        /// </summary>
        public System.String template_hospital_name { get; set; }

        /// <summary>
        /// 模板二维码地址
        /// </summary>
        public System.String template_qr_code { get; set; }

        /// <summary>
        /// 模板联系电话
        /// </summary>
        public System.String template_contact_phone { get; set; }

        /// <summary>
        /// 模板是否历年对比 0为不展示 1为展示
        /// </summary>
        public System.Int32? template_year_compare { get; set; }

        /// <summary>
        /// 模板身高体重医生名字
        /// </summary>
        public System.String template_sgtz_ys { get; set; }

        /// <summary>
        /// 模板血压医生名字
        /// </summary>
        public System.String template_xy_ys { get; set; }

        /// <summary>
        /// 模板尿常规检验者
        /// </summary>
        public System.String template_ncg_jyz { get; set; }

        /// <summary>
        /// 模板尿常规审核者
        /// </summary>
        public System.String template_ncg_shz { get; set; }

        /// <summary>
        /// 模板生化检验者
        /// </summary>
        public System.String template_sh_jyz { get; set; }

        /// <summary>
        /// 模板生化审核者
        /// </summary>
        public System.String template_sh_shz { get; set; }

        /// <summary>
        /// 模板血常规检验者
        /// </summary>
        public System.String template_xcg_jyz { get; set; }

        /// <summary>
        /// 模板血常规审核者
        /// </summary>
        public System.String template_xcg_shz { get; set; }

        /// <summary>
        /// 模板心电图诊断医生
        /// </summary>
        public System.String template_xdt_ys { get; set; }

        /// <summary>
        /// 模板B超医生
        /// </summary>
        public System.String template_bc_ys { get; set; }

        /// <summary>
        /// 模板质控医生
        /// </summary>
        public System.String template_zk_ys { get; set; }
    }
}