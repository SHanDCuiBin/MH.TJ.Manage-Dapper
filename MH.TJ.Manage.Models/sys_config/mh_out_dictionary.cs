

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 
    /// </summary>
    public class mh_out_dictionary
    {
        /// <summary>
        /// 
        /// </summary>
        public mh_out_dictionary()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.Int32 Id { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        public System.String Itemcode { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        public System.String Itemvalue { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public System.Int32? Type { get; set; }
    }
}