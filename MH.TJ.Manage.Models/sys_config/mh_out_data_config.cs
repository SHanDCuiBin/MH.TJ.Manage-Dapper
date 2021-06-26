

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 
    /// </summary>
    public class mh_out_data_config
    {
        /// <summary>
        /// 
        /// </summary>
        public mh_out_data_config()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 数据来源0：报告库，1：档案库
        /// </summary>
        public System.Int32? DataType { get; set; }

        /// <summary>
        /// 表名
        /// </summary>
        public System.String Tablename { get; set; }

        /// <summary>
        /// 对应mh_out_config的code字段
        /// </summary>
        public System.String Config_code { get; set; }

        /// <summary>
        /// 对应mh_out_config的Type字段
        /// </summary>
        public System.Int32? Physical_Type { get; set; }
    }
}