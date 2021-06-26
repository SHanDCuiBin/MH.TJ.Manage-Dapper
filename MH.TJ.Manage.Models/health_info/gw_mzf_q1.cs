
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 慢病  慢阻肺筛查表
    /// </summary>
    public class gw_mzf_q1
    {
        /// <summary>
        /// 慢病  慢阻肺筛查表
        /// </summary>
        public gw_mzf_q1()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String mh_card { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String tmh { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String sfz { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? age { get; set; }

        /// <summary>
        /// 1.男2.女
        /// </summary>
        public System.Int32? gender { get; set; }

        /// <summary>
        /// 调查时间
        /// </summary>
        public System.DateTime? dcsj { get; set; }

        /// <summary>
        /// 是否用药
        /// </summary>
        public System.String sfyy { get; set; }

        /// <summary>
        /// 医疗单位
        /// </summary>
        public System.String yldw { get; set; }

        /// <summary>
        /// 病史-责任医生
        /// </summary>
        public System.String zrys { get; set; }

        /// <summary>
        /// 曾经被诊断过如下疾病
        /// </summary>
        public System.String zjjb { get; set; }

        /// <summary>
        /// 是否存在慢性呼吸道症状
        /// </summary>
        public System.String sfczzz { get; set; }

        /// <summary>
        /// 危险因素-是否吸烟
        /// </summary>
        public System.String wxys_sfxy { get; set; }

        /// <summary>
        /// 开始吸烟年龄
        /// </summary>
        public System.Int32? wxys_ksxynl { get; set; }

        /// <summary>
        /// 吸烟种类
        /// </summary>
        public System.String wxys_xyzl { get; set; }

        /// <summary>
        /// 吸烟量年
        /// </summary>
        public System.Int32? wxys_xyl_year { get; set; }

        /// <summary>
        /// 吸烟量支/天
        /// </summary>
        public System.Int32? wxys_xyl_day { get; set; }

        /// <summary>
        /// 是否戒烟
        /// </summary>
        public System.String wxys_sfjy { get; set; }

        /// <summary>
        /// 戒烟次数
        /// </summary>
        public System.Int32? wxys_jycs { get; set; }

        /// <summary>
        /// 最长戒烟时间
        /// </summary>
        public System.String wxys_zcjysj { get; set; }

        /// <summary>
        /// 是否接触粉尘和化学毒物工作史
        /// </summary>
        public System.String wxys_jcfchxdw { get; set; }

        /// <summary>
        /// 室内污染
        /// </summary>
        public System.String wxys_snwr { get; set; }

        /// <summary>
        /// 危险因素，家族史
        /// </summary>
        public System.String wxys_jzs { get; set; }

        /// <summary>
        /// 危险因素，家族史,成员
        /// </summary>
        public System.String wxys_jzs_cy { get; set; }

        /// <summary>
        /// 第一秒呼出量
        /// </summary>
        public System.Double? fev1 { get; set; }

        /// <summary>
        /// 第一秒预期肺活量，根据年龄、性别、区域、身高、体重计算
        /// </summary>
        public System.Double? fev1_pre { get; set; }

        /// <summary>
        /// 最大肺活量
        /// </summary>
        public System.Double? fvc { get; set; }

        /// <summary>
        /// 预期最大肺活量
        /// </summary>
        public System.Double? fvc_pre { get; set; }

        /// <summary>
        /// FEV1/FVC
        /// </summary>
        public System.Double? fev1fvc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Double? fef25 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Double? fef75 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Double? fef2575 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Double? pef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Double? pef_pre { get; set; }

        /// <summary>
        /// 标识是否上传到服务器，0代表未上传，1代表上传
        /// </summary>
        public System.Int32? up_flag { get; set; }

        /// <summary>
        /// 标识是否上传到服务器，0代表未上传，1代表上传
        /// </summary>
        public System.String up_msg { get; set; }

        /// <summary>
        /// 肺功能是否达标
        /// </summary>
        public System.String fgn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? update_time { get; set; }

        /// <summary>
        /// 支气管扩张实验参数
        /// </summary>
        public System.Double? sykz_fev1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Double? sykz_fev1_pre { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Double? sykz_fvc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Double? sykz_fvc_pre { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Double? sykz_fev1fvc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Double? sykz_fef25 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Double? sykz_fef75 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Double? sykz_fef2575 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Double? sykz_pef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Double? sykz_pef_pre { get; set; }

        /// <summary>
        /// 肺功能分级(轻度，中度，重度，极重度)
        /// </summary>
        public System.String fgnfj { get; set; }

        /// <summary>
        /// 转诊情况：1.无，2.未转诊，3.已转诊
        /// </summary>
        public System.String zzqk { get; set; }

        /// <summary>
        /// 上级医院确诊为慢阻肺  是/否
        /// </summary>
        public System.String qzmzf { get; set; }

        /// <summary>
        /// 是否到上级医院确诊
        /// </summary>
        public System.String jcqz { get; set; }

        /// <summary>
        /// 是否打过疫苗
        /// </summary>
        public System.String vaccine { get; set; }

        /// <summary>
        /// 身高
        /// </summary>
        public System.String sheng { get; set; }

        /// <summary>
        /// 体重
        /// </summary>
        public System.String tiz { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String lxdh { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String address { get; set; }

        /// <summary>
        /// copd-sq 得分1
        /// </summary>
        public System.Int32? sq_one { get; set; }

        /// <summary>
        /// copd-sq 得分2
        /// </summary>
        public System.Int32? sq_two { get; set; }

        /// <summary>
        /// copd-sq 得分3
        /// </summary>
        public System.Int32? sq_three { get; set; }

        /// <summary>
        /// copd-sq 得分4
        /// </summary>
        public System.Int32? sq_four { get; set; }

        /// <summary>
        /// copd-sq 得分5
        /// </summary>
        public System.Int32? sq_five { get; set; }

        /// <summary>
        /// copd-sq 得分6
        /// </summary>
        public System.Int32? sq_six { get; set; }

        /// <summary>
        /// copd-sq 得分7
        /// </summary>
        public System.Int32? sq_seven { get; set; }

        /// <summary>
        /// copd-sq 总分
        /// </summary>
        public System.Int32? sq_total { get; set; }
    }
}