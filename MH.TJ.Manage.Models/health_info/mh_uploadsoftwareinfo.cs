
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 汇总上传版本号
    /// </summary>
    public class mh_uploadsoftwareinfo
    {
        /// <summary>
        /// 汇总上传版本号
        /// </summary>
        public mh_uploadsoftwareinfo()
        {
        }

        /// <summary>
        /// id
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 条码号
        /// </summary>
        public System.String tmh { get; set; }

        /// <summary>
        /// 人员类型
        ///（老年人：lnr;
        ///   中小学生：zxxs;
        ///   幼儿园：yey）
        /// </summary>
        public System.String ry_type { get; set; }

        /// <summary>
        /// 统一入口
        ///cpu+","+Account+","+version;cpu+","+Account+","+version;
        /// </summary>
        public System.String v_tyrk { get; set; }

        /// <summary>
        /// 老年人刷卡
        /// </summary>
        public System.String v_shuaka { get; set; }

        /// <summary>
        /// 采集(老年人采集；中小学生采集；幼儿园采集)
        /// </summary>
        public System.String v_caiji { get; set; }

        /// <summary>
        /// 检验-血球
        /// </summary>
        public System.String v_jy_xq { get; set; }

        /// <summary>
        /// 检验-生化
        /// </summary>
        public System.String v_jy_sh { get; set; }

        /// <summary>
        /// 检验-尿常规
        /// </summary>
        public System.String v_jy_ncg { get; set; }

        /// <summary>
        /// 工程师账号
        /// </summary>
        public System.String gg_user_id { get; set; }

        /// <summary>
        /// 其他1
        /// </summary>
        public System.String other_1 { get; set; }

        /// <summary>
        /// 其他2
        /// </summary>
        public System.String other_2 { get; set; }
    }
}