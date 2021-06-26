

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 图书基本信息表
    /// </summary>
    public class lms_book_info
    {
        /// <summary>
        /// 图书基本信息表
        /// </summary>
        public lms_book_info()
        {
        }

        /// <summary>
        /// 图书的id
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 书名
        /// </summary>
        public System.String book_name { get; set; }

        /// <summary>
        /// 作者名
        /// </summary>
        public System.String writer_name { get; set; }

        /// <summary>
        /// 出版社名称
        /// </summary>
        public System.String publish_name { get; set; }

        /// <summary>
        /// 条形码
        /// </summary>
        public System.String code { get; set; }

        /// <summary>
        /// 类别id
        /// </summary>
        public System.String type_id { get; set; }

        /// <summary>
        /// 图书剩余数量
        /// </summary>
        public System.Int32? book_leftnumber { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String book_remark { get; set; }

        /// <summary>
        /// 图书存放位置
        /// </summary>
        public System.String book_position { get; set; }

        /// <summary>
        /// 图书总数量
        /// </summary>
        public System.Int32? book_totalnumber { get; set; }

        /// <summary>
        /// 图书价格
        /// </summary>
        public System.Double? book_price { get; set; }

        /// <summary>
        /// 是否删除 0未删，1已删除
        /// </summary>
        public System.Int32? book_delete { get; set; }

        /// <summary>
        /// 图书的类别名称
        /// </summary>
        public System.String book_typename { get; set; }
    }
}