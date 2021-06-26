

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 
    /// </summary>
    public class mh_permission
    {
        /// <summary>
        /// 
        /// </summary>
        public mh_permission()
        {
        }

        /// <summary>
        /// 权限编码，主键
        /// </summary>
        public System.String PermissionId { get; set; }

        /// <summary>
        /// 权限名称
        /// </summary>
        public System.String PermissionName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? Createtime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String Createuser { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? Updatetime { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public System.String Updateuser { get; set; }

        /// <summary>
        /// 删除状态。0：未删除，1：已删除
        /// </summary>
        public System.Int32? DelFlag { get; set; }
    }
}