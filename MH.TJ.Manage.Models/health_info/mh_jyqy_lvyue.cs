
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 家医签约-履约
    /// </summary>
    public class mh_jyqy_lvyue
    {
        /// <summary>
        /// 家医签约-履约
        /// </summary>
        public mh_jyqy_lvyue()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 条码号
        /// </summary>
        public System.String tmh { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public System.String id_card { get; set; }

        /// <summary>
        /// 对应家医签约数据id
        /// </summary>
        public System.String jyqy_id { get; set; }

        /// <summary>
        /// 对应健康体检数据id
        /// </summary>
        public System.String jktj_id { get; set; }

        /// <summary>
        /// 履约日期
        /// </summary>
        public System.DateTime? lvyue_date { get; set; }

        /// <summary>
        /// 履约项目-基本公共卫生服务项目
        /// </summary>
        public System.Int32? item_jibengongwei { get; set; }

        /// <summary>
        /// 履约项目-长处方
        /// </summary>
        public System.Int32? item_changchuafang { get; set; }

        /// <summary>
        /// 履约项目-延伸处方
        /// </summary>
        public System.Int32? item_yanshenchufang { get; set; }

        /// <summary>
        /// 履约项目-专家门诊预约
        /// </summary>
        public System.Int32? item_zhuanjiamenzhenyuyue { get; set; }

        /// <summary>
        /// 履约项目-诊疗费免费次数
        /// </summary>
        public System.Int32? item_zhenliaofeimianfei { get; set; }

        /// <summary>
        /// 履约项目-就医途径指导
        /// </summary>
        public System.Int32? item_jiuyitujingzhidao { get; set; }

        /// <summary>
        /// 履约项目-疾病健康教育
        /// </summary>
        public System.Int32? item_jibingjiankangjiaoyu { get; set; }

        /// <summary>
        /// 履约项目-健康体检及评估
        /// </summary>
        public System.Int32? item_jiankangtijian { get; set; }

        /// <summary>
        /// 履约项目-中医体质
        /// </summary>
        public System.Int32? item_zhongyitizhi { get; set; }

        /// <summary>
        /// 履约项目-中医养生
        /// </summary>
        public System.Int32? item_zhongyiyangsheng { get; set; }

        /// <summary>
        /// 履约项目-健康咨询
        /// </summary>
        public System.Int32? item_jiankangzixun { get; set; }

        /// <summary>
        /// 履约状态 1为履约成功 2为无此人信息 3为无此人签约包信息 4为其他原因
        /// </summary>
        public System.String lvyue_status { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 创建人账号
        /// </summary>
        public System.String create_user_id { get; set; }

        /// <summary>
        /// 创建人姓名
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 更新日期
        /// </summary>
        public System.DateTime? update_time { get; set; }

        /// <summary>
        /// 更新人账号
        /// </summary>
        public System.String update_user_id { get; set; }

        /// <summary>
        /// 更新人姓名
        /// </summary>
        public System.String update_user_name { get; set; }
    }
}