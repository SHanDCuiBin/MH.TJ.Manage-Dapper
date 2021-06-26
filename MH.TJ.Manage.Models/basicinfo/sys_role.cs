

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// web系统表--角色表
    /// </summary>
    public class sys_role
    {
        /// <summary>
        /// web系统表--角色表
        /// </summary>
        public sys_role()
        {
        }

        /// <summary>
        /// 角色主键
        /// </summary>
        public System.String F_Id { get; set; }

        /// <summary>
        /// 组织主键
        /// </summary>
        public System.String F_OrganizeId { get; set; }

        /// <summary>
        /// 分类:1-角色2-岗位
        /// </summary>
        public System.Int32? F_Category { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        public System.String F_EnCode { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public System.String F_FullName { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public System.String F_Type { get; set; }

        /// <summary>
        /// 允许编辑
        /// </summary>
        public System.SByte? F_AllowEdit { get; set; }

        /// <summary>
        /// 允许删除
        /// </summary>
        public System.SByte? F_AllowDelete { get; set; }

        /// <summary>
        /// 排序码
        /// </summary>
        public System.Int32? F_SortCode { get; set; }

        /// <summary>
        /// 删除标志
        /// </summary>
        public System.SByte? F_DeleteMark { get; set; }

        /// <summary>
        /// 有效标志
        /// </summary>
        public System.SByte? F_EnabledMark { get; set; }

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

        /// <summary>
        /// 最后修改时间
        /// </summary>
        public System.DateTime? F_LastModifyTime { get; set; }

        /// <summary>
        /// 最后修改用户
        /// </summary>
        public System.String F_LastModifyUserId { get; set; }

        /// <summary>
        /// 删除时间
        /// </summary>
        public System.DateTime? F_DeleteTime { get; set; }

        /// <summary>
        /// 删除用户
        /// </summary>
        public System.String F_DeleteUserId { get; set; }
    }
}