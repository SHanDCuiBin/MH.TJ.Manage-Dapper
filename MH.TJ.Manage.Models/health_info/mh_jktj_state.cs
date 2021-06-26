
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 健康体检标记表
    /// </summary>
    public class mh_jktj_state
    {
        /// <summary>
        /// 健康体检标记表
        /// </summary>
        public mh_jktj_state()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 数据自己审核状态1 通过  2 不通过  0 未审核
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
        /// null/0 未审核  1审核通过   2 审核不通过 3 医生不审核（医生不审核可以移库）
        /// </summary>
        public System.Int32? status { get; set; }

        /// <summary>
        /// 责任医生---医院审核医生姓名和责任医生
        /// </summary>
        public System.String zrys { get; set; }

        /// <summary>
        /// 打印确认人姓名  --最新确认人
        /// </summary>
        public System.String dy_qr_name { get; set; }

        /// <summary>
        /// 打印确认人ＩＤ号 –最新确认人ID号
        /// </summary>
        public System.String dy_qr_id { get; set; }

        /// <summary>
        /// 打印确认时间  -最新确认打印时间
        /// </summary>
        public System.DateTime? dy_create_time { get; set; }

        /// <summary>
        /// 体检打印次数  -体检报告总共打印的次数
        /// </summary>
        public System.UInt32? dy_count { get; set; }

        /// <summary>
        /// 最近打印时间 –报告最新的打印时间
        /// </summary>
        public System.DateTime? zjdysj { get; set; }

        /// <summary>
        /// 打印详情记录  存储格式："次数,打印人,打印时间(yyyyMMddHHmmss);”实例:“1,XX,20160818120504; 
        /// </summary>
        public System.String dy_detail { get; set; }

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
        /// 是否数据是否修改null 或者 0  可以修改1 可强制修改2 不可强制修改
        /// </summary>
        public System.Int32? is_fg { get; set; }

        /// <summary>
        /// 数据处理审核状态
        /// </summary>
        public System.Int32? sjsh_flag { get; set; }

        /// <summary>
        /// 数据处理审核人 ID
        /// </summary>
        public System.String sjsh_user_id { get; set; }

        /// <summary>
        /// 数据处理审核人名称
        /// </summary>
        public System.String sjsh_user_name { get; set; }

        /// <summary>
        /// 数据处理审核人描述
        /// </summary>
        public System.String sjsh_msg { get; set; }

        /// <summary>
        /// 检验科审核状态   1 审核通过  2 数据异常     空 未审核
        /// </summary>
        public System.Int32? jysh_flag { get; set; }

        /// <summary>
        /// 检验科审核结果
        /// </summary>
        public System.String jysh_msg { get; set; }

        /// <summary>
        /// 检验科审核人
        /// </summary>
        public System.String jysh_user { get; set; }

        /// <summary>
        /// 检验科审核日期
        /// </summary>
        public System.DateTime? jysh_date { get; set; }

        /// <summary>
        /// 医生审核时间
        /// </summary>
        public System.DateTime? yssh_date { get; set; }

        /// <summary>
        /// 危机信息说明
        /// </summary>
        public System.String jktjwj_msg { get; set; }

        /// <summary>
        /// 危机信息
        /// </summary>
        public System.String jktjwj_info { get; set; }

        /// <summary>
        /// 打印编号
        /// </summary>
        public System.String dy_num { get; set; }

        /// <summary>
        /// 症状采集人
        /// </summary>
        public System.String zzfzr { get; set; }

        /// <summary>
        /// 一般状况负责人
        /// </summary>
        public System.String ybjzkzr { get; set; }

        /// <summary>
        /// 生活方式负责人
        /// </summary>
        public System.String shfsfzr { get; set; }

        /// <summary>
        /// 脏器功能负责人
        /// </summary>
        public System.String zqgnfzr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String ctfzr { get; set; }

        /// <summary>
        /// 辅助检查  血常规  尿常规  空腹血糖 负责人
        /// </summary>
        public System.String fzjcxnfzr { get; set; }

        /// <summary>
        /// 辅助检查  生化检查负责人
        /// </summary>
        public System.String fzjcshfzr { get; set; }

        /// <summary>
        /// 心电图医生签名
        /// </summary>
        public System.String xdtfzr { get; set; }

        /// <summary>
        /// x光医生签名
        /// </summary>
        public System.String xrayfzr { get; set; }

        /// <summary>
        /// b超医生签名
        /// </summary>
        public System.String bcfzr { get; set; }

        /// <summary>
        /// 现存主要问题负责人
        /// </summary>
        public System.String xczywtfzr { get; set; }

        /// <summary>
        /// 住院史负责人
        /// </summary>
        public System.String zysfzr { get; set; }

        /// <summary>
        /// 用药情况  负责人
        /// </summary>
        public System.String yyqkfzr { get; set; }

        /// <summary>
        /// 健康评价负责人
        /// </summary>
        public System.String jkpjfzr { get; set; }

        /// <summary>
        /// 健康指导与危险因素控制负责人
        /// </summary>
        public System.String jkzdfzr { get; set; }

        /// <summary>
        /// 是否补打，0或null 不补打，1 补打
        /// </summary>
        public System.String is_bd { get; set; }

        /// <summary>
        /// 审核软件版本号
        /// </summary>
        public System.String version { get; set; }

        /// <summary>
        /// null 未校验  0 数据完整  1 数据不完整 
        /// </summary>
        public System.Int32? is_wz { get; set; }

        /// <summary>
        /// 数据缺项的具体描述信息
        /// </summary>
        public System.String wz_msg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String clxx { get; set; }

        /// <summary>
        /// 更新数据的原因
        /// </summary>
        public System.String update_msg { get; set; }

        /// <summary>
        /// 打印需要纸张数
        /// </summary>
        public System.Int32? dy_page_count { get; set; }

        /// <summary>
        /// 检验数据获取状态 0自己公司数据，1检验第三方拉取成功  2检验第三方拉取失败
        /// </summary>
        public System.String jyjg_state { get; set; }

        /// <summary>
        /// 血球检验者
        /// </summary>
        public System.String xq_jyz { get; set; }

        /// <summary>
        /// 血球审核者
        /// </summary>
        public System.String xq_shz { get; set; }

        /// <summary>
        /// 生化检验者
        /// </summary>
        public System.String sh_jyz { get; set; }

        /// <summary>
        /// 生化审核者
        /// </summary>
        public System.String sh_shz { get; set; }

        /// <summary>
        /// 尿常规检验者
        /// </summary>
        public System.String ncg_jyz { get; set; }

        /// <summary>
        /// 尿常规审核者
        /// </summary>
        public System.String ncg_shz { get; set; }
    }
}