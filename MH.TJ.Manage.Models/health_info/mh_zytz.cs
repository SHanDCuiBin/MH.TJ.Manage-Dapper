
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 中医体质采集信息表--记录中医体质采集的数据信息
    /// </summary>
    public class mh_zytz
    {
        /// <summary>
        /// 中医体质采集信息表--记录中医体质采集的数据信息
        /// </summary>
        public mh_zytz()
        {
        }

        /// <summary>
        /// 条码号_填表日期 (yyyyMMdd) 主键
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 沐华对应的档案编号机构号_年份_条码
        /// </summary>
        public System.String mh_card { get; set; }

        /// <summary>
        /// 条码号 对应体检的条码号
        /// </summary>
        public System.String tmh { get; set; }

        /// <summary>
        /// 查体年份
        /// </summary>
        public System.Int32? year { get; set; }

        /// <summary>
        /// null/0 默认收费  1不收费
        /// </summary>
        public System.Int32? is_fufei { get; set; }

        /// <summary>
        /// 机构编号---体检所属机构ID号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 机构名称---体检所属机构名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 现场照URL 存储示例 :/xx/xx/xx/…/xx.jpg
        /// </summary>
        public System.String xcz_url { get; set; }

        /// <summary>
        /// 问题1
        /// </summary>
        public System.Int32? q1df { get; set; }

        /// <summary>
        /// 问题2
        /// </summary>
        public System.Int32? q2df { get; set; }

        /// <summary>
        /// 问题3
        /// </summary>
        public System.Int32? q3df { get; set; }

        /// <summary>
        /// 问题4
        /// </summary>
        public System.Int32? q4df { get; set; }

        /// <summary>
        /// 问题5
        /// </summary>
        public System.Int32? q5df { get; set; }

        /// <summary>
        /// 问题6
        /// </summary>
        public System.Int32? q6df { get; set; }

        /// <summary>
        /// 问题7
        /// </summary>
        public System.Int32? q7df { get; set; }

        /// <summary>
        /// 问题8
        /// </summary>
        public System.Int32? q8df { get; set; }

        /// <summary>
        /// 问题9
        /// </summary>
        public System.Int32? q9df { get; set; }

        /// <summary>
        /// 问题10
        /// </summary>
        public System.Int32? q10df { get; set; }

        /// <summary>
        /// 问题11
        /// </summary>
        public System.Int32? q11df { get; set; }

        /// <summary>
        /// 问题12
        /// </summary>
        public System.Int32? q12df { get; set; }

        /// <summary>
        /// 问题13
        /// </summary>
        public System.Int32? q13df { get; set; }

        /// <summary>
        /// 问题14
        /// </summary>
        public System.Int32? q14df { get; set; }

        /// <summary>
        /// 问题15
        /// </summary>
        public System.Int32? q15df { get; set; }

        /// <summary>
        /// 问题16
        /// </summary>
        public System.Int32? q16df { get; set; }

        /// <summary>
        /// 问题17
        /// </summary>
        public System.Int32? q17df { get; set; }

        /// <summary>
        /// 问题18
        /// </summary>
        public System.Int32? q18df { get; set; }

        /// <summary>
        /// 问题19
        /// </summary>
        public System.Int32? q19df { get; set; }

        /// <summary>
        /// 问题20
        /// </summary>
        public System.Int32? q20df { get; set; }

        /// <summary>
        /// 问题21
        /// </summary>
        public System.Int32? q21df { get; set; }

        /// <summary>
        /// 问题22
        /// </summary>
        public System.Int32? q22df { get; set; }

        /// <summary>
        /// 问题23
        /// </summary>
        public System.Int32? q23df { get; set; }

        /// <summary>
        /// 问题24
        /// </summary>
        public System.Int32? q24df { get; set; }

        /// <summary>
        /// 问题25
        /// </summary>
        public System.Int32? q25df { get; set; }

        /// <summary>
        /// 问题26
        /// </summary>
        public System.Int32? q26df { get; set; }

        /// <summary>
        /// 问题27
        /// </summary>
        public System.Int32? q27df { get; set; }

        /// <summary>
        /// 问题28
        /// </summary>
        public System.Int32? q28df { get; set; }

        /// <summary>
        /// 问题29
        /// </summary>
        public System.Int32? q29df { get; set; }

        /// <summary>
        /// 问题30
        /// </summary>
        public System.Int32? q30df { get; set; }

        /// <summary>
        /// 问题31
        /// </summary>
        public System.Int32? q31df { get; set; }

        /// <summary>
        /// 问题32
        /// </summary>
        public System.Int32? q32df { get; set; }

        /// <summary>
        /// 问题33
        /// </summary>
        public System.Int32? q33df { get; set; }

        /// <summary>
        /// 气虚质总得分
        /// </summary>
        public System.Int32? qxzdf { get; set; }

        /// <summary>
        /// 气虚质结论
        /// </summary>
        public System.String qxzjl { get; set; }

        /// <summary>
        /// 气虚质指导
        /// </summary>
        public System.String qxzzd { get; set; }

        /// <summary>
        /// 阳虚质总得分
        /// </summary>
        public System.Int32? yxzdf { get; set; }

        /// <summary>
        /// 阳虚质结论
        /// </summary>
        public System.String yxzjl { get; set; }

        /// <summary>
        /// 阳虚质指导
        /// </summary>
        public System.String yxzzd { get; set; }

        /// <summary>
        /// 阴虚质总得分
        /// </summary>
        public System.Int32? yinxzdf { get; set; }

        /// <summary>
        /// 阴虚质结论
        /// </summary>
        public System.String yinxzjl { get; set; }

        /// <summary>
        /// 阴虚质指导
        /// </summary>
        public System.String yinxzzd { get; set; }

        /// <summary>
        /// 痰湿质总得分
        /// </summary>
        public System.Int32? trzdf { get; set; }

        /// <summary>
        /// 痰湿质结论
        /// </summary>
        public System.String trzjl { get; set; }

        /// <summary>
        /// 痰湿质指导
        /// </summary>
        public System.String trzzd { get; set; }

        /// <summary>
        /// 湿热质总得分
        /// </summary>
        public System.Int32? srzdf { get; set; }

        /// <summary>
        /// 湿热质结论
        /// </summary>
        public System.String srzjl { get; set; }

        /// <summary>
        /// 湿热质指导
        /// </summary>
        public System.String srzzd { get; set; }

        /// <summary>
        /// 血瘀质总得分
        /// </summary>
        public System.Int32? xyzdf { get; set; }

        /// <summary>
        /// 血瘀质结论
        /// </summary>
        public System.String xyzjl { get; set; }

        /// <summary>
        /// 血瘀质指导
        /// </summary>
        public System.String xyzzd { get; set; }

        /// <summary>
        /// 气郁质总得分
        /// </summary>
        public System.Int32? qyzdf { get; set; }

        /// <summary>
        /// 气郁质结论
        /// </summary>
        public System.String qyzjl { get; set; }

        /// <summary>
        /// 气郁质指导
        /// </summary>
        public System.String qyzzd { get; set; }

        /// <summary>
        /// 特禀质总得分
        /// </summary>
        public System.Int32? tbzdf { get; set; }

        /// <summary>
        /// 特禀质结论
        /// </summary>
        public System.String tbzjl { get; set; }

        /// <summary>
        /// 特禀质指导
        /// </summary>
        public System.String tbzzd { get; set; }

        /// <summary>
        /// 平和质总得分
        /// </summary>
        public System.Int32? phzdf { get; set; }

        /// <summary>
        /// 平和质结论
        /// </summary>
        public System.String phzjl { get; set; }

        /// <summary>
        /// 平和质指导
        /// </summary>
        public System.String phzzd { get; set; }

        /// <summary>
        /// 随访医生签名
        /// </summary>
        public System.String sfysqm { get; set; }

        /// <summary>
        /// 填表日期
        /// </summary>
        public System.DateTime? tbrq { get; set; }

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
        /// 档案打印状态null / 0 不可打印  1 可以打印 2已打印
        /// </summary>
        public System.Int32? da_dy_flag { get; set; }

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
        public System.Int32? dy_count { get; set; }

        /// <summary>
        /// 最近打印时间 –报告最新的打印时间
        /// </summary>
        public System.DateTime? zjdysj { get; set; }

        /// <summary>
        /// 打印详情记录  存储格式：“次数,打印人,打印时间(yyyyMMddHHmmss);”实例:“1,XX,20160818120504; 2,AA,20170818120504;”1 可强制修改2 不可强制修改
        /// </summary>
        public System.String dy_detail { get; set; }

        /// <summary>
        /// 是否转移到档案库  0  未转移   1 已转移
        /// </summary>
        public System.UInt32? is_zy { get; set; }

        /// <summary>
        /// 问题9旧数据
        /// </summary>
        public System.Int32? q9df_old { get; set; }

        /// <summary>
        /// 问题28旧数据
        /// </summary>
        public System.Int32? q28df_old { get; set; }
    }
}