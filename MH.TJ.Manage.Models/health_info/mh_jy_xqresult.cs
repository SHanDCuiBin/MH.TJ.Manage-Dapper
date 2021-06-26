
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 血球检验结果表--记录血球检验结果
    /// </summary>
    public class mh_jy_xqresult
    {
        /// <summary>
        /// 血球检验结果表--记录血球检验结果
        /// </summary>
        public mh_jy_xqresult()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String jyid { get; set; }

        /// <summary>
        /// 外键  对应  mh_jy_parson 的 jy_parid
        /// </summary>
        public System.String xq_parid { get; set; }

        /// <summary>
        /// 检验方法
        /// </summary>
        public System.String item_method { get; set; }

        /// <summary>
        /// 检验项目  简称
        /// </summary>
        public System.String item_code { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public System.String item_name { get; set; }

        /// <summary>
        /// 检验结果
        /// </summary>
        public System.String item_value { get; set; }

        /// <summary>
        /// 项目范围       低值
        /// </summary>
        public System.String item_low { get; set; }

        /// <summary>
        /// 项目范围       高值
        /// </summary>
        public System.String item_high { get; set; }

        /// <summary>
        /// 检验范围
        /// </summary>
        public System.String item_limit { get; set; }

        /// <summary>
        /// 项目单位
        /// </summary>
        public System.String item_unit { get; set; }

        /// <summary>
        /// 检验异常结论   -2 危机低 -1偏低   0正常  1 偏高  2危机高
        /// </summary>
        public System.String item_flag { get; set; }

        /// <summary>
        /// 检验结果描述
        /// </summary>
        public System.String item_msg { get; set; }

        /// <summary>
        /// 检验结束时间
        /// </summary>
        public System.DateTime? receive_time { get; set; }

        /// <summary>
        /// 检验时间
        /// </summary>
        public System.DateTime? inspect_time { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 创建者ID号
        /// </summary>
        public System.String create_user_id { get; set; }

        /// <summary>
        /// 创建者姓名
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? update_time { get; set; }

        /// <summary>
        /// 修改者ID号
        /// </summary>
        public System.String update_user_id { get; set; }

        /// <summary>
        /// 修改者姓名
        /// </summary>
        public System.String update_user_name { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 检验结果状态是否人工审核 0不需要审核  1需要审核
        /// </summary>
        public System.Int32? jy_state { get; set; }
    }
}