
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 健康体检表 --健康体检功能   记录老年人健康体检的数据信息
    /// </summary>
    public class mh_jktj
    {
        /// <summary>
        /// 健康体检表 --健康体检功能   记录老年人健康体检的数据信息
        /// </summary>
        public mh_jktj()
        {
        }

        /// <summary>
        /// 条码号_随访日期 (yyyyMMdd) 主键
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 沐华对应的档案编号 机构号_年份_条码
        /// </summary>
        public System.String mh_card { get; set; }

        /// <summary>
        /// 条码号 对应体检的条码号
        /// </summary>
        public System.String tmh { get; set; }

        /// <summary>
        /// 当前体检年龄
        /// </summary>
        public System.Int32? age { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String gender { get; set; }

        /// <summary>
        /// null/0 默认收费  1不收费
        /// </summary>
        public System.UInt32? is_fufei { get; set; }

        /// <summary>
        /// 人员类型   1老年人/2成年人/3精神病 /4体制内（免费）/5贫困人口/6其他人员类型
        /// </summary>
        public System.String ry_type { get; set; }

        /// <summary>
        /// 机构编号---体检所属机构ID号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 机构名称---体检所属机构名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 体检日期
        /// </summary>
        public System.DateTime? tjrq { get; set; }

        /// <summary>
        /// 体温
        /// </summary>
        public System.Double? tiwen { get; set; }

        /// <summary>
        /// 身高 ----身高体重模块
        /// </summary>
        public System.Double? sg { get; set; }

        /// <summary>
        /// 体重
        /// </summary>
        public System.Double? tz { get; set; }

        /// <summary>
        /// 腰围
        /// </summary>
        public System.Double? yaowei { get; set; }

        /// <summary>
        /// 体重指数
        /// </summary>
        public System.Double? bmi { get; set; }

        /// <summary>
        /// 身高检查者
        /// </summary>
        public System.String sgfzr { get; set; }

        /// <summary>
        /// 左血压高 ----血压模块
        /// </summary>
        public System.Double? zxyg { get; set; }

        /// <summary>
        /// 左血压低
        /// </summary>
        public System.Double? zxyd { get; set; }

        /// <summary>
        /// 右血压高
        /// </summary>
        public System.Double? yxyg { get; set; }

        /// <summary>
        /// 右血压低
        /// </summary>
        public System.Double? yxyd { get; set; }

        /// <summary>
        /// 呼吸频率
        /// </summary>
        public System.Double? hxpl { get; set; }

        /// <summary>
        /// 脉率
        /// </summary>
        public System.Double? mailv { get; set; }

        /// <summary>
        /// 心率
        /// </summary>
        public System.Double? xl { get; set; }

        /// <summary>
        /// 血压采集人
        /// </summary>
        public System.String xyfzr { get; set; }

        /// <summary>
        /// null/0未查  1 正常  2 异常 ----心电图
        /// </summary>
        public System.Int32? xdt_flag { get; set; }

        /// <summary>
        /// 心电图异常   存储机器结论
        /// </summary>
        public System.String xdtyc { get; set; }

        /// <summary>
        /// 心电图结论   医生异常指导
        /// </summary>
        public System.String xdtjl { get; set; }

        /// <summary>
        /// 用于存储心电图原始机器结论
        /// </summary>
        public System.String xdt_jqjl { get; set; }

        /// <summary>
        /// 心电图 审核医生
        /// </summary>
        public System.String xdt_sh_ys { get; set; }

        /// <summary>
        /// B超结论  null/0  未做 1  正常 2 异常---B超
        /// </summary>
        public System.Int32? bc_flag { get; set; }

        /// <summary>
        /// B超所见   医生审核描述信息
        /// </summary>
        public System.String bchaosj { get; set; }

        /// <summary>
        /// B超异常   医生诊断结论
        /// </summary>
        public System.String bchaoyc { get; set; }

        /// <summary>
        /// B超指导   医生B超指导，医生下的结论
        /// </summary>
        public System.String bc_zd { get; set; }

        /// <summary>
        /// B超医生
        /// </summary>
        public System.String bcys { get; set; }

        /// <summary>
        /// X结论  null/0  未做   1  正常   2 异常---X光
        /// </summary>
        public System.Int32? xg_flag { get; set; }

        /// <summary>
        /// X光所见        医生审核描述信息  
        /// </summary>
        public System.String x_suojian { get; set; }

        /// <summary>
        /// X光异常结论    医生诊断结论
        /// </summary>
        public System.String x_ray { get; set; }

        /// <summary>
        /// X光医生
        /// </summary>
        public System.String x_ys { get; set; }

        /// <summary>
        /// 症状               -----问诊
        /// </summary>
        public System.String zz { get; set; }

        /// <summary>
        /// 健康状态自我评估
        /// </summary>
        public System.String jkztzwpg { get; set; }

        /// <summary>
        /// 自理能力自我评估
        /// </summary>
        public System.String zlnlzwpg { get; set; }

        /// <summary>
        /// 老年人认知功能
        /// </summary>
        public System.String lnrrznl { get; set; }

        /// <summary>
        /// 老年人情感状态
        /// </summary>
        public System.String lnrqgzt { get; set; }

        /// <summary>
        /// 锻炼频率
        /// </summary>
        public System.String dlpl { get; set; }

        /// <summary>
        /// 每次锻炼时间
        /// </summary>
        public System.String mcdlsj { get; set; }

        /// <summary>
        /// 坚持锻炼时间
        /// </summary>
        public System.String jcdlsj { get; set; }

        /// <summary>
        /// 锻炼方式
        /// </summary>
        public System.String dlfs { get; set; }

        /// <summary>
        /// 饮食习惯  “”
        /// </summary>
        public System.String ysxg { get; set; }

        /// <summary>
        /// 吸烟状况
        /// </summary>
        public System.String xyzk { get; set; }

        /// <summary>
        /// 日吸烟量
        /// </summary>
        public System.String rxyl { get; set; }

        /// <summary>
        /// 开始吸烟年龄
        /// </summary>
        public System.String ksxynl { get; set; }

        /// <summary>
        /// 戒烟年龄
        /// </summary>
        public System.String jynl { get; set; }

        /// <summary>
        /// 饮酒频率
        /// </summary>
        public System.String yjpl { get; set; }

        /// <summary>
        /// 日饮酒量
        /// </summary>
        public System.String ryjl { get; set; }

        /// <summary>
        /// 是否戒酒
        /// </summary>
        public System.String sfjj { get; set; }

        /// <summary>
        /// 戒酒年龄
        /// </summary>
        public System.String jjnl { get; set; }

        /// <summary>
        /// 开始饮酒年龄
        /// </summary>
        public System.String ksyjnl { get; set; }

        /// <summary>
        /// 是否醉酒
        /// </summary>
        public System.String sfzj { get; set; }

        /// <summary>
        /// 饮酒种类
        /// </summary>
        public System.String yjzl { get; set; }

        /// <summary>
        /// 职业病暴露史
        /// </summary>
        public System.String zybjcs { get; set; }

        /// <summary>
        /// 口唇
        /// </summary>
        public System.String koucun { get; set; }

        /// <summary>
        /// 齿列
        /// </summary>
        public System.String chilie { get; set; }

        /// <summary>
        /// 义齿
        /// </summary>
        public System.String yichi { get; set; }

        /// <summary>
        /// 龋齿
        /// </summary>
        public System.String quchi { get; set; }

        /// <summary>
        /// 缺齿
        /// </summary>
        public System.String quechi { get; set; }

        /// <summary>
        /// 咽部
        /// </summary>
        public System.String yanbu { get; set; }

        /// <summary>
        /// 左眼视力
        /// </summary>
        public System.Double? zysl { get; set; }

        /// <summary>
        /// 右眼视力
        /// </summary>
        public System.Double? yysl { get; set; }

        /// <summary>
        /// 左眼矫正视力
        /// </summary>
        public System.Double? zyjzsl { get; set; }

        /// <summary>
        /// 右眼矫正视力
        /// </summary>
        public System.Double? yyjzsl { get; set; }

        /// <summary>
        /// 听力   
        /// </summary>
        public System.String tingli { get; set; }

        /// <summary>
        /// 运动功能
        /// </summary>
        public System.String ydgn { get; set; }

        /// <summary>
        /// 眼底
        /// </summary>
        public System.String yandi { get; set; }

        /// <summary>
        /// 皮肤
        /// </summary>
        public System.String pifu { get; set; }

        /// <summary>
        /// 巩膜
        /// </summary>
        public System.String gongmo { get; set; }

        /// <summary>
        /// 淋巴结
        /// </summary>
        public System.String linbajie { get; set; }

        /// <summary>
        /// 桶状胸
        /// </summary>
        public System.String tzx { get; set; }

        /// <summary>
        /// 呼吸音
        /// </summary>
        public System.String hxy { get; set; }

        /// <summary>
        /// 罗音
        /// </summary>
        public System.String ly { get; set; }

        /// <summary>
        /// 心律
        /// </summary>
        public System.String xinlv { get; set; }

        /// <summary>
        /// 杂音
        /// </summary>
        public System.String zayin { get; set; }

        /// <summary>
        /// 压痛
        /// </summary>
        public System.String yatong { get; set; }

        /// <summary>
        /// 包块
        /// </summary>
        public System.String baokuai { get; set; }

        /// <summary>
        /// 肝大
        /// </summary>
        public System.String ganda { get; set; }

        /// <summary>
        /// 脾大
        /// </summary>
        public System.String pida { get; set; }

        /// <summary>
        /// 移动性浊音
        /// </summary>
        public System.String ydxzy { get; set; }

        /// <summary>
        /// 下肢水肿
        /// </summary>
        public System.String xzsz { get; set; }

        /// <summary>
        /// 足背动脉搏动
        /// </summary>
        public System.String zbdmbd { get; set; }

        /// <summary>
        /// 肛门指诊
        /// </summary>
        public System.String gmzz { get; set; }

        /// <summary>
        /// 乳腺
        /// </summary>
        public System.String ruxian { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String gjtp { get; set; }

        /// <summary>
        /// 脑血管疾病 “，，，”
        /// </summary>
        public System.String nxgjb { get; set; }

        /// <summary>
        /// 肾脏疾病    “，，，，”
        /// </summary>
        public System.String szjb { get; set; }

        /// <summary>
        /// 心脏疾病    “，，，”
        /// </summary>
        public System.String xzjb { get; set; }

        /// <summary>
        /// 血管疾病
        /// </summary>
        public System.String xgjb { get; set; }

        /// <summary>
        /// 眼部疾病
        /// </summary>
        public System.String ybjb { get; set; }

        /// <summary>
        /// 神经系统疾病
        /// </summary>
        public System.String sjxtjb { get; set; }

        /// <summary>
        /// 其它系统疾病
        /// </summary>
        public System.String qtxtjb { get; set; }

        /// <summary>
        /// 既往史
        /// </summary>
        public System.String jws { get; set; }

        /// <summary>
        /// 家庭人员数量
        /// </summary>
        public System.Int32? jtrysl { get; set; }

        /// <summary>
        /// 咳嗽咳痰》=2周
        /// </summary>
        public System.String jhpc { get; set; }

        /// <summary>
        /// 儿童数量
        /// </summary>
        public System.Int32? rtsl { get; set; }

        /// <summary>
        /// 摄盐
        /// </summary>
        public System.Int32? sheyan { get; set; }

        /// <summary>
        /// 酱油
        /// </summary>
        public System.Int32? jiangyou { get; set; }

        /// <summary>
        /// 问诊采集人
        /// </summary>
        public System.String wzfzr { get; set; }

        /// <summary>
        /// 健康评价   体检无异常  有异常----档案审核
        /// </summary>
        public System.String jkpj { get; set; }

        /// <summary>
        /// ‘高血压异常，高血压偏高；；；；’ 健康评价
        /// </summary>
        public System.String jkpjyc { get; set; }

        /// <summary>
        /// 健康指导  “纳入慢病管理,建议复查；”
        /// </summary>
        public System.String jkzd { get; set; }

        /// <summary>
        /// 危险因素控制 ‘,,,’
        /// </summary>
        public System.String wxyskz { get; set; }

        /// <summary>
        /// 危险因素控制其它
        /// </summary>
        public System.String wxyskzqt { get; set; }

        /// <summary>
        /// 危险因素控制体重
        /// </summary>
        public System.String wxyskztz { get; set; }

        /// <summary>
        /// 危险因素控制-接种疫苗名称
        /// </summary>
        public System.String wxyskz_jzym { get; set; }

        /// <summary>
        /// 录入时间
        /// </summary>
        public System.DateTime? lrsj { get; set; }

        /// <summary>
        /// 数据上传时间    沐华  存储时间MySQL采用系统时间 
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 跟车负责人      沐华
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 跟车负责人ID号  沐华
        /// </summary>
        public System.String create_user_id { get; set; }

        /// <summary>
        /// 数据最近更新时间  沐华存储时间MySQL采用系统时间
        /// </summary>
        public System.DateTime? update_time { get; set; }

        /// <summary>
        /// 更新用户名称  沐华
        /// </summary>
        public System.String update_user_name { get; set; }

        /// <summary>
        /// 更新用户ID号  沐华
        /// </summary>
        public System.String update_user_id { get; set; }

        /// <summary>
        /// 妇科 外阴
        /// </summary>
        public System.String fk_waiy { get; set; }

        /// <summary>
        /// 妇科 阴道
        /// </summary>
        public System.String fk_yind { get; set; }

        /// <summary>
        /// 妇科 宫颈
        /// </summary>
        public System.String fk_gongj { get; set; }

        /// <summary>
        /// 妇科 宫体
        /// </summary>
        public System.String fk_gongt { get; set; }

        /// <summary>
        /// 妇科 附件
        /// </summary>
        public System.String fk_fuj { get; set; }

        /// <summary>
        /// 妇科检查医生
        /// </summary>
        public System.String fk_jcys { get; set; }

        /// <summary>
        /// 既往是否得过结核病 2018.3.9
        /// </summary>
        public System.String is_jhb { get; set; }

        /// <summary>
        /// 是否有咯血或血痰 2018.3.9
        /// </summary>
        public System.String is_kaxie { get; set; }

        /// <summary>
        /// 近两周内是否有持续性发热 2018.3.9
        /// </summary>
        public System.String is_fare { get; set; }

        /// <summary>
        /// 妇科   分泌物  **,**,**,**
        /// </summary>
        public System.String fk_fmw { get; set; }

        /// <summary>
        /// 妇科  分泌物检查 **,**,**,**
        /// </summary>
        public System.String fk_fmwjc { get; set; }

        /// <summary>
        /// 妇科检查    临床诊断 结果
        /// </summary>
        public System.String fk_lczd { get; set; }

        /// <summary>
        /// 查体模式：院内：yncj;院外：ywcj
        /// </summary>
        public System.String collectionmodel { get; set; }
    }
}