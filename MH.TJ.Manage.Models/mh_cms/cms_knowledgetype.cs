

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 知识库类型
    /// </summary>
    public class cms_knowledgetype
    {
        /// <summary>
        /// 知识库类型
        /// </summary>
        public cms_knowledgetype()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 类别名称
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 资料库 标识
        /// </summary>
        public System.String code { get; set; }

        /// <summary>
        /// 上级编号
        /// </summary>
        public System.String parentcode { get; set; }

        /// <summary>
        ///    0 一级菜单  1 二级菜单..........
        /// </summary>
        public System.String type { get; set; }

        /// <summary>
        /// 机构编号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 删除 0未删除  1已删除
        /// </summary>
        public System.String is_delete { get; set; }
    }
}