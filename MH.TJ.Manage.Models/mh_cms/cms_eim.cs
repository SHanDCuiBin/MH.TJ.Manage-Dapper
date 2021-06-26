

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 
    /// </summary>
    public class cms_eim
    {
        /// <summary>
        /// 
        /// </summary>
        public cms_eim()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 机构的id
        /// </summary>
        public System.Int32? org_id { get; set; }

        /// <summary>
        /// 机构常用信息启用的状态   1启用    0未启用
        /// </summary>
        public System.Int32? Status { get; set; }

        /// <summary>
        /// 接收人
        /// </summary>
        public System.String Receiver { get; set; }

        /// <summary>
        /// 接收人电话
        /// </summary>
        public System.String Receiver_Tel { get; set; }

        /// <summary>
        /// 接收地址
        /// </summary>
        public System.String ReceivingAddress { get; set; }

        /// <summary>
        /// 维护人id
        /// </summary>
        public System.Int32? Updid { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String Remarks { get; set; }
    }
}