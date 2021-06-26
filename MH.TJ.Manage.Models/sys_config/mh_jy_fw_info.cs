

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 检验范围信息 详细检验结果范围表--记录各体检机构各检验项目的范围信息
    /// </summary>
    public class mh_jy_fw_info
    {
        /// <summary>
        /// 检验范围信息 详细检验结果范围表--记录各体检机构各检验项目的范围信息
        /// </summary>
        public mh_jy_fw_info()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String fw_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String fwls_id { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public System.String fw_sex { get; set; }

        /// <summary>
        /// 项目简称
        /// </summary>
        public System.String fw_xm_jc { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public System.String fw_xm_mc { get; set; }

        /// <summary>
        /// 检查方法
        /// </summary>
        public System.String fw_xm_method { get; set; }

        /// <summary>
        /// 危机低值
        /// </summary>
        public System.Double? fw_min_low { get; set; }

        /// <summary>
        /// 正常低值
        /// </summary>
        public System.Double? fw_min { get; set; }

        /// <summary>
        /// 正常高值
        /// </summary>
        public System.Double? fw_max { get; set; }

        /// <summary>
        /// 危机高值
        /// </summary>
        public System.Double? fw_max_high { get; set; }

        /// <summary>
        /// 比例   危机低值
        /// </summary>
        public System.Double? fw_bl_min_low { get; set; }

        /// <summary>
        /// 比例  偏低值
        /// </summary>
        public System.Double? fw_bl_min { get; set; }

        /// <summary>
        /// 比例   偏高至
        /// </summary>
        public System.Double? fw_bl_max { get; set; }

        /// <summary>
        /// 比例  危机高值
        /// </summary>
        public System.Double? fw_bl_man_high { get; set; }

        /// <summary>
        /// 小数位长度
        /// </summary>
        public System.Int32? fw_xm_lenth { get; set; }
    }
}