
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 体检图片管理表
    /// </summary>
    public class healthcheck_photo
    {
        /// <summary>
        /// 体检图片管理表
        /// </summary>
        public healthcheck_photo()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String mh_card { get; set; }

        /// <summary>
        /// 检查类型     1  个人基本信息     2  健康体检   3  中医体质   4 血球检验照片    5 生化检验照片  6 两癌检查照片 
        /// </summary>
        public System.Int32? check_type { get; set; }

        /// <summary>
        /// 对应检查表的ID 号
        /// </summary>
        public System.String check_id { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        public System.String photo_url { get; set; }

        /// <summary>
        /// 图片类型  xcz现场照，xdt心电图，zjz证件照，bc1 B超图片，bc2 B超图片，xg X光照片，zw指纹图片，dzqm电子签名，ct CT图片，mzf 慢阻肺图片
        /// </summary>
        public System.String photo_type { get; set; }

        /// <summary>
        /// 检查日期
        /// </summary>
        public System.DateTime? check_date { get; set; }
    }
}