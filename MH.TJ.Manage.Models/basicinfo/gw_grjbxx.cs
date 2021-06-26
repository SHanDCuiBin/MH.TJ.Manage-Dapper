

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 公卫平台 个人基本信息表
    /// </summary>
    public class gw_grjbxx
    {
        /// <summary>
        /// 公卫平台 个人基本信息表
        /// </summary>
        public gw_grjbxx()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 档案号（卫生院机构号+卫生室号+记录 次序号）
        /// </summary>
        public System.String dah { get; set; }

        /// <summary>
        ///  中联系统中档案的Id号
        /// </summary>
        public System.String zl_id { get; set; }

        /// <summary>
        ///  抓取的中联档案号
        /// </summary>
        public System.String zl_dah { get; set; }

        /// <summary>
        ///  1 活动  2 非活动
        /// </summary>
        public System.Int32? dazt { get; set; }

        /// <summary>
        /// 1 死亡  2 失踪 3 迁出 4 其他
        /// </summary>
        public System.String fhdyy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        ///  0未知性别 1 男 2 女 9 未说明性别
        /// </summary>
        public System.Int32? gengder { get; set; }

        /// <summary>
        /// 1 是  2 否
        /// </summary>
        public System.Int32? sbt { get; set; }

        /// <summary>
        ///  身份证 护照（外籍人士） 军官证
        /// </summary>
        public System.String zjlx { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String id_card { get; set; }

        /// <summary>
        /// 建档人的出生日期
        /// </summary>
        public System.DateTime? csrq { get; set; }

        /// <summary>
        /// 户籍人口(hj)  流动人口(ld)  暂住证(zzz)
        /// </summary>
        public System.String hjzt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String lxdh { get; set; }

        /// <summary>
        /// 本人电话
        /// </summary>
        public System.String brdh { get; set; }

        /// <summary>
        /// 联系人姓名(儿童-父母亲，老年人-儿女)
        /// </summary>
        public System.String lxrxm { get; set; }

        /// <summary>
        /// 1 本地户籍常住  2 本地户籍不常住  3 外地户籍  4 不详 
        /// </summary>
        public System.String czlx { get; set; }

        /// <summary>
        /// 所属名族的名称  比如：汉族 满族
        /// </summary>
        public System.String minz { get; set; }

        /// <summary>
        /// 0 O型 1 A型 2 B型 3 AB型 5 不详
        /// </summary>
        public System.String xuex { get; set; }

        /// <summary>
        /// 1 RH阴性 2 RH阳性 3 不详
        /// </summary>
        public System.String RH { get; set; }

        /// <summary>
        /// 10 研究生及以上 20 大学本科 30 大学专科和专科学校  40中等专业学校 50 技工学校 60 高中  70 初中 80 小学 90 文盲或半文盲  99 学历不详
        /// </summary>
        public System.String wenhcd { get; set; }

        /// <summary>
        /// 工作单位名称
        /// </summary>
        public System.String gzdw { get; set; }

        /// <summary>
        ///  1 农、林、牧、渔、水利业生产人员 2 生产、运输设备操作人员及有关人员   3 专业技术人员  4 办事人员和有关人员  5 商业、服务业人员  6 国家机关、党群组织、企事业单位负责人 7在校学生 8 家务 9 待业  10 离退休人员 11 婴幼、学龄前儿童  12 军人 13 农民工 99 不便分类的其他从业人员
        /// </summary>
        public System.String zhiye { get; set; }

        /// <summary>
        /// 1 极轻（卧床或很少活动）  2 轻度（办公室工作、修电器钟表，酒店服务员，讲课等   3 中度（学生日常活动、汽车驾驶、电工安装、金属切削等）  4 重度（非机械化农业劳动、炼钢、舞蹈、体育运动、装卸）5 极重
        /// </summary>
        public System.String ldqd { get; set; }

        /// <summary>
        /// 10 未婚 20 已婚 21 初婚 22 再婚  23 复婚 30 丧偶 40 离异  90 未说明的婚姻状况
        /// </summary>
        public System.String hyzk { get; set; }

        /// <summary>
        /// 多选，存储格式:  xx,xx,xx,xx  其它支付方式格式: xx,xx,xx,其它支付方式名称
        /// </summary>
        public System.String ylzffs { get; set; }

        /// <summary>
        /// 1 有 2 无
        /// </summary>
        public System.String ywgms { get; set; }

        /// <summary>
        /// 多选  ，存储方式: xx,xx,xx,xx  其它药物格式: xx,xx,xx,其它过敏药物名称
        /// </summary>
        public System.String ywgms_detail { get; set; }

        /// <summary>
        /// 所在省份
        /// </summary>
        public System.String sheng { get; set; }

        /// <summary>
        /// 所在市
        /// </summary>
        public System.String shi { get; set; }

        /// <summary>
        /// 所在区县
        /// </summary>
        public System.String qu { get; set; }

        /// <summary>
        /// 所在乡镇
        /// </summary>
        public System.String zhen { get; set; }

        /// <summary>
        /// 所在村/街道
        /// </summary>
        public System.String cun { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String address { get; set; }

        /// <summary>
        /// 医疗保险号
        /// </summary>
        public System.String ylbxh { get; set; }

        /// <summary>
        /// 新农合号
        /// </summary>
        public System.String xnhh { get; set; }

        /// <summary>
        /// 1 有 2 无
        /// </summary>
        public System.String jws_xbs { get; set; }

        /// <summary>
        /// 多选项，存储示例:高血压,糖尿病,恶性肿瘤}确诊时间; 既往史其它示例:高血压,糖尿病,其它既往史名称}确诊时间;
        /// </summary>
        public System.String jws { get; set; }

        /// <summary>
        /// 手术历史有无 1 无 2 有
        /// </summary>
        public System.String shous { get; set; }

        /// <summary>
        /// 手术历史记录示例:手术名称,手术时间;
        /// </summary>
        public System.String shouss { get; set; }

        /// <summary>
        /// 外伤历史有无 1 无 2 有
        /// </summary>
        public System.String wais { get; set; }

        /// <summary>
        /// 外伤历史记录示例:外伤名称,外伤时间;
        /// </summary>
        public System.String waiss { get; set; }

        /// <summary>
        /// 输血历史有无 1 无 2 有
        /// </summary>
        public System.String shuxue { get; set; }

        /// <summary>
        /// 输血历史记录示例:输血原因,输血时间;
        /// </summary>
        public System.String shuxues { get; set; }

        /// <summary>
        /// 1 有 2 无
        /// </summary>
        public System.String jzs { get; set; }

        /// <summary>
        /// 多选项，存储示例:高血压,糖尿病,恶性肿瘤}父亲;  既往史其它示例:高血压,糖尿病,其它家族史名称}祖父;
        /// </summary>
        public System.String jzs_detail { get; set; }

        /// <summary>
        /// 1 有 2 无
        /// </summary>
        public System.String baols { get; set; }

        /// <summary>
        /// 存储规则:化学品,毒物名称,射线  规则扩展：化学品,毒物名称,射线,扩展名称
        /// </summary>
        public System.String baols_detail { get; set; }

        /// <summary>
        /// 1 有 2 无
        /// </summary>
        public System.String yichuanbs { get; set; }

        /// <summary>
        /// 存储规则:遗传病名称,遗传病名称示例:神经病,脑卒中
        /// </summary>
        public System.String yichuanbs_detail { get; set; }

        /// <summary>
        /// 1 有 2 无
        /// </summary>
        public System.String cjqk { get; set; }

        /// <summary>
        /// 多选项，存储示例:听力残,言语残 残疾史其它示例: 听力残,言语残,其它残疾名称;
        /// </summary>
        public System.String cjqk_detail { get; set; }

        /// <summary>
        /// 0 未孕 1 已孕未生产 2 已生产(随访期内) 3 已生产(随访期外)
        /// </summary>
        public System.String ycqk { get; set; }

        /// <summary>
        /// 怀孕次数
        /// </summary>
        public System.Int32? yc_yc { get; set; }

        /// <summary>
        /// 生产次数
        /// </summary>
        public System.Int32? yc_cc { get; set; }

        /// <summary>
        /// 存储规则:xx,xx,xx 比如:换气扇,烟斗
        /// </summary>
        public System.String cfpfss { get; set; }

        /// <summary>
        /// 存储规则:xx,xx,xx 比如:液化气,煤,天然气 
        /// </summary>
        public System.String ranllx { get; set; }

        /// <summary>
        /// 存储规则:xx,xx,xx 比如:自来水,井水,其他 
        /// </summary>
        public System.String yinshui { get; set; }

        /// <summary>
        /// 存储规则:xx,xx,xx 比如:卫生厕所,马桶 
        /// </summary>
        public System.String cesuo { get; set; }

        /// <summary>
        /// 存储规则:xx,xx,xx 比如:室内,室外
        /// </summary>
        public System.String qinchul { get; set; }

        /// <summary>
        /// 调查时间  时间格式:yyyy-MM-dd
        /// </summary>
        public System.DateTime? dcsj { get; set; }

        /// <summary>
        /// 创建时间  时间格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 更新时间  时间格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        public System.DateTime? update_time { get; set; }

        /// <summary>
        /// 中联创建时间  时间格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        public System.DateTime? zl_create_time { get; set; }

        /// <summary>
        /// 中联更新时间  时间格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        public System.DateTime? zl_update_time { get; set; }

        /// <summary>
        /// 创建人ID号
        /// </summary>
        public System.String create_user_id { get; set; }

        /// <summary>
        /// 创建人名称
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 更新人ID号
        /// </summary>
        public System.String update_user_id { get; set; }

        /// <summary>
        /// 更新人名称
        /// </summary>
        public System.String update_user_name { get; set; }

        /// <summary>
        /// 中联创建人ID号
        /// </summary>
        public System.String zl_create_user_id { get; set; }

        /// <summary>
        /// 中联创建人名称
        /// </summary>
        public System.String zl_create_user_name { get; set; }

        /// <summary>
        /// 更新人ID号
        /// </summary>
        public System.String zl_update_user_id { get; set; }

        /// <summary>
        /// 中联更新人名称
        /// </summary>
        public System.String zl_update_user_name { get; set; }

        /// <summary>
        /// 档案机构创建ID
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 档案机构普创建名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 中联档案机构创建ID
        /// </summary>
        public System.String zl_org_id { get; set; }

        /// <summary>
        /// 中联档案机构普创建名称
        /// </summary>
        public System.String zl_org_name { get; set; }

        /// <summary>
        /// 当前所属机构ID号
        /// </summary>
        public System.String b_org_id { get; set; }

        /// <summary>
        /// 当前所属机构名称
        /// </summary>
        public System.String b_org_name { get; set; }

        /// <summary>
        /// 中联当前所属机构ID号
        /// </summary>
        public System.String zl_b_org_id { get; set; }

        /// <summary>
        /// 中联当前所属机构名称
        /// </summary>
        public System.String zl_b_org_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? up_create_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? up_update_time { get; set; }

        /// <summary>
        /// 上传标记
        /// </summary>
        public System.Int32? up_flag { get; set; }

        /// <summary>
        /// 上传结果描述信息
        /// </summary>
        public System.String up_msg { get; set; }

        /// <summary>
        /// 上传用户Id号
        /// </summary>
        public System.String up_user_id { get; set; }

        /// <summary>
        /// 上传用户名称
        /// </summary>
        public System.String up_user_name { get; set; }

        /// <summary>
        /// 中联抓取时间
        /// </summary>
        public System.DateTime? zq_time { get; set; }

        /// <summary>
        /// 0 抓取  1 主动生成
        /// </summary>
        public System.String orign { get; set; }

        /// <summary>
        /// 家庭档案号
        /// </summary>
        public System.String jtdah { get; set; }

        /// <summary>
        /// 中联家庭档案号
        /// </summary>
        public System.String zl_jtdah { get; set; }

        /// <summary>
        /// 档案类型1户主 2配偶 3子女 4外孙子女 5父母 6外祖父母 7兄弟姐妹 99其它
        /// </summary>
        public System.String da_type { get; set; }

        /// <summary>
        /// 门诊接待次数
        /// </summary>
        public System.Int32? mz_count { get; set; }

        /// <summary>
        /// 孕产妇多余字段
        /// </summary>
        public System.String yyzffs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? local_flag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? qxx { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? wzd { get; set; }

        /// <summary>
        /// 档案是否合格   -1 未校验  0 不合格  1 合格
        /// </summary>
        public System.Int32? is_hg { get; set; }

        /// <summary>
        /// 档案不合格原因描述
        /// </summary>
        public System.String qxx_msg { get; set; }

        /// <summary>
        /// 不知谁添加的字段
        /// </summary>
        public System.String grbs { get; set; }

        /// <summary>
        /// 
        ///医疗支付方式 其他
        /// </summary>
        public System.String ylzffsqt { get; set; }

        /// <summary>
        /// 药物过敏史 其他
        /// </summary>
        public System.String ywgmsqt { get; set; }

        /// <summary>
        /// 其他残疾
        /// </summary>
        public System.String qtcj { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String doctor_url { get; set; }
    }
}