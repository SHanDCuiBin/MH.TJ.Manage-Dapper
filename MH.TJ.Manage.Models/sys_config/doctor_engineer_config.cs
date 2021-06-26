

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 卫生院体检数据审核数据隔离
    /// </summary>
    public class doctor_engineer_config
    {
        /// <summary>
        /// 卫生院体检数据审核数据隔离
        /// </summary>
        public doctor_engineer_config()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 relation_id { get; set; }

        /// <summary>
        /// 审核医生ID
        /// </summary>
        public System.String doctor_id { get; set; }

        /// <summary>
        /// 运维工程师ID
        /// </summary>
        public System.String engineer_id { get; set; }
    }
}