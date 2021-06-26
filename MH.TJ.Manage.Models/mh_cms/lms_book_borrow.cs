

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 图书借阅记录表
    /// </summary>
    public class lms_book_borrow
    {
        /// <summary>
        /// 图书借阅记录表
        /// </summary>
        public lms_book_borrow()
        {
        }

        /// <summary>
        /// 借阅的id
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 所借阅的图书id
        /// </summary>
        public System.String book_id { get; set; }

        /// <summary>
        /// 借阅者的id
        /// </summary>
        public System.String user_id { get; set; }

        /// <summary>
        /// 借阅者的姓名
        /// </summary>
        public System.String user_name { get; set; }

        /// <summary>
        /// 借阅的开始时间
        /// </summary>
        public System.DateTime? borrow_starttime { get; set; }

        /// <summary>
        /// 借阅的结束时间
        /// </summary>
        public System.DateTime? borrow_endtime { get; set; }

        /// <summary>
        /// 借阅的状态 0审核中 1借阅中 2已归还 
        /// </summary>
        public System.Int32? borrow_state { get; set; }

        /// <summary>
        /// 借阅的备注
        /// </summary>
        public System.String borrow_remark { get; set; }

        /// <summary>
        /// 是否为续借 0 不是，1是
        /// </summary>
        public System.Int32? reborrow_state { get; set; }

        /// <summary>
        /// 图书的归还时间
        /// </summary>
        public System.DateTime? return_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String book_name { get; set; }

        /// <summary>
        /// 图书编码
        /// </summary>
        public System.String book_code { get; set; }
    }
}