

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 医疗机构信息表（卫生院、卫生室、卫生局）--记录各个体检机构的社区ID及社区名称等信息
    /// </summary>
    public class hospital
    {
        /// <summary>
        /// 医疗机构信息表（卫生院、卫生室、卫生局）--记录各个体检机构的社区ID及社区名称等信息
        /// </summary>
        public hospital()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? level { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String parent_id { get; set; }

        /// <summary>
        /// 上级机构联系电话
        /// </summary>
        public System.String parent_tel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String linkman { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String link_tel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String extend { get; set; }

        /// <summary>
        /// 该机构是否禁用  0 禁用  1 没有禁用
        /// </summary>
        public System.Int32? enable { get; set; }

        /// <summary>
        /// 排序字段  数字越小 级别排序越靠前
        /// </summary>
        public System.Int32? sort { get; set; }
    }
}