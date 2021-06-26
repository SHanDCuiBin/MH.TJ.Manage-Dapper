

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 公卫平台抓取个人基本信息表
    /// </summary>
    public class mh_gwtq_grjbxx
    {
        /// <summary>
        /// 公卫平台抓取个人基本信息表
        /// </summary>
        public mh_gwtq_grjbxx()
        {
        }

        /// <summary>
        /// 主键 姓名_性别_出生日期(yyyyMMdd) 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 属于沐华管理的档案号 
        /// </summary>
        public System.String mh_card { get; set; }

        /// <summary>
        /// 对应公卫的档案号 
        /// </summary>
        public System.String gw_dah { get; set; }

        /// <summary>
        /// 条码号—最新参加体检的条码号 
        /// </summary>
        public System.String tmh { get; set; }

        /// <summary>
        /// 最新体检的年份
        /// </summary>
        public System.Int32? year { get; set; }

        /// <summary>
        /// 证件照地址    相对路径 存储示例:/xx/xx/../*.jpg 
        /// </summary>
        public System.String zjz_url { get; set; }

        /// <summary>
        /// 档案类型 1户主 2配偶 3子女 4外孙子女 5父母 6外祖父母 7兄弟姐妹 99其它 
        /// </summary>
        public System.String da_type { get; set; }

        /// <summary>
        ///  1活动  2非活动 
        /// </summary>
        public System.Int32? dazt { get; set; }

        /// <summary>
        ///  1 死亡  2 失踪 3 迁出 4 其他 
        /// </summary>
        public System.String fhdyy { get; set; }

        /// <summary>
        /// 姓名 
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 0未知性别1 男 2 女 9 未说明性别 
        /// </summary>
        public System.Int32? gengder { get; set; }

        /// <summary>
        /// 1 身份证类型   2 其他（户籍 军官证及其其他） 
        /// </summary>
        public System.String zjlx { get; set; }

        /// <summary>
        /// 建档类型的卡号 
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
        /// 联系电话 
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
        /// 所属名族的名称比如：汉族满族 
        /// </summary>
        public System.String minz { get; set; }

        /// <summary>
        /// 0 O型1 A型 2 B型 3 AB型 5 不详 
        /// </summary>
        public System.String xuex { get; set; }

        /// <summary>
        /// 1 RH阴性2 RH阳性3 不详 
        /// </summary>
        public System.String RH { get; set; }

        /// <summary>
        /// 10 研究生及以上 20 大学本科 30 大学专科和专科学校 40中等专业学校 50 技工学校 60 高中 70 初中 80 小学 90 文盲或半文盲 99 学历不详 
        /// </summary>
        public System.String wenhcd { get; set; }

        /// <summary>
        /// 工作单位名称 
        /// </summary>
        public System.String gzdw { get; set; }

        /// <summary>
        /// 1 农、林、牧、渔、水利业生产人员 2 生产、运输设备操作人员及有关人员 3 专业技术人员 4办事人员和有关人员 5商业、服务业人员6国家机关、党群组织、企事业单位负责人7在校学生 8 家务 9待业 10离退休人员 11婴幼、学龄前儿童 12军人3农民工 99 不便分类的其他从业人员 
        /// </summary>
        public System.String zhiye { get; set; }

        /// <summary>
        ///  1 极轻（卧床或很少活动）2 轻度（办公室工作、修电器钟表，酒店服务员，讲课等3 中度（学生日常活动、汽车驾驶、电工安装、金属切削等）4 重度（非机械化农业劳动、炼钢、舞蹈、体育运动、装卸）5 极重 
        /// </summary>
        public System.String ldqd { get; set; }

        /// <summary>
        /// 10 未婚 20 已婚 21 初婚 22 再婚23 复婚 30 丧偶 40 离异90 未说明的婚姻状况 
        /// </summary>
        public System.String hyzk { get; set; }

        /// <summary>
        /// 多选，存储格式: xx,xx,xx,xx 其它支付方式格式: xx,xx,xx,其它支付方式名称 
        /// </summary>
        public System.String yyzffs { get; set; }

        /// <summary>
        /// 城镇或省直职工基本医疗保险卡号
        /// </summary>
        public System.String czjm_ybkh { get; set; }

        /// <summary>
        /// 居民基本医疗保险  医保卡号
        /// </summary>
        public System.String jmjbyl_ybkh { get; set; }

        /// <summary>
        /// 贫困救助  医保卡号
        /// </summary>
        public System.String pkjz_ybkh { get; set; }

        /// <summary>
        /// 1 有 2 无 
        /// </summary>
        public System.String ywgms { get; set; }

        /// <summary>
        /// 多选，存储方式: xx,xx,xx,xx 其它药物格式: xx,xx,xx,其它过敏药物名称 
        /// </summary>
        public System.String ywgms_detail { get; set; }

        /// <summary>
        /// 所在省份 
        /// </summary>
        public System.String shen { get; set; }

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
        /// 详细地址 
        /// </summary>
        public System.String address { get; set; }

        /// <summary>
        /// 户籍地址
        /// </summary>
        public System.String hj_address { get; set; }

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
        /// 多选项，存储示例:高血压,糖尿病,恶性肿瘤}父亲;既往史其它示例:高血压,糖尿病,其它家族史名称}祖父; 
        /// </summary>
        public System.String jzs_detail { get; set; }

        /// <summary>
        /// 1 有 2 无 
        /// </summary>
        public System.String baols { get; set; }

        /// <summary>
        /// 存储规则:化学品,毒物名称,射线 比如:甲醛,敌敌畏,紫外线 规则扩展：化学品,毒物名称,射线,扩展名称 
        /// </summary>
        public System.String baols_detail { get; set; }

        /// <summary>
        /// 1 有 2 无 
        /// </summary>
        public System.String yichuanbs { get; set; }

        /// <summary>
        /// 存储规则:遗传病名称,遗传病名称 示例:神经病,脑卒中 
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
        /// 存储规则:xx,xx,xx比如:卫生厕所,马桶 
        /// </summary>
        public System.String cesuo { get; set; }

        /// <summary>
        /// 存储规则:xx,xx,xx比如:室内,室外 
        /// </summary>
        public System.String qinchul { get; set; }

        /// <summary>
        /// 调查时间时间格式:yyyy-MM-dd 
        /// </summary>
        public System.DateTime? dcsj { get; set; }

        /// <summary>
        /// 创建人ID号 
        /// </summary>
        public System.String create_user_id { get; set; }

        /// <summary>
        /// 创建人名称 
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 创建时间时间格式:yyyy-MM-dd HH:mm:ss 
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 更新人ID号 
        /// </summary>
        public System.String update_user_id { get; set; }

        /// <summary>
        /// 更新人名称 
        /// </summary>
        public System.String update_user_name { get; set; }

        /// <summary>
        /// 更新时间时间格式:yyyy-MM-dd HH:mm:ss 
        /// </summary>
        public System.DateTime? update_time { get; set; }

        /// <summary>
        /// 档案机构创建ID 
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 档案机构普创建名称 
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 上传云平台数据时间 
        /// </summary>
        public System.DateTime? up_create_time { get; set; }

        /// <summary>
        /// 更新云平台数据时间 
        /// </summary>
        public System.DateTime? up_update_time { get; set; }

        /// <summary>
        /// 数据采集来源0 老年人跟车  1 慢病系统  2 儿童3 孕产妇  4其他采集端存储格式:0,1,3 表示老年人  慢病 孕产妇均采集过个人档案信息  
        /// </summary>
        public System.String orign { get; set; }

        /// <summary>
        /// 档案状态   null 未校验  00 不   存在档案11S单档案  12D多档案 17SB单档案18DB多档案  本机构13SNF院内单档案  14DNF院内多档案 非本机构15SWF院外单档案  16DWF院外多档案  
        /// </summary>
        public System.String is_daExist { get; set; }

        /// <summary>
        /// 当前档案状态的描述信息 
        /// </summary>
        public System.String da_msg { get; set; }

        /// <summary>
        /// null 未校验  00 不存在档案 1 活动  2 非活动 
        /// </summary>
        public System.String is_active { get; set; }

        /// <summary>
        /// 新建档案日期—沐华对接公卫档案存储格式：’yyyy-MM-dd HH:mm:ss’非沐华创建的档案的为空。 
        /// </summary>
        public System.DateTime? is_new { get; set; }

        /// <summary>
        /// 户主姓名
        /// </summary>
        public System.String hzxm { get; set; }

        /// <summary>
        /// 户主身份证号
        /// </summary>
        public System.String hz_sfz { get; set; }

        /// <summary>
        /// 家庭人口数
        /// </summary>
        public System.Int32? jtrks { get; set; }

        /// <summary>
        /// 家庭结构
        /// </summary>
        public System.String jtjg { get; set; }

        /// <summary>
        /// 居住情况
        /// </summary>
        public System.String jzqk { get; set; }

        /// <summary>
        /// 常驻类型
        /// </summary>
        public System.String cjys { get; set; }

        /// <summary>
        /// 健康卡号
        /// </summary>
        public System.String jkkh { get; set; }

        /// <summary>
        /// 户口性质
        /// </summary>
        public System.String hkxz { get; set; }

        /// <summary>
        /// 人户关系
        /// </summary>
        public System.String rhgx { get; set; }

        /// <summary>
        /// 流入时间
        /// </summary>
        public System.DateTime? lrsj { get; set; }

        /// <summary>
        /// QQ号
        /// </summary>
        public System.String qq { get; set; }

        /// <summary>
        /// 微信
        /// </summary>
        public System.String weixin { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        public System.String youb { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public System.String email { get; set; }

        /// <summary>
        /// 特殊人群
        /// </summary>
        public System.String tsrq { get; set; }

        /// <summary>
        /// 公卫档案id
        /// </summary>
        public System.String da_id { get; set; }

        /// <summary>
        /// 公卫家庭id
        /// </summary>
        public System.String family_id { get; set; }
    }
}