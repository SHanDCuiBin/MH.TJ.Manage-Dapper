

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 快递地址管理
    /// </summary>
    public class cms_kd_address_copy
    {
        /// <summary>
        /// 快递地址管理
        /// </summary>
        public cms_kd_address_copy()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String ID { get; set; }

        /// <summary>
        /// 接收人姓名
        /// </summary>
        public System.String JS_USER_NAME { get; set; }

        /// <summary>
        /// 接收人电话
        /// </summary>
        public System.String JS_PHONE { get; set; }

        /// <summary>
        /// 接收地址
        /// </summary>
        public System.String JS_ADDRESS { get; set; }

        /// <summary>
        /// 接收机构ID
        /// </summary>
        public System.String JS_ORG_ID { get; set; }

        /// <summary>
        /// 接收类型 1.工程师 2.卫生院
        /// </summary>
        public System.Int32? JS_USER_TYPE { get; set; }

        /// <summary>
        /// 常用信息启用的状态   1启用    0未启用
        /// </summary>
        public System.String JS_SATUS { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? CTEATETIME { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String REMARKES { get; set; }
    }
}