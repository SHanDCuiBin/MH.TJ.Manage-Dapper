

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 【沐华健康体检管理系统】检验项目  信息表  检验项目 字典--体检信息字段与检验项目字段的关系对应表
    /// </summary>
    public class mh_jy_iteminfo
    {
        /// <summary>
        /// 【沐华健康体检管理系统】检验项目  信息表  检验项目 字典--体检信息字段与检验项目字段的关系对应表
        /// </summary>
        public mh_jy_iteminfo()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String jy_xm_id { get; set; }

        /// <summary>
        /// 体检类型   1 公卫健康体检   2  教师健康体检   3  幼儿园健康体检      4  学生健康体检  
        /// </summary>
        public System.Int32? jy_tj_type { get; set; }

        /// <summary>
        /// 项目类型    1 生化检查   2 肿瘤检查  3 电解质检查 4 血常规检查 5尿检 6心电 7 b超 8 x光  9乙肝五项  0基础信息
        /// </summary>
        public System.Int32 jy_xm_type { get; set; }

        /// <summary>
        /// 化验单打印 项目显示顺序
        /// </summary>
        public System.Int32? jy_xm_dysx { get; set; }

        /// <summary>
        /// 检验项目简称
        /// </summary>
        public System.String jy_xm_jc { get; set; }

        /// <summary>
        /// 检验项目名称
        /// </summary>
        public System.String jy_xm_mc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String jy_xm_dw { get; set; }

        /// <summary>
        /// 对应体检表字段
        /// </summary>
        public System.String jy_xm_tj { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? jy_xm_enable { get; set; }
    }
}