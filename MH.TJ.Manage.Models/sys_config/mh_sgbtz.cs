

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 【沐华健康体检管理系统】0-6岁  儿童保健  身高别体重信息表--记录身高别体重数据信息，针对儿童身高体重评价
    /// </summary>
    public class mh_sgbtz
    {
        /// <summary>
        /// 【沐华健康体检管理系统】0-6岁  儿童保健  身高别体重信息表--记录身高别体重数据信息，针对儿童身高体重评价
        /// </summary>
        public mh_sgbtz()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public System.String sex { get; set; }

        /// <summary>
        /// 身高
        /// </summary>
        public System.String sg { get; set; }

        /// <summary>
        /// 体重低值
        /// </summary>
        public System.String tzdz { get; set; }

        /// <summary>
        /// 体重中下
        /// </summary>
        public System.String tzzx { get; set; }

        /// <summary>
        /// 体重正常
        /// </summary>
        public System.String tzzc { get; set; }

        /// <summary>
        /// 体重中上
        /// </summary>
        public System.String tzzs { get; set; }

        /// <summary>
        /// 体重高值
        /// </summary>
        public System.String tzgz { get; set; }
    }
}