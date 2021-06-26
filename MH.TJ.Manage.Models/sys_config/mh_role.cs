

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 
    /// </summary>
    public class mh_role
    {
        /// <summary>
        /// 
        /// </summary>
        public mh_role()
        {
        }

        /// <summary>
        /// 角色编码，主键
        /// </summary>
        public System.String RoleId { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        public System.String RoleName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String Remark { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? Createtime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String CreatUser { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public System.DateTime? Updatetime { get; set; }

        /// <summary>
        /// 更新人
        /// </summary>
        public System.String UpdateUser { get; set; }

        /// <summary>
        /// 删除状态。0：未删除，1：删除
        /// </summary>
        public System.Int32? DelFlag { get; set; }
    }
}