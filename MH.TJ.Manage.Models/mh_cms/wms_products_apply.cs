

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 物品领用申请表
    /// </summary>
    public class wms_products_apply
    {
        /// <summary>
        /// 物品领用申请表
        /// </summary>
        public wms_products_apply()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 领用人
        /// </summary>
        public System.Int32 apply_user_id { get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        public System.DateTime apply_date { get; set; }

        /// <summary>
        /// 领取时间
        /// </summary>
        public System.DateTime? get_date { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        public System.String task_id { get; set; }

        /// <summary>
        /// 仓库负责人
        /// </summary>
        public System.Int32? warehouse_user_id { get; set; }

        /// <summary>
        /// 领用状态 1.提交申请 2.不通过 3.通过 4.备货完成 5.部分出库 6.出库完成 7.确认收货8.撤回
        /// </summary>
        public System.Int32 status { get; set; }

        /// <summary>
        /// 1固定资产2耗材
        /// </summary>
        public System.Int32 flag { get; set; }

        /// <summary>
        /// 确认时间
        /// </summary>
        public System.DateTime? confirm_date { get; set; }

        /// <summary>
        /// 物品总件数
        /// </summary>
        public System.Int32 number { get; set; }

        /// <summary>
        /// 申请人
        /// </summary>
        public System.String apply_user_name { get; set; }

        /// <summary>
        /// 仓库负责人
        /// </summary>
        public System.String warehouse_user_name { get; set; }

        /// <summary>
        /// 审批者
        /// </summary>
        public System.String approver { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? approver_id { get; set; }

        /// <summary>
        /// 抄送人 [10],[11],[12]
        /// </summary>
        public System.String copy_recipients { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String copy_recipient_ids { get; set; }

        /// <summary>
        /// 原因(驳回原因)
        /// </summary>
        public System.String reason { get; set; }

        /// <summary>
        /// 确认图片地址
        /// </summary>
        public System.String sure_image { get; set; }

        /// <summary>
        /// 钉钉审批id
        /// </summary>
        public System.String dingtalk_id { get; set; }
    }
}