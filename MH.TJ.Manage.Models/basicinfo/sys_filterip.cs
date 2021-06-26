

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// web系统表--过滤IP
    /// </summary>
    public class sys_filterip
    {
        /// <summary>
        /// web系统表--过滤IP
        /// </summary>
        public sys_filterip()
        {
        }

        /// <summary>
        /// 过滤主键
        /// </summary>
        public System.String F_Id { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public System.SByte? F_Type { get; set; }

        /// <summary>
        /// 开始IP
        /// </summary>
        public System.String F_StartIP { get; set; }

        /// <summary>
        /// 结束IP
        /// </summary>
        public System.String F_EndIP { get; set; }

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