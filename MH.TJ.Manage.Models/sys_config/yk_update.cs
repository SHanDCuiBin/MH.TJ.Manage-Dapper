

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 自动升级（后台系统） 系统版本以及网卡信息表——主程序登录时记录信息所使用
    /// </summary>
    public class yk_update
    {
        /// <summary>
        /// 自动升级（后台系统） 系统版本以及网卡信息表——主程序登录时记录信息所使用
        /// </summary>
        public yk_update()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 主板序号
        /// </summary>
        public System.String board_serial { get; set; }

        /// <summary>
        /// 所属部门
        /// </summary>
        public System.String department { get; set; }

        /// <summary>
        /// 总版本号，主升级程序--登录次数
        /// </summary>
        public System.String full_version { get; set; }

        /// <summary>
        /// 主版本号,Main_Form
        /// </summary>
        public System.String main_version { get; set; }

        /// <summary>
        /// 是否启动   0禁止，1启动
        /// </summary>
        public System.String flag { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public System.DateTime? update_time { get; set; }

        /// <summary>
        /// 1主机2备---服务版本号+升级程序版本号，格式：*，*
        /// </summary>
        public System.String is_master { get; set; }

        /// <summary>
        /// IP地址-----上传标识  1.已上传  0.未上传
        /// </summary>
        public System.String master_ip { get; set; }
    }
}