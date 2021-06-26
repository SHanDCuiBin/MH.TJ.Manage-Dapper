

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 补打人员列表
    /// </summary>
    public class cms_tj_bdr_list
    {
        /// <summary>
        /// 补打人员列表
        /// </summary>
        public cms_tj_bdr_list()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.String ID { get; set; }

        /// <summary>
        /// 补打id号
        /// </summary>
        public System.String BD_ID { get; set; }

        /// <summary>
        /// 需要补打的人的id(老年人,儿童...)
        /// </summary>
        public System.String BDR_ID { get; set; }

        /// <summary>
        /// 补打人条码号
        /// </summary>
        public System.String BDR_TMH { get; set; }

        /// <summary>
        /// 补打人身份证
        /// </summary>
        public System.String BDR_SFZ { get; set; }

        /// <summary>
        /// 补打人姓名
        /// </summary>
        public System.String BDR_NAME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String RESERVED { get; set; }
    }
}