

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 录入人的手机号与儿童信息的中间表
    /// </summary>
    public class phone_child_info
    {
        /// <summary>
        /// 录入人的手机号与儿童信息的中间表
        /// </summary>
        public phone_child_info()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 年度
        /// </summary>
        public System.Int32? year { get; set; }

        /// <summary>
        /// 录入人电话
        /// </summary>
        public System.String phone { get; set; }

        /// <summary>
        /// 录入的儿童信息的id_card
        /// </summary>
        public System.String id_card { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String mh_card { get; set; }
    }
}