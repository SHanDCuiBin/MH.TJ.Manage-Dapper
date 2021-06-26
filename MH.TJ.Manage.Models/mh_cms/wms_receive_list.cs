

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 物品领用申请表
    /// </summary>
    public class wms_receive_list
    {
        /// <summary>
        /// 物品领用申请表
        /// </summary>
        public wms_receive_list()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 领用人
        /// </summary>
        public System.String receive_user_id { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        public System.String products_id { get; set; }

        /// <summary>
        /// 领取数量
        /// </summary>
        public System.Int32? num { get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        public System.DateTime? apply_for_time { get; set; }

        /// <summary>
        /// 领取时间
        /// </summary>
        public System.DateTime? get_time { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        public System.String task_id { get; set; }

        /// <summary>
        /// 分组id
        /// </summary>
        public System.String group_id { get; set; }

        /// <summary>
        /// 仓库负责人
        /// </summary>
        public System.String warehouse_user_id { get; set; }

        /// <summary>
        /// 领用状态
        /// </summary>
        public System.Int32? status { get; set; }

        /// <summary>
        /// 0固定资产1耗材
        /// </summary>
        public System.Int32? flag { get; set; }
    }
}