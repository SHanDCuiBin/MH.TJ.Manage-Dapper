

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 设备版本信息表--记录设备的软件更新情况
    /// </summary>
    public class mh_update_jktj
    {
        /// <summary>
        /// 设备版本信息表--记录设备的软件更新情况
        /// </summary>
        public mh_update_jktj()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String update_id { get; set; }

        /// <summary>
        /// 主板序号(MAC地址)
        /// </summary>
        public System.String board_serial { get; set; }

        /// <summary>
        /// 注册信息
        /// </summary>
        public System.String zc_code { get; set; }

        /// <summary>
        /// 电脑类型    1公司 /2医院
        /// </summary>
        public System.String computer_type { get; set; }

        /// <summary>
        /// 软件类型    1 采集软件  2 审核软件
        /// </summary>
        public System.String soft_type { get; set; }

        /// <summary>
        /// 是否启用更新
        /// </summary>
        public System.String is_enable { get; set; }

        /// <summary>
        /// 所属区域
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 所属机构名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 总版本号，主升级程序
        /// </summary>
        public System.String full_version { get; set; }

        /// <summary>
        /// 主版本号,Main_Form
        /// </summary>
        public System.String main_version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String flag { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public System.DateTime? update_time { get; set; }

        /// <summary>
        /// IP地址
        /// </summary>
        public System.String master_ip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String user_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String user_name { get; set; }
    }
}