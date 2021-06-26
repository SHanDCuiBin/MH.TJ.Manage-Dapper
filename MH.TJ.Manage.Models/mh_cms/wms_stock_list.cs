

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 盘点记录详情
    /// </summary>
    public class wms_stock_list
    {
        /// <summary>
        /// 盘点记录详情
        /// </summary>
        public wms_stock_list()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        ///  对应 盘点单id
        /// </summary>
        public System.String stock_id { get; set; }

        /// <summary>
        /// 模块编码
        /// </summary>
        public System.String mod_no { get; set; }

        /// <summary>
        /// 模块名称
        /// </summary>
        public System.String mod_name { get; set; }

        /// <summary>
        /// 盘点单号
        /// </summary>
        public System.String stock_code { get; set; }

        /// <summary>
        /// 仓库号
        /// </summary>
        public System.Int32? warehouse_id { get; set; }

        /// <summary>
        /// 产品Id 对应products_info
        /// </summary>
        public System.Int32? products_id { get; set; }

        /// <summary>
        /// 库存中理论数量
        /// </summary>
        public System.Single? ware_count { get; set; }

        /// <summary>
        /// 盘点结果数量
        /// </summary>
        public System.Single? result_count { get; set; }

        /// <summary>
        /// 沐华编号(二维码信息)
        /// </summary>
        public System.String mh_code { get; set; }

        /// <summary>
        /// 1.盘盈 -1.盘亏 0.账实相符
        /// </summary>
        public System.String result { get; set; }

        /// <summary>
        /// 用途
        /// </summary>
        public System.Int32? purpose_id { get; set; }

        /// <summary>
        ///  1.在仓库 2.分配 3.借出
        /// </summary>
        public System.Int32? state { get; set; }

        /// <summary>
        /// 责任人(持有人)
        /// </summary>
        public System.Int32? possessor_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? create_user_id { get; set; }

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

        /// <summary>
        /// 供应商
        /// </summary>
        public System.String supplier { get; set; }

        /// <summary>
        /// 出库表子表id
        /// </summary>
        public System.Int32? out_warehouse_id { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public System.String unit { get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        public System.String warehouse_name { get; set; }

        /// <summary>
        /// 现沐华编号(二维码信息)
        /// </summary>
        public System.String xmh_code { get; set; }

        /// <summary>
        /// 用途
        /// </summary>
        public System.String use_way { get; set; }
    }
}