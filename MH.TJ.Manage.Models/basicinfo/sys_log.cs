

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// web系统表--系统日志
    /// </summary>
    public class sys_log
    {
        /// <summary>
        /// web系统表--系统日志
        /// </summary>
        public sys_log()
        {
        }

        /// <summary>
        /// 日志主键
        /// </summary>
        public System.String F_Id { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        public System.DateTime? F_Date { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public System.String F_Account { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public System.String F_NickName { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public System.String F_Type { get; set; }

        /// <summary>
        /// IP地址
        /// </summary>
        public System.String F_IPAddress { get; set; }

        /// <summary>
        /// IP所在城市
        /// </summary>
        public System.String F_IPAddressName { get; set; }

        /// <summary>
        /// 系统模块Id
        /// </summary>
        public System.String F_ModuleId { get; set; }

        /// <summary>
        /// 系统模块
        /// </summary>
        public System.String F_ModuleName { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        public System.SByte? F_Result { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public System.String F_Description { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? F_CreatorTime { get; set; }

        /// <summary>
        /// 创建用户
        /// </summary>
        public System.String F_CreatorUserId { get; set; }
    }
}