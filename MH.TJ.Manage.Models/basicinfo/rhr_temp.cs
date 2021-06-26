

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 
    /// </summary>
    public class rhr_temp
    {
        /// <summary>
        /// 
        /// </summary>
        public rhr_temp()
        {
        }

        /// <summary>
        /// 个人档案编号
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 沐华个人档案编号
        /// </summary>
        public System.String mh_card { get; set; }

        /// <summary>
        /// 0未知性别1 男 2 女 9 未说明性别
        /// </summary>
        public System.UInt32? gender_code { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public System.String id_card { get; set; }
    }
}