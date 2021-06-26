

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 耗材设备交接主表
    /// </summary>
    public class wms_material_equipment_handover
    {
        /// <summary>
        /// 耗材设备交接主表
        /// </summary>
        public wms_material_equipment_handover()
        {
        }

        /// <summary>
        /// 序号
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 原卫生院
        /// </summary>
        public System.String yh_center { get; set; }

        /// <summary>
        /// 交接日期
        /// </summary>
        public System.DateTime? handover_time { get; set; }

        /// <summary>
        /// 接收人
        /// </summary>
        public System.String handover_user { get; set; }

        /// <summary>
        /// 现卫生院
        /// </summary>
        public System.String xh_center { get; set; }

        /// <summary>
        /// 耗材交接备注
        /// </summary>
        public System.String consumable_remark { get; set; }

        /// <summary>
        /// 设备交接备注
        /// </summary>
        public System.String Equipment_remark { get; set; }

        /// <summary>
        /// 类型（1.耗材交接 2.设备交接 3.耗材交接、设备交接）
        /// </summary>
        public System.Int32? type { get; set; }

        /// <summary>
        /// 状态（1.待通过2.交接完成，3.已拒绝，4.已撤销）
        /// </summary>
        public System.Int32? state { get; set; }

        /// <summary>
        /// 钉钉id
        /// </summary>
        public System.String ding_talk_id { get; set; }

        /// <summary>
        /// 抄送人id
        /// </summary>
        public System.String copy_id { get; set; }

        /// <summary>
        /// 抄送人名称
        /// </summary>
        public System.String copy_user { get; set; }

        /// <summary>
        /// 钉钉审批时间
        /// </summary>
        public System.DateTime? ding_time { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String create_user { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public System.String mod_user { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? mod_time { get; set; }

        /// <summary>
        /// 接收人id
        /// </summary>
        public System.Int32? handover_user_id { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        public System.Int32? create_user_id { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        public System.String refusal_cause { get; set; }

        /// <summary>
        /// 现卫生院id
        /// </summary>
        public System.String xh_center_id { get; set; }

        /// <summary>
        /// 原卫生院id
        /// </summary>
        public System.String yh_center_id { get; set; }

        /// <summary>
        /// 出库单号
        /// </summary>
        public System.String out_code { get; set; }

        /// <summary>
        /// 申请单号
        /// </summary>
        public System.String apply_id { get; set; }

        /// <summary>
        /// 沐华编号（二维码）
        /// </summary>
        public System.String mh_code { get; set; }
    }
}