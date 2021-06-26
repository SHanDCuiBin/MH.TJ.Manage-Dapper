

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// web系统表--数据库备份
    /// </summary>
    public class sys_dbbackup
    {
        /// <summary>
        /// web系统表--数据库备份
        /// </summary>
        public sys_dbbackup()
        {
        }

        /// <summary>
        /// 备份主键
        /// </summary>
        public System.String F_Id { get; set; }

        /// <summary>
        /// 备份类型
        /// </summary>
        public System.String F_BackupType { get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        public System.String F_DbName { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        public System.String F_FileName { get; set; }

        /// <summary>
        /// 文件大小
        /// </summary>
        public System.String F_FileSize { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        public System.String F_FilePath { get; set; }

        /// <summary>
        /// 备份时间
        /// </summary>
        public System.DateTime? F_BackupTime { get; set; }

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