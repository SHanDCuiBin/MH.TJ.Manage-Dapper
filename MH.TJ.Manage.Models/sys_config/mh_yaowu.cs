

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 药物信息表--记录主要用药情况的药物数据信息
    /// </summary>
    public class mh_yaowu
    {
        /// <summary>
        /// 药物信息表--记录主要用药情况的药物数据信息
        /// </summary>
        public mh_yaowu()
        {
        }

        /// <summary>
        /// 药物ID号
        /// </summary>
        public System.String yw_id { get; set; }

        /// <summary>
        /// 药物种类
        /// </summary>
        public System.String yw_type { get; set; }

        /// <summary>
        /// 药物名称
        /// </summary>
        public System.String yw_name { get; set; }

        /// <summary>
        /// 药物商品名字
        /// </summary>
        public System.String yw_spname { get; set; }

        /// <summary>
        /// 药物坚持服用时间
        /// </summary>
        public System.String yw_jc { get; set; }

        /// <summary>
        /// 药物用法
        /// </summary>
        public System.String yw_yongfa { get; set; }

        /// <summary>
        /// 药物用法频次
        /// </summary>
        public System.String yw_pinci { get; set; }

        /// <summary>
        /// 药物用量
        /// </summary>
        public System.String yw_yongliang { get; set; }

        /// <summary>
        /// 药物单位
        /// </summary>
        public System.String yw_danwei { get; set; }

        /// <summary>
        /// 药物备注
        /// </summary>
        public System.String yw_remark { get; set; }
    }
}