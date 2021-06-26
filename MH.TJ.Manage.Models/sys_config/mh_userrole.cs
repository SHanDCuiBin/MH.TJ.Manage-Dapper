

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 
    /// </summary>
    public class mh_userrole
    {
        /// <summary>
        /// 
        /// </summary>
        public mh_userrole()
        {
        }

        /// <summary>
        /// 主键编码
        /// </summary>
        public System.String Id { get; set; }

        /// <summary>
        /// 人员编码，关联人员信息表
        /// </summary>
        public System.Int32? UserId { get; set; }

        /// <summary>
        /// 角色编码，关联角色信息表
        /// </summary>
        public System.String RoleId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? Createtime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String CreatUser { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? Updatetime { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public System.String UpdateUser { get; set; }

        /// <summary>
        /// 删除状态。0：未删除，1：删除
        /// </summary>
        public System.Int32? DelFlag { get; set; }
    }
}