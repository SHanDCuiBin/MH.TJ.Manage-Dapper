

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 设备检修报告子表
    /// </summary>
    public class mms_equipment_inspection_report_item
    {
        /// <summary>
        /// 设备检修报告子表
        /// </summary>
        public mms_equipment_inspection_report_item()
        {
        }

        /// <summary>
        /// Id uuid
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 主表id
        /// </summary>
        public System.String report_id { get; set; }

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
        /// 结果
        /// </summary>
        public System.String result { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 顺序
        /// </summary>
        public System.Int32 num { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        public System.String img_url { get; set; }
    }
}