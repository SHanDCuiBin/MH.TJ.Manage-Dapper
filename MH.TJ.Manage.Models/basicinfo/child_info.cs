

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 儿童个人信息表 --用户中心功能   记录儿童的基本信息
    /// </summary>
    public class child_info
    {
        /// <summary>
        /// 儿童个人信息表 --用户中心功能   记录儿童的基本信息
        /// </summary>
        public child_info()
        {
        }

        /// <summary>
        /// 姓名_性别_出生日期(yyyyMMdd)  主键
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? year { get; set; }

        /// <summary>
        /// 沐华编号 唯一性
        /// </summary>
        public System.String mh_card { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String tmh { get; set; }

        /// <summary>
        /// 民族  存储格式：“汉族”    不填 默认汉族
        /// </summary>
        public System.String minz { get; set; }

        /// <summary>
        /// 当前所属儿童机构ID号      必填
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 当前儿童机构名称          必填
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String banji { get; set; }

        /// <summary>
        /// 母亲姓名
        /// </summary>
        public System.String m_name { get; set; }

        /// <summary>
        /// 母亲身份证号
        /// </summary>
        public System.String m_sfz { get; set; }

        /// <summary>
        /// 母亲出生日期
        /// </summary>
        public System.DateTime? m_csrq { get; set; }

        /// <summary>
        /// 母亲职业
        /// </summary>
        public System.String m_zy { get; set; }

        /// <summary>
        /// 母亲联系电话
        /// </summary>
        public System.String m_tel { get; set; }

        /// <summary>
        /// 母亲状态 正常、离异、离世
        /// </summary>
        public System.String m_status { get; set; }

        /// <summary>
        /// 父亲姓名
        /// </summary>
        public System.String f_name { get; set; }

        /// <summary>
        /// 父亲身份证号
        /// </summary>
        public System.String f_sfz { get; set; }

        /// <summary>
        /// 父亲出生日期
        /// </summary>
        public System.DateTime? f_csrq { get; set; }

        /// <summary>
        /// 父亲职业
        /// </summary>
        public System.String f_zy { get; set; }

        /// <summary>
        /// 父亲联系电话
        /// </summary>
        public System.String f_tel { get; set; }

        /// <summary>
        /// 父亲状态 正常、离异、离世
        /// </summary>
        public System.String f_status { get; set; }

        /// <summary>
        /// 常住类型 0本地户籍 1外地户籍
        /// </summary>
        public System.String czlx { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String hjlx { get; set; }

        /// <summary>
        /// 居住地址
        /// </summary>
        public System.String address { get; set; }

        /// <summary>
        /// 数据是否完整 0 不完整  1 完整  2 不完整
        /// </summary>
        public System.Int32? is_wz { get; set; }

        /// <summary>
        /// 数据完整性描述
        /// </summary>
        public System.String wz_msg { get; set; }

        /// <summary>
        /// 创建人ID号     跟车人ID号
        /// </summary>
        public System.String create_user_id { get; set; }

        /// <summary>
        /// 创建人名称     跟车人姓名
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 更新人ID号      跟车人ID号
        /// </summary>
        public System.String update_user_id { get; set; }

        /// <summary>
        /// 更新人名称      跟车人姓名
        /// </summary>
        public System.String update_user_name { get; set; }

        /// <summary>
        /// 创建时间  采集端  初次导入时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 更新时间  采集端  更新时间
        /// </summary>
        public System.DateTime? update_time { get; set; }

        /// <summary>
        /// 是否移库， 1已移库  0未移库   2移库异常
        /// </summary>
        public System.Int32? is_yk { get; set; }

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
        /// 医疗支付方式  存储格式: 默认 ”城镇居民基本医疗保险”
        /// </summary>
        public System.String ylzffs { get; set; }

        /// <summary>
        /// 公卫上所属居委会或社区 机构号
        /// </summary>
        public System.String neighborhood_committee_id { get; set; }

        /// <summary>
        /// 公卫上所属居委会或社区
        /// </summary>
        public System.String neighborhood_committee { get; set; }
    }
}