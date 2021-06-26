

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// web系统表--角色授权表
    /// </summary>
    public class sys_roleauthorize
    {
        /// <summary>
        /// web系统表--角色授权表
        /// </summary>
        public sys_roleauthorize()
        {
        }

        /// <summary>
        /// 角色授权主键
        /// </summary>
        public System.String F_Id { get; set; }

        /// <summary>
        /// 项目类型1-模块2-按钮3-列表
        /// </summary>
        public System.Int32? F_ItemType { get; set; }

        /// <summary>
        /// 项目主键
        /// </summary>
        public System.String F_ItemId { get; set; }

        /// <summary>
        /// 对象分类1-角色2-部门-3用户
        /// </summary>
        public System.Int32? F_ObjectType { get; set; }

        /// <summary>
        /// 对象主键
        /// </summary>
        public System.String F_ObjectId { get; set; }

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