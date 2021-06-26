

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// web系统表--行政区域表--暂时不用，用organization代替
    /// </summary>
    public class sys_area
    {
        /// <summary>
        /// web系统表--行政区域表--暂时不用，用organization代替
        /// </summary>
        public sys_area()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.String f_id { get; set; }

        /// <summary>
        /// 父级
        /// </summary>
        public System.String f_parentid { get; set; }

        /// <summary>
        /// 层次 1国家 2省 3市 4区 5街道镇 6社区
        /// </summary>
        public System.Int32? f_layers { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        public System.String f_encode { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public System.String f_fullname { get; set; }

        /// <summary>
        /// 简拼
        /// </summary>
        public System.String f_simplespelling { get; set; }

        /// <summary>
        /// 排序码
        /// </summary>
        public System.Int32? f_sortcode { get; set; }

        /// <summary>
        /// 删除标志
        /// </summary>
        public System.SByte? f_deletemark { get; set; }

        /// <summary>
        /// 有效标志
        /// </summary>
        public System.SByte? f_enabledmark { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public System.String f_description { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public System.DateTime? f_creatorTime { get; set; }

        /// <summary>
        /// 创建用户主键
        /// </summary>
        public System.String f_creatoruserid { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        public System.DateTime? f_lastmodifytime { get; set; }

        /// <summary>
        /// 最后修改用户
        /// </summary>
        public System.String f_lastmodifyuserid { get; set; }

        /// <summary>
        /// 删除时间
        /// </summary>
        public System.DateTime? f_deletetime { get; set; }

        /// <summary>
        /// 删除用户
        /// </summary>
        public System.String f_deleteuserid { get; set; }
    }
}