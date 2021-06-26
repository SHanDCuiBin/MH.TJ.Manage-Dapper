

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 保养记录详情
    /// </summary>
    public class wms_upkeep_list
    {
        /// <summary>
        /// 保养记录详情
        /// </summary>
        public wms_upkeep_list()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 保养单号 对应 inventory_log
        /// </summary>
        public System.String upkeep_code { get; set; }

        /// <summary>
        /// 仓库号
        /// </summary>
        public System.Int32 warehouse_id { get; set; }

        /// <summary>
        /// 产品Id 对应products_info
        /// </summary>
        public System.Int32? products_id { get; set; }

        /// <summary>
        /// 保养数量
        /// </summary>
        public System.Single? count { get; set; }

        /// <summary>
        /// 保养结果
        /// </summary>
        public System.String result { get; set; }

        /// <summary>
        /// 沐华编号(二维码信息)
        /// </summary>
        public System.String mh_code { get; set; }

        /// <summary>
        /// 用途
        /// </summary>
        public System.Int32? purpose_id { get; set; }

        /// <summary>
        /// 1.在仓库 2.分配 3.借出
        /// </summary>
        public System.Int32? state { get; set; }

        /// <summary>
        /// 责任人(持有人)
        /// </summary>
        public System.Int32? possessor_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime create_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 create_user_id { get; set; }

        /// <summary>
        /// 仓库
        /// </summary>
        public System.String ware_house { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public System.String product_name { get; set; }

        /// <summary>
        /// 位置
        /// </summary>
        public System.String place { get; set; }
    }
}