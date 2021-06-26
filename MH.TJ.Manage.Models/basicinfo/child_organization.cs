

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 机构子表  包含幼儿园、中小学
    /// </summary>
    public class child_organization
    {
        /// <summary>
        /// 机构子表  包含幼儿园、中小学
        /// </summary>
        public child_organization()
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
        /// 级别分类    4 卫生室    5 幼儿园  6 学校 (61小学  62 初中 63 高中 64 大学）
        /// </summary>
        public System.Int32? level { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String parent_id { get; set; }

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
        public System.String address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String extend { get; set; }

        /// <summary>
        /// 医院代码 用于标注医院
        /// </summary>
        public System.String yy_code { get; set; }

        /// <summary>
        /// 该机构是否禁用  0 禁用  1 没有禁用
        /// </summary>
        public System.Int32? enable { get; set; }

        /// <summary>
        /// 排序字段  数字越小 级别排序越靠前
        /// </summary>
        public System.Int32? sort { get; set; }

        /// <summary>
        /// 辖区人口数   
        /// </summary>
        public System.Int32? xqrk { get; set; }

        /// <summary>
        /// 邮政编码
        /// </summary>
        public System.String yzbm { get; set; }
    }
}