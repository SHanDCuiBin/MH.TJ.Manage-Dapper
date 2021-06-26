

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 盘点单
    /// </summary>
    public class wms_stock_record
    {
        /// <summary>
        /// 盘点单
        /// </summary>
        public wms_stock_record()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 盘点单号
        /// </summary>
        public System.String code { get; set; }

        /// <summary>
        /// 盘点单号 序号
        /// </summary>
        public System.String code_no { get; set; }

        /// <summary>
        /// 盘点类型 1.耗材 2.固定资产3.销售物品4.低值易耗品(详情见字典表)
        /// </summary>
        public System.String type { get; set; }

        /// <summary>
        /// 是否按模块盘点 1.是 0 否
        /// </summary>
        public System.SByte? is_model { get; set; }

        /// <summary>
        /// 仓库ids [1],[2]
        /// </summary>
        public System.String ware_house_id { get; set; }

        /// <summary>
        /// 仓库名 [aaa],[不不不]
        /// </summary>
        public System.String ware_str { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String type_str { get; set; }

        /// <summary>
        /// 状态 1.开始 2.结束 3.暂停  4.待审核 5.审核通过 6.审核不通过7.撤回 8.待盘点
        /// </summary>
        public System.Int32? state { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 完成时间
        /// </summary>
        public System.DateTime? complete_time { get; set; }

        /// <summary>
        /// 完成人
        /// </summary>
        public System.Int32? complete_user_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? create_user_id { get; set; }

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
        /// 卫生院id
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 卫生院名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String ding_talk_id { get; set; }

        /// <summary>
        /// 人员类型
        /// </summary>
        public System.String person_type { get; set; }

        /// <summary>
        /// 创建人名称
        /// </summary>
        public System.String create_name { get; set; }

        /// <summary>
        /// 是否是手机创建（1.手机创建 null 电脑创建）
        /// </summary>
        public System.Int32? is_phone { get; set; }
    }
}