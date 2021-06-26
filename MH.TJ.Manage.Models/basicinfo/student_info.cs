

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 中小学生健康体检    学生基本信息表
    /// </summary>
    public class student_info
    {
        /// <summary>
        /// 中小学生健康体检    学生基本信息表
        /// </summary>
        public student_info()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 沐华card
        /// </summary>
        public System.String mh_card { get; set; }

        /// <summary>
        /// 条码年份
        /// </summary>
        public System.Int32? year { get; set; }

        /// <summary>
        /// 学籍号
        /// </summary>
        public System.String xjh { get; set; }

        /// <summary>
        /// 条码号
        /// </summary>
        public System.String tmh { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public System.String xb { get; set; }

        /// <summary>
        /// 民族
        /// </summary>
        public System.String mz { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public System.String birthday { get; set; }

        /// <summary>
        /// 生源
        /// </summary>
        public System.String sy { get; set; }

        /// <summary>
        /// 籍贯
        /// </summary>
        public System.String jg { get; set; }

        /// <summary>
        /// 父姓名
        /// </summary>
        public System.String fxm { get; set; }

        /// <summary>
        /// 母姓名
        /// </summary>
        public System.String mxm { get; set; }

        /// <summary>
        /// 联系人身份证号
        /// </summary>
        public System.String lxr_sfz { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public System.String address { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public System.String phone { get; set; }

        /// <summary>
        /// 医疗支付方式 城镇居民、商业保险、全自费
        /// </summary>
        public System.String ylzffs { get; set; }

        /// <summary>
        /// 户籍状态 流动  户籍
        /// </summary>
        public System.String hjzt { get; set; }

        /// <summary>
        /// 月经初潮/首次遗精年龄
        /// </summary>
        public System.Int32? yj_age { get; set; }

        /// <summary>
        /// 家庭人口数
        /// </summary>
        public System.Int32? jtrks { get; set; }

        /// <summary>
        /// 既往史
        /// </summary>
        public System.String jws { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String createtime { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 社区名称
        /// </summary>
        public System.String community { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 是否移库    1已移库  0未移库  2 移库异常
        /// </summary>
        public System.UInt32? is_yk { get; set; }

        /// <summary>
        /// 移库信息
        /// </summary>
        public System.String yk_msg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? yc_time { get; set; }

        /// <summary>
        /// 移库人编号
        /// </summary>
        public System.String yk_user_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String xsbh { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String scjg { get; set; }
    }
}