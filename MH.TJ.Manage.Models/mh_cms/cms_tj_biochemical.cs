

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 生化类型表
    /// </summary>
    public class cms_tj_biochemical
    {
        /// <summary>
        /// 生化类型表
        /// </summary>
        public cms_tj_biochemical()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 生化项目名称
        /// </summary>
        public System.String bcname { get; set; }

        /// <summary>
        /// 生化类型 0.基础类型 1.附加类型 2.肿瘤 3.第三方9.暂停使用
        /// </summary>
        public System.Int32? bctype { get; set; }
    }
}