
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 健康体检  儿童体检信息表
    /// </summary>
    public class mh_et_jktj
    {
        /// <summary>
        /// 健康体检  儿童体检信息表
        /// </summary>
        public mh_et_jktj()
        {
        }

        /// <summary>
        /// 条码号_随访日期 (yyyy-MM-dd) 主键
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 儿童编号
        /// </summary>
        public System.String mh_card { get; set; }

        /// <summary>
        /// 条码号        必填
        /// </summary>
        public System.String tmh { get; set; }

        /// <summary>
        /// 查体日期
        /// </summary>
        public System.DateTime? tjrq { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public System.String sex { get; set; }

        /// <summary>
        /// 儿童查体年龄
        /// </summary>
        public System.Int32? age { get; set; }

        /// <summary>
        /// 体重
        /// </summary>
        public System.Double? tz { get; set; }

        /// <summary>
        /// TZ评价
        /// </summary>
        public System.String tzpj { get; set; }

        /// <summary>
        /// 身高
        /// </summary>
        public System.Double? sg { get; set; }

        /// <summary>
        /// SG评价
        /// </summary>
        public System.String sgpj { get; set; }

        /// <summary>
        /// BMI
        /// </summary>
        public System.Double? bmi { get; set; }

        /// <summary>
        /// ZH评价
        /// </summary>
        public System.String zhpj { get; set; }

        /// <summary>
        /// 发育评估
        /// </summary>
        public System.String fypg { get; set; }

        /// <summary>
        /// 身高测量医生
        /// </summary>
        public System.String sgfzr { get; set; }

        /// <summary>
        /// 视力左
        /// </summary>
        public System.Double? slz { get; set; }

        /// <summary>
        /// 视力右
        /// </summary>
        public System.Double? sly { get; set; }

        /// <summary>
        /// 视力测量医生
        /// </summary>
        public System.String slfzr { get; set; }

        /// <summary>
        /// 牙齿数
        /// </summary>
        public System.Int32? ycnum { get; set; }

        /// <summary>
        /// 龋齿数
        /// </summary>
        public System.Int32? qcnum { get; set; }

        /// <summary>
        /// 口腔医生
        /// </summary>
        public System.String kqys { get; set; }

        /// <summary>
        /// 听力
        /// </summary>
        public System.String tingli { get; set; }

        /// <summary>
        /// 心肺
        /// </summary>
        public System.String xinfei { get; set; }

        /// <summary>
        /// 腹部
        /// </summary>
        public System.String fubu { get; set; }

        /// <summary>
        /// 生殖器官
        /// </summary>
        public System.String szqg { get; set; }

        /// <summary>
        /// 其他异常
        /// </summary>
        public System.String qtyc { get; set; }

        /// <summary>
        /// 患病  0：无  1：有
        /// </summary>
        public System.Int32? huanbing { get; set; }

        /// <summary>
        /// 肺炎
        /// </summary>
        public System.String feiyan { get; set; }

        /// <summary>
        /// 腹泻
        /// </summary>
        public System.String fuxie { get; set; }

        /// <summary>
        /// 外伤
        /// </summary>
        public System.String waishang { get; set; }

        /// <summary>
        /// 患病其他
        /// </summary>
        public System.String hbqt { get; set; }

        /// <summary>
        /// 转诊  0：无  1：有
        /// </summary>
        public System.Int32? zhuanzhen { get; set; }

        /// <summary>
        /// 转诊原因
        /// </summary>
        public System.String zzyy { get; set; }

        /// <summary>
        /// 转诊机构
        /// </summary>
        public System.String zzjg { get; set; }

        /// <summary>
        /// 指导
        /// </summary>
        public System.String zhidao { get; set; }

        /// <summary>
        /// 脉率
        /// </summary>
        public System.Int32? ml { get; set; }

        /// <summary>
        /// 呼吸频率
        /// </summary>
        public System.Int32? hxpl { get; set; }

        /// <summary>
        /// 体温
        /// </summary>
        public System.Double? tiwen { get; set; }

        /// <summary>
        /// 听诊医生
        /// </summary>
        public System.String tzys { get; set; }

        /// <summary>
        /// 下次随访日期
        /// </summary>
        public System.DateTime? xcsfrq { get; set; }

        /// <summary>
        /// 随访医生签名   医院负责人
        /// </summary>
        public System.String sfysqm { get; set; }

        /// <summary>
        /// 是否审核 （医生审核）1 通过 2 不通过 3 医生不审 0未审核
        /// </summary>
        public System.Int32? status { get; set; }

        /// <summary>
        /// 审核医生
        /// </summary>
        public System.String shys { get; set; }

        /// <summary>
        /// 体检 1正常/2异常
        /// </summary>
        public System.String tjyc { get; set; }

        /// <summary>
        /// 体检结论
        /// </summary>
        public System.String tjjl { get; set; }

        /// <summary>
        /// 机构ID号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 数据完整性  1 完整  2 缺项
        /// </summary>
        public System.String wz_flag { get; set; }

        /// <summary>
        /// 数据完整性描述   默认空   缺项填写具体缺项内容
        /// </summary>
        public System.String wz_msg { get; set; }

        /// <summary>
        /// 是否收费  1 收费  2 不收费 0 未知
        /// </summary>
        public System.Int32? is_fufei { get; set; }

        /// <summary>
        /// 上传云端操作员审核数据状态1 通过  2 不通过  0 未审核
        /// </summary>
        public System.Int32? zs_flag { get; set; }

        /// <summary>
        /// 组长审核状态1 通过  2 不通过  0 未审核
        /// </summary>
        public System.Int32? zzsh_flag { get; set; }

        /// <summary>
        /// 组长姓名
        /// </summary>
        public System.String zz_user_name { get; set; }

        /// <summary>
        /// 组长ＩＤ号
        /// </summary>
        public System.String zz_user_id { get; set; }

        /// <summary>
        /// 报告打印次数  
        /// </summary>
        public System.UInt32? dy_count { get; set; }

        /// <summary>
        /// 最近打印时间
        /// </summary>
        public System.DateTime? zjdysj { get; set; }

        /// <summary>
        /// 打印详情记录  存储格式：“次数,打印人,打印时间(yyyyMMddHHmmss);”实例:“1,XX,20160818120504; 2,AA,20170818120504;”
        /// </summary>
        public System.String dy_detail { get; set; }

        /// <summary>
        /// 车辆信息        车牌号
        /// </summary>
        public System.String clxx { get; set; }

        /// <summary>
        /// 数据上传时间    沐华
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
        /// 数据最近更新时间  沐华
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
        /// 更新数据的原因
        /// </summary>
        public System.String update_msg { get; set; }

        /// <summary>
        /// 是否移库空 或者 0 未移库  1 已移库  2 移库失败
        /// </summary>
        public System.Int32? is_yk { get; set; }

        /// <summary>
        /// 移库人姓名
        /// </summary>
        public System.String yk_user_name { get; set; }

        /// <summary>
        /// 移库人ID号
        /// </summary>
        public System.String yk_user_id { get; set; }

        /// <summary>
        /// 移库操作的最新时间
        /// </summary>
        public System.DateTime? yk_time { get; set; }

        /// <summary>
        /// 视力是否通过 0 通过  1 未通过 2不配合
        /// </summary>
        public System.Int32? sl_flag { get; set; }

        /// <summary>
        /// 皮肤     存储内容   0 未见异常 1 皮疹 2 面色暗黄  3黄染     存储方式  “皮疹,黄染” 
        /// </summary>
        public System.String pif { get; set; }

        /// <summary>
        /// 眼睛   存储内容 0 未见异常  1 眼结膜充血  2 眼结膜苍白  存储方式   “眼结膜充血”
        /// </summary>
        public System.String yanj { get; set; }

        /// <summary>
        /// 口腔   存储内容 0 未见异常 1 龋齿 2 牙菌斑 3 扁桃体肥大  4 阻生齿 5 乳牙缺如   存储方式   “阻生齿,乳牙缺如”
        /// </summary>
        public System.String kouq { get; set; }

        /// <summary>
        /// 胸部   存储内容 0 未见异常 1 鸡胸  2 漏斗胸  3乳房结节 存储方式  “鸡胸”
        /// </summary>
        public System.String xiongb { get; set; }

        /// <summary>
        /// 
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
        public System.String jktjwj_msg { get; set; }

        /// <summary>
        /// 血型
        /// </summary>
        public System.String xuex { get; set; }

        /// <summary>
        /// RH
        /// </summary>
        public System.String rh { get; set; }

        /// <summary>
        /// 发育评估
        /// </summary>
        public System.String fayupg { get; set; }

        /// <summary>
        /// 家庭人口数 2018.3.7
        /// </summary>
        public System.Int32? jtrks { get; set; }

        /// <summary>
        /// 转诊_联系人  2018.3.7
        /// </summary>
        public System.String zz_lxr { get; set; }

        /// <summary>
        /// 转诊_联系电话  2018.3.7
        /// </summary>
        public System.String zz_lxdh { get; set; }

        /// <summary>
        /// 转诊_结果 2018.3.7
        /// </summary>
        public System.String zz_jieguo { get; set; }

        /// <summary>
        /// 转诊_是否到位 2018.3.7
        /// </summary>
        public System.String zz_is_daowei { get; set; }

        /// <summary>
        /// 龋齿信息   存储方式   左上;右上;左下;右下
        /// </summary>
        public System.String qcinfo { get; set; }

        /// <summary>
        /// 磨牙龋齿：有无
        /// </summary>
        public System.String moyaqc { get; set; }

        /// <summary>
        /// 龋齿填充：已填充 未填充
        /// </summary>
        public System.String is_qctianchong { get; set; }

        /// <summary>
        /// 恒牙数量 2018.3.22
        /// </summary>
        public System.Int32? hysum { get; set; }

        /// <summary>
        /// 乳牙数量 2018.3.22
        /// </summary>
        public System.Int32? rysum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String dybh { get; set; }

        /// <summary>
        /// 补打标记
        /// </summary>
        public System.String is_bd { get; set; }
    }
}