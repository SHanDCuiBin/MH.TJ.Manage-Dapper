

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 
    /// </summary>
    public class doctor_auth_user_role
    {
        /// <summary>
        /// 
        /// </summary>
        public doctor_auth_user_role()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 院内用户主键
        /// </summary>
        public System.String AuthUserId { get; set; }

        /// <summary>
        /// 角色主键
        /// </summary>
        public System.String SysRoleId { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String Create_user { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? Create_time { get; set; }

        /// <summary>
        /// 删除标识
        /// </summary>
        public System.SByte? DeleteMark { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        public System.DateTime? LastModifyTime { get; set; }

        /// <summary>
        /// 最后修改人
        /// </summary>
        public System.String LastModifyUserId { get; set; }

        /// <summary>
        /// 院内用户账号
        /// </summary>
        public System.String UserId { get; set; }

        /// <summary>
        /// 角色代码
        /// </summary>
        public System.String EnCode { get; set; }
    }
}