

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 财务电子报销系统费用记录表
    /// </summary>
    public class ers_expense_record
    {
        /// <summary>
        /// 财务电子报销系统费用记录表
        /// </summary>
        public ers_expense_record()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 费用类型
        /// </summary>
        public System.Int32 type { get; set; }

        /// <summary>
        /// 费用类型名称
        /// </summary>
        public System.String type_name { get; set; }

        /// <summary>
        /// 实际金额
        /// </summary>
        public System.Double? money { get; set; }

        /// <summary>
        /// 消费日期
        /// </summary>
        public System.String consume_time { get; set; }

        /// <summary>
        /// 消费城市
        /// </summary>
        public System.String city { get; set; }

        /// <summary>
        /// 状态0.未报销1.已选择2.审批中3.审批完成
        /// </summary>
        public System.Int32 state { get; set; }

        /// <summary>
        /// 发票图片
        /// </summary>
        public System.String invoice_img { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 报销表id
        /// </summary>
        public System.String apply_id { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.Int32 create_user_id { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public System.DateTime create_time { get; set; }

        /// <summary>
        /// 图片id
        /// </summary>
        public System.String img_id { get; set; }

        /// <summary>
        /// 预计金额
        /// </summary>
        public System.Double? predict_money { get; set; }

        /// <summary>
        /// 公里数起始
        /// </summary>
        public System.Double? mileage_start { get; set; }

        /// <summary>
        /// 公里数终止
        /// </summary>
        public System.Double? mileage_end { get; set; }

        /// <summary>
        /// 地点起始
        /// </summary>
        public System.String address_start { get; set; }

        /// <summary>
        /// 地点终止
        /// </summary>
        public System.String address_end { get; set; }

        /// <summary>
        /// 油耗
        /// </summary>
        public System.Double? oil_wear { get; set; }

        /// <summary>
        /// 油价
        /// </summary>
        public System.Double? oil_price { get; set; }

        /// <summary>
        /// 预计公里数
        /// </summary>
        public System.Double? predict_mileage { get; set; }

        /// <summary>
        /// 钉钉审批流id
        /// </summary>
        public System.String ding_talk_id { get; set; }

        /// <summary>
        /// 是否有发票 1有票 2无票 null 对以前数据的兼容
        /// </summary>
        public System.Int32? is_invoices { get; set; }
    }
}