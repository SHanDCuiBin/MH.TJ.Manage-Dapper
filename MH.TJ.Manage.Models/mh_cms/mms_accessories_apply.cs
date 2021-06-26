

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 配件申请主表
    /// </summary>
    public class mms_accessories_apply
    {
        /// <summary>
        /// 配件申请主表
        /// </summary>
        public mms_accessories_apply()
        {
        }

        /// <summary>
        /// Id uuid
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 申请人、创建人
        /// </summary>
        public System.Int32? create_user { get; set; }

        /// <summary>
        /// 申请人姓名
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        public System.DateTime? apply_time { get; set; }

        /// <summary>
        /// 车辆id
        /// </summary>
        public System.String car_id { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        public System.String plate_no { get; set; }

        /// <summary>
        /// 卫生院id
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 卫生院名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        public System.Int32? dept_id { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public System.String dept_name { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 钉钉审批id
        /// </summary>
        public System.String ding_talk_id { get; set; }

        /// <summary>
        /// 审批人ids
        /// </summary>
        public System.String audit_user_ids { get; set; }

        /// <summary>
        /// 审批人姓名
        /// </summary>
        public System.String audit_user_names { get; set; }

        /// <summary>
        /// 抄送人ids
        /// </summary>
        public System.String copy_user_ids { get; set; }

        /// <summary>
        /// 抄送人姓名
        /// </summary>
        public System.String copy_user_names { get; set; }

        /// <summary>
        /// 配件图片
        /// </summary>
        public System.String img { get; set; }

        /// <summary>
        /// 状态0.待审批1.审核通过2.拒绝3.已退回
        /// </summary>
        public System.Int32? state { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        public System.String refuse_msg { get; set; }
    }
}