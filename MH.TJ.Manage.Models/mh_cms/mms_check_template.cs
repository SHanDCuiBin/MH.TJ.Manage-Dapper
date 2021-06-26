

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 飞行检查表设备检修记录表模板表
    /// </summary>
    public class mms_check_template
    {
        /// <summary>
        /// 飞行检查表设备检修记录表模板表
        /// </summary>
        public mms_check_template()
        {
        }

        /// <summary>
        /// Id
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 模块名称
        /// </summary>
        public System.String module { get; set; }

        /// <summary>
        /// 检查项目
        /// </summary>
        public System.String project { get; set; }

        /// <summary>
        /// 标准
        /// </summary>
        public System.String standard { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 顺序
        /// </summary>
        public System.Int32 num { get; set; }

        /// <summary>
        /// 0.设备检修模板1.飞行检查模板
        /// </summary>
        public System.Int32 type { get; set; }

        /// <summary>
        /// 是否启用0.正常1.禁用
        /// </summary>
        public System.Int32 enable { get; set; }
    }
}