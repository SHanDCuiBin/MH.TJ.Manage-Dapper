

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// web系统表--模块表单实例
    /// </summary>
    public class sys_moduleforminstance
    {
        /// <summary>
        /// web系统表--模块表单实例
        /// </summary>
        public sys_moduleforminstance()
        {
        }

        /// <summary>
        /// 表单实例主键
        /// </summary>
        public System.String F_Id { get; set; }

        /// <summary>
        /// 表单主键
        /// </summary>
        public System.String F_FormId { get; set; }

        /// <summary>
        /// 对象主键
        /// </summary>
        public System.String F_ObjectId { get; set; }

        /// <summary>
        /// 表单实例Json
        /// </summary>
        public System.String F_InstanceJson { get; set; }

        /// <summary>
        /// 排序码
        /// </summary>
        public System.Int32? F_SortCode { get; set; }

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