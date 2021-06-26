

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 报废记录
    /// </summary>
    public class wms_scrap_record
    {
        /// <summary>
        /// 报废记录
        /// </summary>
        public wms_scrap_record()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 产品Id 对应products_info
        /// </summary>
        public System.Int32? products_id { get; set; }

        /// <summary>
        /// 批次
        /// </summary>
        public System.String batch_no { get; set; }

        /// <summary>
        /// 沐华编号(二维码信息)
        /// </summary>
        public System.String mh_code { get; set; }

        /// <summary>
        /// 使用人
        /// </summary>
        public System.Int32? possessor_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String possessor_name { get; set; }

        /// <summary>
        /// 报废原因
        /// </summary>
        public System.String reason { get; set; }

        /// <summary>
        /// 报废日期
        /// </summary>
        public System.DateTime? scrap_time { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime create_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 create_user_id { get; set; }

        /// <summary>
        /// 仓库id
        /// </summary>
        public System.Int32? inventory_id { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public System.Int32 count { get; set; }

        /// <summary>
        /// 状态 1.转入报废仓,待处理 2.报废 3.返回1号仓库
        /// </summary>
        public System.SByte? state { get; set; }
    }
}