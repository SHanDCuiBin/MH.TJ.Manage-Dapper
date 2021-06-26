

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// web系统表--组织表
    /// </summary>
    public class sys_organize
    {
        /// <summary>
        /// web系统表--组织表
        /// </summary>
        public sys_organize()
        {
        }

        /// <summary>
        /// 组织主键
        /// </summary>
        public System.String F_Id { get; set; }

        /// <summary>
        /// 父级
        /// </summary>
        public System.String F_ParentId { get; set; }

        /// <summary>
        /// 层次
        /// </summary>
        public System.Int32? F_Layers { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        public System.String F_EnCode { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public System.String F_FullName { get; set; }

        /// <summary>
        /// 简称
        /// </summary>
        public System.String F_ShortName { get; set; }

        /// <summary>
        /// 分类
        /// </summary>
        public System.String F_CategoryId { get; set; }

        /// <summary>
        /// 负责人
        /// </summary>
        public System.String F_ManagerId { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public System.String F_TelePhone { get; set; }

        /// <summary>
        /// 手机
        /// </summary>
        public System.String F_MobilePhone { get; set; }

        /// <summary>
        /// 微信
        /// </summary>
        public System.String F_WeChat { get; set; }

        /// <summary>
        /// 传真
        /// </summary>
        public System.String F_Fax { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public System.String F_Email { get; set; }

        /// <summary>
        /// 归属区域
        /// </summary>
        public System.String F_AreaId { get; set; }

        /// <summary>
        /// 联系地址
        /// </summary>
        public System.String F_Address { get; set; }

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