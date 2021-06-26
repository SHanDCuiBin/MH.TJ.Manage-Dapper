

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 报告模板签名图片表
    /// </summary>
    public class report_printing_requirement_signature
    {
        /// <summary>
        /// 报告模板签名图片表
        /// </summary>
        public report_printing_requirement_signature()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 报告打印模板表id
        /// </summary>
        public System.String require_id { get; set; }

        /// <summary>
        /// 上传的图片名称
        /// </summary>
        public System.String picture_name { get; set; }

        /// <summary>
        /// 阿里云保存的图片地址
        /// </summary>
        public System.String picture_url { get; set; }

        /// <summary>
        /// 是否已删除 0为未删除 1为已删除
        /// </summary>
        public System.Int32? is_delete { get; set; }
    }
}