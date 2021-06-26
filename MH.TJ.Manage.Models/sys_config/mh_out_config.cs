

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 
    /// </summary>
    public class mh_out_config
    {
        /// <summary>
        /// 
        /// </summary>
        public mh_out_config()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.Int32 Id { get; set; }

        /// <summary>
        /// 中文名称（用于导出显示头名称）
        /// </summary>
        public System.String Cname { get; set; }

        /// <summary>
        /// 英文字段名称
        /// </summary>
        public System.String Ename { get; set; }

        /// <summary>
        /// 导出类型
        /// </summary>
        public System.String Code_name { get; set; }

        /// <summary>
        /// 导出代码与mh_out_dictionary中的Item_code一致
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// 体检类型0：老年人，1：儿童
        /// </summary>
        public System.Int32? Type { get; set; }

        /// <summary>
        /// 数据库类型0:报告库，1：档案库，与mh_out_data_config一致
        /// </summary>
        public System.Int32? DataType { get; set; }
    }
}