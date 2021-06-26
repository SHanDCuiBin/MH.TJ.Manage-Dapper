

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 申请单明细（新）
    /// </summary>
    public class mms_maintenances_apply_datil
    {
        /// <summary>
        /// 申请单明细（新）
        /// </summary>
        public mms_maintenances_apply_datil()
        {
        }

        /// <summary>
        /// Id uuid
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 申请单号
        /// </summary>
        public System.String maintenance_code { get; set; }

        /// <summary>
        /// 固定资产号
        /// </summary>
        public System.String code { get; set; }

        /// <summary>
        /// 报修附件地址
        /// </summary>
        public System.String accessory { get; set; }

        /// <summary>
        /// 设备id
        /// </summary>
        public System.Int32? product_id { get; set; }

        /// <summary>
        /// 设备名字
        /// </summary>
        public System.String product_name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 状态 0 保存或审批中状态 1 待响应 2 维修中 3 中止 4 维修完成 5 暂停中 6 验收完成
        /// </summary>
        public System.Int32? state { get; set; }

        /// <summary>
        /// 开始维修时间
        /// </summary>
        public System.DateTime? start_time { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public System.DateTime? end_time { get; set; }

        /// <summary>
        /// 维修时长
        /// </summary>
        public System.String sum_time { get; set; }

        /// <summary>
        /// 维修完成后未验收小时数 最大为6 超过则改变state=6 默认为0
        /// </summary>
        public System.Int32? end_time_hour { get; set; }

        /// <summary>
        /// 故障描述
        /// </summary>
        public System.String malfunction_explain { get; set; }

        /// <summary>
        /// 故障原因 1：保养不当 2人为损坏
        /// </summary>
        public System.Int32? malfunction_reason { get; set; }

        /// <summary>
        /// 维修方法
        /// </summary>
        public System.String maintenances_method { get; set; }

        /// <summary>
        /// 配件id
        /// </summary>
        public System.Int32? prodect_parts { get; set; }

        /// <summary>
        /// 配件名称
        /// </summary>
        public System.String prodect_parts_name { get; set; }

        /// <summary>
        /// 维修计时（每次开始时候的时间）
        /// </summary>
        public System.DateTime? time_start { get; set; }

        /// <summary>
        /// 维修人id
        /// </summary>
        public System.Int32? maintenance_man { get; set; }

        /// <summary>
        /// 维修人姓名
        /// </summary>
        public System.String maintenance_name { get; set; }

        /// <summary>
        /// 沐华编号
        /// </summary>
        public System.String mh_num { get; set; }

        /// <summary>
        /// 暂停原因
        /// </summary>
        public System.String suspension_reason { get; set; }

        /// <summary>
        /// 中止原因
        /// </summary>
        public System.String stop_reason { get; set; }

        /// <summary>
        /// 维修附件地址
        /// </summary>
        public System.String accessory_wx { get; set; }

        /// <summary>
        /// 转交给
        /// </summary>
        public System.Int32? hand_over_to { get; set; }

        /// <summary>
        /// 转交给name
        /// </summary>
        public System.String hand_over_to_name { get; set; }
    }
}