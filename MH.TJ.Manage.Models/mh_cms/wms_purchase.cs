

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 采购订单表
    /// </summary>
    public class wms_purchase
    {
        /// <summary>
        /// 采购订单表
        /// </summary>
        public wms_purchase()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 订单编号,用于判断同一订单
        /// </summary>
        public System.String orders_code { get; set; }

        /// <summary>
        /// 1.创建(可修改,可删除) 2.待复核 3.入库完成 4.部分入库
        /// </summary>
        public System.Int32 status { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 订单日期
        /// </summary>
        public System.DateTime? order_date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime create_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 create_user_id { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 预购人
        /// </summary>
        public System.String yg_men_name { get; set; }

        /// <summary>
        /// 预购人id
        /// </summary>
        public System.Int32? yg_men_id { get; set; }

        /// <summary>
        /// 预购部门id
        /// </summary>
        public System.Int32? yg_men_dept { get; set; }

        /// <summary>
        /// 预购部门
        /// </summary>
        public System.String yg_men_dept_name { get; set; }

        /// <summary>
        /// 预购单id
        /// </summary>
        public System.Int32? wms_advance_order_id { get; set; }
    }
}