
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 学生健康体检信息表
    /// </summary>
    public class mh_xs_jktj
    {
        /// <summary>
        /// 学生健康体检信息表
        /// </summary>
        public mh_xs_jktj()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 学生编号
        /// </summary>
        public System.String mh_card { get; set; }

        /// <summary>
        /// 条码号
        /// </summary>
        public System.String tmh { get; set; }

        /// <summary>
        /// 体检年度
        /// </summary>
        public System.Int32? year { get; set; }

        /// <summary>
        /// 体检日期
        /// </summary>
        public System.DateTime? tjrq { get; set; }

        /// <summary>
        /// 身高
        /// </summary>
        public System.Double? sg { get; set; }

        /// <summary>
        /// 体重
        /// </summary>
        public System.Double? tz { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Double? bmi { get; set; }

        /// <summary>
        /// 胸围
        /// </summary>
        public System.Double? xw { get; set; }

        /// <summary>
        /// 肺活量
        /// </summary>
        public System.Int32? fhl { get; set; }

        /// <summary>
        /// 血压左
        /// </summary>
        public System.Int32? xyz { get; set; }

        /// <summary>
        /// 血压右
        /// </summary>
        public System.Int32? xyy { get; set; }

        /// <summary>
        /// 心率
        /// </summary>
        public System.Int32? xl { get; set; }

        /// <summary>
        /// 发育状态
        /// </summary>
        public System.String fyzt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String xtrmark { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String xtys { get; set; }

        /// <summary>
        /// 心（0正常 1,心音异常，2心率异常，3先天性心脏病，4需进一步检查）
        /// </summary>
        public System.String xin { get; set; }

        /// <summary>
        /// 肺 （0正常，1呼吸音粗，2干，湿罗音，3需进一步检查）
        /// </summary>
        public System.String fei { get; set; }

        /// <summary>
        /// 肝（0未触及，1需进一步检查）
        /// </summary>
        public System.String gan { get; set; }

        /// <summary>
        /// 胆（无用）
        /// </summary>
        public System.String dan { get; set; }

        /// <summary>
        /// 脾（0未触及异常，1需进一步检查）
        /// </summary>
        public System.String pi { get; set; }

        /// <summary>
        /// 内科医生
        /// </summary>
        public System.String nkys { get; set; }

        /// <summary>
        /// 裸眼视力左
        /// </summary>
        public System.String lyz { get; set; }

        /// <summary>
        /// 裸眼视力右
        /// </summary>
        public System.String lyy { get; set; }

        /// <summary>
        /// 矫正视力左
        /// </summary>
        public System.String jzz { get; set; }

        /// <summary>
        /// 矫正视力右
        /// </summary>
        public System.String jzy { get; set; }

        /// <summary>
        /// 沙眼（无用）
        /// </summary>
        public System.String sy { get; set; }

        /// <summary>
        /// 结膜炎（0无，1有）
        /// </summary>
        public System.String jmy { get; set; }

        /// <summary>
        /// 色觉（0正常，1色盲，2色弱）
        /// </summary>
        public System.String sj { get; set; }

        /// <summary>
        /// 眼位眼球运动
        /// </summary>
        public System.String ywyqyd { get; set; }

        /// <summary>
        /// 其他眼病（0无，1斜视，2弱视，3眼球震颤，4角膜疾病，5倒睫，6睑内翻，7需进一步检查）
        /// </summary>
        public System.String yanb { get; set; }

        /// <summary>
        /// 眼科医生
        /// </summary>
        public System.String ykys { get; set; }

        /// <summary>
        /// 头部（0正常，1异常，2需进一步检查）
        /// </summary>
        public System.String tb { get; set; }

        /// <summary>
        /// 颈部（0正常，1斜颈，2需进一步检查）
        /// </summary>
        public System.String jb { get; set; }

        /// <summary>
        /// 胸部（0正常，1鸡胸，2漏斗胸，3扁平胸，4胸廓不对称，5需进一步检查）
        /// </summary>
        public System.String xb { get; set; }

        /// <summary>
        /// 脊柱（0正常，1胸弯型，2双主弯型，3腰弯型，4胸腰段弯型，5需进一步检查）
        /// </summary>
        public System.String jz { get; set; }

        /// <summary>
        /// 四肢（0正常，1膝内翻，2膝外翻，3肘外翻，4肘内翻，5关节畸形，6关节活动受限，7步态异常，8需进一步检查）
        /// </summary>
        public System.String sz { get; set; }

        /// <summary>
        /// 皮肤（0正常，1湿疹，2白癜风，3血管瘤，4需进一步检查）
        /// </summary>
        public System.String pf { get; set; }

        /// <summary>
        /// 淋巴结（0正常，1颈部肿大，2腋下肿大，3其他部位肿大，4需进一步检查）
        /// </summary>
        public System.String lbj { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String wkremark { get; set; }

        /// <summary>
        /// 外科医生
        /// </summary>
        public System.String wkys { get; set; }

        /// <summary>
        /// 牙齿
        /// </summary>
        public System.String yc { get; set; }

        /// <summary>
        /// 乳龋患
        /// </summary>
        public System.Int32? ryd { get; set; }

        /// <summary>
        /// 乳龋失
        /// </summary>
        public System.Int32? rym { get; set; }

        /// <summary>
        /// 乳龋补
        /// </summary>
        public System.Int32? ryf { get; set; }

        /// <summary>
        /// 恒龋患
        /// </summary>
        public System.Int32? hyd { get; set; }

        /// <summary>
        /// 恒龋失
        /// </summary>
        public System.Int32? hym { get; set; }

        /// <summary>
        /// 恒龋补
        /// </summary>
        public System.Int32? hyf { get; set; }

        /// <summary>
        /// 龋齿
        /// </summary>
        public System.String qc { get; set; }

        /// <summary>
        /// 牙周（0=正常；1=牙结石；2=牙龈炎；3=牙周炎）
        /// </summary>
        public System.String yz { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String kqremark { get; set; }

        /// <summary>
        /// 口腔医生
        /// </summary>
        public System.String sqys { get; set; }

        /// <summary>
        /// 耳（0=正常；1=耵聍；2=附耳炎；3=中耳炎；4=耳前瘘管；5=需进一步检查）
        /// </summary>
        public System.String er { get; set; }

        /// <summary>
        /// 鼻（0=正常；1=鼻炎；2=鼻窦炎；3=鼻中隔偏曲；4=鼻息肉；5=需进一步检查）
        /// </summary>
        public System.String bi { get; set; }

        /// <summary>
        /// 扁桃体（0=正常；1=Ⅰ度肿大； 2=Ⅱ度肿大；3=Ⅲ度肿大；4=扁桃体切除术后；5=需进一步检查）
        /// </summary>
        public System.String btt { get; set; }

        /// <summary>
        /// 耳鼻喉医生
        /// </summary>
        public System.String ebhys { get; set; }

        /// <summary>
        /// 结核接触者（周围是否有结核患者，）
        /// </summary>
        public System.String jh_jcz { get; set; }

        /// <summary>
        /// 结核接触者关系
        /// </summary>
        public System.String jh_jcz_gx { get; set; }

        /// <summary>
        /// 结核可疑症状（0=无；1=有，做结核菌素试验）
        /// </summary>
        public System.String jh_kyzz { get; set; }

        /// <summary>
        /// 结核菌素（0=阴性；1=阳性；2=强阳性，需进一步检查）
        /// </summary>
        public System.String jhjs { get; set; }

        /// <summary>
        /// 胆红素
        /// </summary>
        public System.String dhs { get; set; }

        /// <summary>
        /// 谷丙转氨酶
        /// </summary>
        public System.String gbzam { get; set; }

        /// <summary>
        /// 血型
        /// </summary>
        public System.String xx { get; set; }

        /// <summary>
        /// 血红蛋白
        /// </summary>
        public System.String xhdb { get; set; }

        /// <summary>
        /// 红细胞
        /// </summary>
        public System.String hxb { get; set; }

        /// <summary>
        /// 白细胞
        /// </summary>
        public System.String bxb { get; set; }

        /// <summary>
        /// 血小板
        /// </summary>
        public System.String xxb { get; set; }

        /// <summary>
        /// 血液医生
        /// </summary>
        public System.String XYys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String yx { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String yxremark { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String yxys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String yanbing { get; set; }

        /// <summary>
        /// 是否移库
        /// </summary>
        public System.UInt32? yk_flag { get; set; }

        /// <summary>
        /// 移库时间
        /// </summary>
        public System.DateTime? yk_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String create_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String update_user_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String update_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String dy_fkb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String dy_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String dy_user { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? zs_flag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? zzsh_flag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String zz_user_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String zz_user_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String create_user_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String update_user_id { get; set; }

        /// <summary>
        /// 甲状腺（0正常，1肿大，2需进一步检查）
        /// </summary>
        public System.String jzx { get; set; }

        /// <summary>
        /// 窝沟封闭
        /// </summary>
        public System.String wgfb { get; set; }

        /// <summary>
        /// 窝沟封闭颗数(0=无；1=1颗封闭完好；2=2颗封闭完好)
        /// </summary>
        public System.Int32? fbks { get; set; }

        /// <summary>
        /// 封闭剂脱落（0=无；1=1颗封闭脱落；2=2颗封闭脱落；
        /// </summary>
        public System.Int32? fbjtlks { get; set; }

        /// <summary>
        /// 滴涂氟化物（0=是；1=滴涂1次/年；2=滴涂2次/年；3=未滴涂）
        /// </summary>
        public System.String dtfhw { get; set; }

        /// <summary>
        /// 牙外伤（0无，1有）
        /// </summary>
        public System.String yws { get; set; }

        /// <summary>
        /// 牙列不齐(0否，1是）
        /// </summary>
        public System.String ylbq { get; set; }

        /// <summary>
        /// 恒牙萌出(0未萌 1萌出)
        /// </summary>
        public System.String hymc { get; set; }

        /// <summary>
        /// 恒牙萌出情况
        /// </summary>
        public System.String hymcqk { get; set; }

        /// <summary>
        /// 结核抗体检查（0=阴性；1=阳性，需进一步检查）
        /// </summary>
        public System.String jhkt { get; set; }

        /// <summary>
        /// 尿酮体     ----尿检
        /// </summary>
        public System.String ntt { get; set; }

        /// <summary>
        /// 尿潜血
        /// </summary>
        public System.String nqx { get; set; }

        /// <summary>
        /// 尿蛋白
        /// </summary>
        public System.String ndb { get; set; }

        /// <summary>
        /// 尿糖
        /// </summary>
        public System.String nt { get; set; }

        /// <summary>
        /// 尿白细胞
        /// </summary>
        public System.String leu { get; set; }

        /// <summary>
        /// 亚硝酸盐
        /// </summary>
        public System.String nit { get; set; }

        /// <summary>
        /// 尿胆原
        /// </summary>
        public System.String uro { get; set; }

        /// <summary>
        /// 尿酸碱值
        /// </summary>
        public System.String ph { get; set; }

        /// <summary>
        /// 尿比重
        /// </summary>
        public System.String nbz { get; set; }

        /// <summary>
        /// 尿胆红素
        /// </summary>
        public System.String bil { get; set; }

        /// <summary>
        /// 抗坏血酸
        /// </summary>
        public System.String khxs { get; set; }

        /// <summary>
        /// 学校
        /// </summary>
        public System.String xuex { get; set; }

        /// <summary>
        /// 班级
        /// </summary>
        public System.String banj { get; set; }

        /// <summary>
        /// 腰围
        /// </summary>
        public System.Double? yaowei { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String jktjwj_msg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String dy_num { get; set; }

        /// <summary>
        /// 主检医生
        /// </summary>
        public System.String zjys { get; set; }

        /// <summary>
        /// 打印详情
        /// </summary>
        public System.String dy_detail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String is_bd { get; set; }

        /// <summary>
        /// 是否收费  1 收费  2 不收费 0 未知
        /// </summary>
        public System.Int32? is_fufei { get; set; }

        /// <summary>
        /// 0未审核，1已审核通过，2审核不通过
        /// </summary>
        public System.Int32? sjsh_flag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String sjsh_user_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String sjsh_user_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String sjsh_msg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? sjsh_date { get; set; }
    }
}