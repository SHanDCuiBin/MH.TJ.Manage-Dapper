

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 档案打印需求表 -主表
    /// </summary>
    public class record_printing_requirement
    {
        /// <summary>
        /// 档案打印需求表 -主表
        /// </summary>
        public record_printing_requirement()
        {
        }

        /// <summary>
        /// 编号
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 年度
        /// </summary>
        public System.Int32? year { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 卫生院机构号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 卫生院名
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 创建人名
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 创建人账号
        /// </summary>
        public System.String create_user_id { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 更新人姓名
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
        /// 1为启用 0为禁用
        /// </summary>
        public System.Int32? enable { get; set; }

        /// <summary>
        /// 模板类型 0为通用模板 1为对应机构的模板
        /// </summary>
        public System.Int32? type { get; set; }

        /// <summary>
        /// 是否已确认 0为未确认 1为已确认
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
        /// 确认人姓名
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
        /// 个人基本信息列表
        /// </summary>
        public System.String person_information { get; set; }

        /// <summary>
        /// 是否显示首页  1为显示 0为不显示
        /// </summary>
        public System.Int32? is_show_shouye { get; set; }

        /// <summary>
        /// 是否显示健康体检表 1为显示 0为不显示
        /// </summary>
        public System.Int32? is_show_jktj { get; set; }

        /// <summary>
        /// 是否显示检验报告单 1为显示 0为不显示
        /// </summary>
        public System.Int32? is_show_jianyan { get; set; }

        /// <summary>
        /// 是否显示自理能力评估 1为显示 0为不显示
        /// </summary>
        public System.Int32? is_show_zlnl { get; set; }

        /// <summary>
        /// 是否显示中医体质 1为显示 0为不显示
        /// </summary>
        public System.Int32? is_show_zytz { get; set; }

        /// <summary>
        /// 是否显示摄盐 1为显示 0为不显示
        /// </summary>
        public System.Int32? is_show_sheyan { get; set; }

        /// <summary>
        /// 首页特殊需求文件地址
        /// </summary>
        public System.String shouye_tsxq_url { get; set; }

        /// <summary>
        /// 首页特殊需求文件名
        /// </summary>
        public System.String shouye_tsxq_name { get; set; }

        /// <summary>
        /// 健康体检特殊需求文件地址
        /// </summary>
        public System.String jktj_tsxq_url { get; set; }

        /// <summary>
        /// 健康体检特殊需求文件名
        /// </summary>
        public System.String jktj_tsxq_name { get; set; }

        /// <summary>
        /// 检验特殊需求文件地址
        /// </summary>
        public System.String jianyan_tsxq_url { get; set; }

        /// <summary>
        /// 检验特殊需求文件名
        /// </summary>
        public System.String jianyan_tsxq_name { get; set; }

        /// <summary>
        /// 自理能力特殊需求文件地址
        /// </summary>
        public System.String zlnl_tsxq_url { get; set; }

        /// <summary>
        /// 自理能力特殊需求文件名
        /// </summary>
        public System.String zlnl_tsxq_name { get; set; }

        /// <summary>
        /// 中医体质特殊需求文件地址
        /// </summary>
        public System.String zytz_tsxq_url { get; set; }

        /// <summary>
        /// 中医体质特殊需求文件名
        /// </summary>
        public System.String zytz_tsxq_name { get; set; }

        /// <summary>
        /// 摄盐特殊需求文件地址
        /// </summary>
        public System.String sheyan_tsxq_url { get; set; }

        /// <summary>
        /// 摄盐特殊需求文件名
        /// </summary>
        public System.String sheyan_tsxq_name { get; set; }
    }
}