

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 艾迪康、地区条码号对应关系表
    /// </summary>
    public class aidkbarcodenumber
    {
        /// <summary>
        /// 艾迪康、地区条码号对应关系表
        /// </summary>
        public aidkbarcodenumber()
        {
        }

        /// <summary>
        /// id
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 年份
        /// </summary>
        public System.String year { get; set; }

        /// <summary>
        /// 机构号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 前缀 7位
        /// </summary>
        public System.String prefix { get; set; }

        /// <summary>
        /// 开始 条码号 编号 5位
        /// </summary>
        public System.String StartCounting { get; set; }

        /// <summary>
        /// 结束 条码号 编号 5位
        /// </summary>
        public System.String EndCount { get; set; }
    }
}