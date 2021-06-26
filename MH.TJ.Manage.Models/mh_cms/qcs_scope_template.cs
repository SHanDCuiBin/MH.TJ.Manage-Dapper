

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 质控范围模板
    /// </summary>
    public class qcs_scope_template
    {
        /// <summary>
        /// 质控范围模板
        /// </summary>
        public qcs_scope_template()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 字段编码
        /// </summary>
        public System.String code { get; set; }

        /// <summary>
        /// 显示说明信息
        /// </summary>
        public System.String msg { get; set; }

        /// <summary>
        /// 低值(带#的为数值复查值低值)
        /// </summary>
        public System.Double? low { get; set; }

        /// <summary>
        /// 高值(带#的为数值复查值高值)
        /// </summary>
        public System.Double? high { get; set; }

        /// <summary>
        /// 最低值(带#的为数值危机值低值)
        /// </summary>
        public System.Double? low1 { get; set; }

        /// <summary>
        /// 最高值(带#的为数值危机值高值)
        /// </summary>
        public System.Double? high1 { get; set; }

        /// <summary>
        /// 正常值最低值
        /// </summary>
        public System.Double? low_normal { get; set; }

        /// <summary>
        /// 正常值最大值
        /// </summary>
        public System.Double? high_normal { get; set; }

        /// <summary>
        /// 数据code（所属数据表）
        /// </summary>
        public System.String base_code { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        public System.String explain { get; set; }
    }
}