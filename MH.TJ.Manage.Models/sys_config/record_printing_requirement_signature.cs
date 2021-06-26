

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 
    /// </summary>
    public class record_printing_requirement_signature
    {
        /// <summary>
        /// 
        /// </summary>
        public record_printing_requirement_signature()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 档案打印模板表id
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
        /// 签名照类型 1为健康体检 2为检验 3为自理能力 4为中医体质
        /// </summary>
        public System.Int32? type { get; set; }

        /// <summary>
        /// 是否已删除 0为未删除 1为已删除
        /// </summary>
        public System.Int32? is_delete { get; set; }
    }
}