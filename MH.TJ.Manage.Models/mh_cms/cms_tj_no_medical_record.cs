

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 体检未上报记录表
    /// </summary>
    public class cms_tj_no_medical_record
    {
        /// <summary>
        /// 体检未上报记录表
        /// </summary>
        public cms_tj_no_medical_record()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// 工程师
        /// </summary>
        public System.Int32? engineer_user { get; set; }

        /// <summary>
        /// 工程师名称
        /// </summary>
        public System.String engineer_user_name { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        public System.Byte[] task_id { get; set; }

        /// <summary>
        /// 机构
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// cms_checkpersontype表关联
        /// </summary>
        public System.Boolean? check_type { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        public System.String type_name { get; set; }

        /// <summary>
        /// 不查体日期
        /// </summary>
        public System.DateTime? tjrq { get; set; }

        /// <summary>
        /// 不查体原因
        /// </summary>
        public System.String reason { get; set; }

        /// <summary>
        /// 状态，0正常上报1.超期上报2.未上报3.已上传9.已撤销
        /// </summary>
        public System.Boolean state { get; set; }

        /// <summary>
        /// 审核流程id
        /// </summary>
        public System.String examine_id { get; set; }

        /// <summary>
        /// 全部审核人
        /// </summary>
        public System.String all_reviewers { get; set; }

        /// <summary>
        /// 撤销原因
        /// </summary>
        public System.String undo_reason { get; set; }

        /// <summary>
        /// 撤销时间
        /// </summary>
        public System.DateTime? undo_time { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String remark { get; set; }
    }
}