

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// web系统表--系统模块
    /// </summary>
    public class sys_module
    {
        /// <summary>
        /// web系统表--系统模块
        /// </summary>
        public sys_module()
        {
        }

        /// <summary>
        /// 模块主键
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
        /// 图标
        /// </summary>
        public System.String F_Icon { get; set; }

        /// <summary>
        /// 连接
        /// </summary>
        public System.String F_UrlAddress { get; set; }

        /// <summary>
        /// 目标
        /// </summary>
        public System.String F_Target { get; set; }

        /// <summary>
        /// 菜单
        /// </summary>
        public System.SByte? F_IsMenu { get; set; }

        /// <summary>
        /// 展开
        /// </summary>
        public System.SByte? F_IsExpand { get; set; }

        /// <summary>
        /// 公共
        /// </summary>
        public System.SByte? F_IsPublic { get; set; }

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
        /// 创建日期
        /// </summary>
        public System.DateTime? F_CreatorTime { get; set; }

        /// <summary>
        /// 创建用户主键
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