

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 图书信息子表
    /// </summary>
    public class lms_book_singal
    {
        /// <summary>
        /// 图书信息子表
        /// </summary>
        public lms_book_singal()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 所对应的书籍id
        /// </summary>
        public System.String book_id { get; set; }

        /// <summary>
        /// 图书名称
        /// </summary>
        public System.String book_name { get; set; }

        /// <summary>
        /// 图书的条形码
        /// </summary>
        public System.String code { get; set; }

        /// <summary>
        /// 图书备注
        /// </summary>
        public System.String book_remark { get; set; }

        /// <summary>
        /// 是否删除图书 0否 1是
        /// </summary>
        public System.Int32? book_delete { get; set; }

        /// <summary>
        /// 购买人的id
        /// </summary>
        public System.String buyer_id { get; set; }

        /// <summary>
        /// 购买人姓名
        /// </summary>
        public System.String buyer_name { get; set; }

        /// <summary>
        /// 购买的时间
        /// </summary>
        public System.DateTime? buy_date { get; set; }

        /// <summary>
        /// 图书状态 0空闲 1借出 2遗失 3禁用 4申请中
        /// </summary>
        public System.String book_state { get; set; }
    }
}