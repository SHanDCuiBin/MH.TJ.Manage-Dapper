

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 维修申请表
    /// </summary>
    public class mms_maintenance_apply
    {
        /// <summary>
        /// 维修申请表
        /// </summary>
        public mms_maintenance_apply()
        {
        }

        /// <summary>
        /// Id uuid
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 申请人，创建人
        /// </summary>
        public System.Int32? create_user_id { get; set; }

        /// <summary>
        /// 申请人姓名
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public System.String phone { get; set; }

        /// <summary>
        /// 保修日期
        /// </summary>
        public System.DateTime? date { get; set; }

        /// <summary>
        /// 维修类型 1：公司设备保修 2：个人保修
        /// </summary>
        public System.Int32? maintain_type { get; set; }

        /// <summary>
        /// 状态 1.未提交2.待审批 3.审批通过 4.已拒绝 5.已撤销
        /// </summary>
        public System.Int32? state { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public System.Int32? update_user { get; set; }

        /// <summary>
        /// 修改人姓名
        /// </summary>
        public System.String update_user_name { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? update_time { get; set; }

        /// <summary>
        /// 审批流id
        /// </summary>
        public System.String ding_talk_id { get; set; }

        /// <summary>
        /// 审批人id
        /// </summary>
        public System.Int32? approve_id { get; set; }

        /// <summary>
        /// 审批人
        /// </summary>
        public System.String approve_name { get; set; }

        /// <summary>
        /// 抄送人id
        /// </summary>
        public System.Int32? copy_user_id { get; set; }

        /// <summary>
        /// 抄送人
        /// </summary>
        public System.String copy_user_name { get; set; }
    }
}