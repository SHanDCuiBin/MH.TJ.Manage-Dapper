

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 
    /// </summary>
    public class mh_physical_out
    {
        /// <summary>
        /// 
        /// </summary>
        public mh_physical_out()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.String Id { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? Createtime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String CreateUser { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public System.String Countent { get; set; }

        /// <summary>
        /// 数据来源
        /// </summary>
        public System.String Datasource { get; set; }

        /// <summary>
        /// 0:老年人，1：儿童
        /// </summary>
        public System.Int32? Flag { get; set; }

        /// <summary>
        /// 机构编码
        /// </summary>
        public System.String Org_id { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public System.String Org_name { get; set; }
    }
}