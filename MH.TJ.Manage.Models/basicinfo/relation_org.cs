

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 机构关联表--sys_area与其他几个机构表关联
    /// </summary>
    public class relation_org
    {
        /// <summary>
        /// 机构关联表--sys_area与其他几个机构表关联
        /// </summary>
        public relation_org()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// sys_area id
        /// </summary>
        public System.String area_orgid { get; set; }

        /// <summary>
        /// 医院机构号
        /// </summary>
        public System.String relation_orgid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String description { get; set; }
    }
}