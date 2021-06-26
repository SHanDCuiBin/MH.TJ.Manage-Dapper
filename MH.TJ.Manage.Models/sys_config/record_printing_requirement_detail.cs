

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 档案打印需求表 -子表
    /// </summary>
    public class record_printing_requirement_detail
    {
        /// <summary>
        /// 档案打印需求表 -子表
        /// </summary>
        public record_printing_requirement_detail()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 主表编号
        /// </summary>
        public System.String require_id { get; set; }

        /// <summary>
        /// 控件id
        /// </summary>
        public System.String control { get; set; }

        /// <summary>
        /// 控件类型 1为单选按钮 2为多选按钮 3为输入框 4为下拉框
        /// </summary>
        public System.Int32? type { get; set; }

        /// <summary>
        /// 输入顺序
        /// </summary>
        public System.Int32? sort { get; set; }

        /// <summary>
        /// 输入内容
        /// </summary>
        public System.String value { get; set; }
    }
}