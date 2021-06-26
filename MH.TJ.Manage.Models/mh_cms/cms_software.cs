

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 标准化作业流程  相关软件列表
    /// </summary>
    public class cms_software
    {
        /// <summary>
        /// 标准化作业流程  相关软件列表
        /// </summary>
        public cms_software()
        {
        }

        /// <summary>
        /// 软件编号
        /// </summary>
        public System.String SOFTWARE_ID { get; set; }

        /// <summary>
        /// 软件名称
        /// </summary>
        public System.String SOFTWARE_NAME { get; set; }

        /// <summary>
        /// 软件类型     APP/Web/Winform
        /// </summary>
        public System.String SOFTWARE_TYPE { get; set; }

        /// <summary>
        /// 开发语言
        /// </summary>
        public System.String SOFTWARE_DEVLANGUAGE { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? CREATE_TIME { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String REMARK { get; set; }
    }
}