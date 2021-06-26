

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class sys_user
    {
        /// <summary>
        /// 用户表
        /// </summary>
        public sys_user()
        {
        }

        /// <summary>
        /// 用户主键
        /// </summary>
        public System.String F_Id { get; set; }

        /// <summary>
        /// 账户
        /// </summary>
        public System.String F_Account { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public System.String F_RealName { get; set; }

        /// <summary>
        /// 呢称
        /// </summary>
        public System.String F_NickName { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public System.String F_HeadIcon { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public System.SByte? F_Gender { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public System.DateTime? F_Birthday { get; set; }

        /// <summary>
        /// 手机
        /// </summary>
        public System.String F_MobilePhone { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public System.String F_Email { get; set; }

        /// <summary>
        /// 微信
        /// </summary>
        public System.String F_WeChat { get; set; }

        /// <summary>
        /// 主管主键
        /// </summary>
        public System.String F_ManagerId { get; set; }

        /// <summary>
        /// 安全级别
        /// </summary>
        public System.Int32? F_SecurityLevel { get; set; }

        /// <summary>
        /// 个性签名
        /// </summary>
        public System.String F_Signature { get; set; }

        /// <summary>
        /// 组织主键
        /// </summary>
        public System.String F_OrganizeId { get; set; }

        /// <summary>
        /// 部门主键
        /// </summary>
        public System.String F_DepartmentId { get; set; }

        /// <summary>
        /// 角色主键
        /// </summary>
        public System.String F_RoleId { get; set; }

        /// <summary>
        /// 岗位主键
        /// </summary>
        public System.String F_DutyId { get; set; }

        /// <summary>
        /// 是否管理员
        /// </summary>
        public System.SByte? F_IsAdministrator { get; set; }

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

        /// <summary>
        /// 审核医生机构 （医生专用）
        /// </summary>
        public System.String F_OrgID { get; set; }

        /// <summary>
        /// 错误记录
        /// </summary>
        public System.Int32? F_Error_Count { get; set; }
    }
}