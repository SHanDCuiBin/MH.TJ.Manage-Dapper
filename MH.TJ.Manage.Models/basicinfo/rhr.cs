

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 居民健康档案 (RHR Resident Health Record)  Essential information 基本信息
    /// </summary>
    public class rhr
    {
        /// <summary>
        /// 居民健康档案 (RHR Resident Health Record)  Essential information 基本信息
        /// </summary>
        public rhr()
        {
        }

        /// <summary>
        /// 个人档案编号
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 沐华个人档案编号
        /// </summary>
        public System.String mh_card { get; set; }

        /// <summary>
        /// 家庭档案编号
        /// </summary>
        public System.String family_archives_no { get; set; }

        /// <summary>
        /// 个人姓名
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 姓名拼音
        /// </summary>
        public System.String name_pinyin { get; set; }

        /// <summary>
        /// 0未知性别1 男 2 女 9 未说明性别
        /// </summary>
        public System.UInt32? gender_code { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public System.DateTime? birthday { get; set; }

        /// <summary>
        /// 证件类型 1 身份证类型   2 其他（护照 军官证及其其他）
        /// </summary>
        public System.Int32? certificate_type_code { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public System.String id_card { get; set; }

        /// <summary>
        /// 护照或者军官证号
        /// </summary>
        public System.String certificate_card { get; set; }

        /// <summary>
        /// 其他证件号
        /// </summary>
        public System.Int32? other_certificate_num { get; set; }

        /// <summary>
        /// 与户主的关系
        ///1:本人或户主;
        ///2:配偶;
        ///3:子;
        ///4:女婿;
        ///5:女;
        ///6:儿媳;
        ///7:孙子、孙女或外孙子、外孙女;
        ///8:父母;
        ///9:祖父母或外祖父母;
        ///10:兄、弟、姊、妹;
        ///11:其他;
        /// </summary>
        public System.Int32? relations_with_households_code { get; set; }

        /// <summary>
        /// 工作单位
        /// </summary>
        public System.String company { get; set; }

        /// <summary>
        /// 本人电话
        /// </summary>
        public System.String telephone { get; set; }

        /// <summary>
        /// E_mail
        ///
        /// </summary>
        public System.String e_mail { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        public System.String province { get; set; }

        /// <summary>
        /// 市
        ///
        /// </summary>
        public System.String city { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        public System.String area { get; set; }

        /// <summary>
        /// 街道
        /// </summary>
        public System.String street { get; set; }

        /// <summary>
        /// 居委会
        ////村
        /// </summary>
        public System.String neighborhood_committee { get; set; }

        /// <summary>
        /// 所属片区
        /// </summary>
        public System.String subordinate_area { get; set; }

        /// <summary>
        /// 家庭住址
        /// </summary>
        public System.String address { get; set; }

        /// <summary>
        /// 职业
        ///
        /// </summary>
        public System.String occupation { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        public System.String linkman { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        public System.String linkman_telephone { get; set; }

        /// <summary>
        /// 常住类型代码 1 本地户籍常住  2 本地户籍不常住  3 外地户籍  4 不详 
        /// </summary>
        public System.String rhr_resident_type { get; set; }

        /// <summary>
        /// 民族
        /// </summary>
        public System.String rhr_national { get; set; }

        /// <summary>
        /// 血型 0 O型1 A型 2 B型 3 AB型 5 不详 
        /// </summary>
        public System.String rhr_blood_type { get; set; }

        /// <summary>
        /// RH阴性代码 1 RH阴性2 RH阳性3 不详 
        /// </summary>
        public System.String rhr_blood_rh { get; set; }

        /// <summary>
        /// 文化程度代码  10 研究生及以上 20 大学本科 30 大学专科和专科学校 40中等专业学校 50 技工学校 60 高中 70 初中 80 小学 90 文盲或半文盲 99 学历不详 
        /// </summary>
        public System.String education_level { get; set; }

        /// <summary>
        /// 职业代码  1 农、林、牧、渔、水利业生产人员 2 生产、运输设备操作人员及有关人员 3 专业技术人员 4办事人员和有关人员 5商业、服务业人员6国家机关、党群组织、企事业单位负责人7在校学生 8 家务 9待业 10离退休人员 11婴幼、学龄前儿童 12军人3农民工 99 不便分类的其他从业人员 
        /// </summary>
        public System.String professional { get; set; }

        /// <summary>
        /// 婚姻状况 10 未婚 20 已婚 21 初婚 22 再婚23 复婚 30 丧偶 40 离异90 未说明的婚姻状况 
        /// </summary>
        public System.String marital_status { get; set; }

        /// <summary>
        /// 机构号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 怀孕情况
        /// </summary>
        public System.String pregnancy { get; set; }

        /// <summary>
        /// 孕次
        /// </summary>
        public System.Int32? gravidity { get; set; }

        /// <summary>
        /// 产次
        ///
        /// </summary>
        public System.Int32? parity { get; set; }

        /// <summary>
        /// 户籍地址
        /// </summary>
        public System.String hj_address { get; set; }

        /// <summary>
        /// 户籍状态 户籍人口(hj)  流动人口(ld)  暂住证(zzz) 
        /// </summary>
        public System.String hj_status { get; set; }

        /// <summary>
        /// 燃料类型代码
        /// </summary>
        public System.UInt32? fuel_type { get; set; }

        /// <summary>
        /// 燃料类型 存储规则:xx,xx,xx 比如:液化气,煤,天然气 
        /// </summary>
        public System.String fuel_type_info { get; set; }

        /// <summary>
        /// 禽畜栏代码 存储规则:xx,xx,xx比如:室内,室外 
        /// </summary>
        public System.Int32? livestock_bar_id { get; set; }

        /// <summary>
        /// 禽畜栏描述 存储规则:xx,xx,xx比如:室内,室外 
        /// </summary>
        public System.String livestock_bar_info { get; set; }

        /// <summary>
        /// 厨房通风设施代码
        /// </summary>
        public System.UInt32? kitchen_id { get; set; }

        /// <summary>
        /// 厨房通风设施描述 存储规则:xx,xx,xx 比如:换气扇,烟斗 
        /// </summary>
        public System.String kitchen_info { get; set; }

        /// <summary>
        /// 饮水代码 存储规则:xx,xx,xx 比如:自来水,井水,其他 
        /// </summary>
        public System.UInt32? drinking_water_id { get; set; }

        /// <summary>
        /// 饮水描述 存储规则:xx,xx,xx 比如:自来水,井水,其他 
        /// </summary>
        public System.String drinking_water_info { get; set; }

        /// <summary>
        /// 厕所代码
        /// </summary>
        public System.UInt32? toilet_id { get; set; }

        /// <summary>
        /// 厕所描述 存储规则:xx,xx,xx比如:卫生厕所,马桶 
        /// </summary>
        public System.String toilet_info { get; set; }

        /// <summary>
        /// 调查时间
        /// </summary>
        public System.DateTime? survey_time { get; set; }

        /// <summary>
        /// 采集医生
        /// </summary>
        public System.String survey_doctor { get; set; }

        /// <summary>
        /// 户主姓名
        /// </summary>
        public System.String householder_name { get; set; }

        /// <summary>
        /// 户主身份证
        /// </summary>
        public System.String householder_id_card { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? family_size { get; set; }

        /// <summary>
        /// 家庭结构
        /// </summary>
        public System.String family_structure { get; set; }

        /// <summary>
        /// 居住情况
        /// </summary>
        public System.String living_condition { get; set; }

        /// <summary>
        /// 创建地区
        /// </summary>
        public System.String create_org_id { get; set; }

        /// <summary>
        /// 修改者姓名
        /// </summary>
        public System.String update_user_name { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public System.DateTime? gmt_modified { get; set; }

        /// <summary>
        /// 创建者姓名
        ///
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? gmt_create { get; set; }

        /// <summary>
        /// 缺项数
        /// </summary>
        public System.Int32? missing_items { get; set; }

        /// <summary>
        /// 0为未删除1为已删除
        /// </summary>
        public System.UInt32 deleted { get; set; }
    }
}