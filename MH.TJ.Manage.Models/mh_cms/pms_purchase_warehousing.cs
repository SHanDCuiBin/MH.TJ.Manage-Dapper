

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 采购入库表
    /// </summary>
    public class pms_purchase_warehousing
    {
        /// <summary>
        /// 采购入库表
        /// </summary>
        public pms_purchase_warehousing()
        {
        }

        /// <summary>
        /// 主键：采购入库表
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// 采购编号
        /// </summary>
        public System.String purchase_number { get; set; }

        /// <summary>
        /// 供应商id
        /// </summary>
        public System.Int32 supplier_id { get; set; }

        /// <summary>
        /// 供应商全称
        /// </summary>
        public System.String supplier_qname { get; set; }

        /// <summary>
        /// 供应商简称
        /// </summary>
        public System.String supplier_jname { get; set; }

        /// <summary>
        /// 预购人id
        /// </summary>
        public System.Int32 yg_men_id { get; set; }

        /// <summary>
        /// 预购人name
        /// </summary>
        public System.String yg_men_name { get; set; }

        /// <summary>
        /// 预购人部门
        /// </summary>
        public System.Int32 yg_men_dept { get; set; }

        /// <summary>
        /// 采购日期
        /// </summary>
        public System.DateTime? cg_time { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public System.Int32 status { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.Int32 founder { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public System.Int32 reviser { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime creation_time { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime revision_time { get; set; }
    }
}