

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 家族史
    /// </summary>
    public class rhr_family_history
    {
        /// <summary>
        /// 家族史
        /// </summary>
        public rhr_family_history()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String rhr_id { get; set; }

        /// <summary>
        /// 亲属关系
        /// </summary>
        public System.String relationship { get; set; }

        /// <summary>
        /// 疾病
        /// </summary>
        public System.String medical_history { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String create_org_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? gmt_create { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String update_user_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? gmt_modified { get; set; }

        /// <summary>
        /// 分片id
        /// </summary>
        public System.String sharding_id { get; set; }

        /// <summary>
        /// 0为未删除1为已删除
        /// </summary>
        public System.Int32? deleted { get; set; }
    }
}