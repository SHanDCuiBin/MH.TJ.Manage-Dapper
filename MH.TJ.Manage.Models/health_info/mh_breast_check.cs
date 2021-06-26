
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 
    /// </summary>
    public class mh_breast_check
    {
        /// <summary>
        /// 
        /// </summary>
        public mh_breast_check()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 对应的健康体检表id
        /// </summary>
        public System.String jktj_id { get; set; }

        /// <summary>
        /// 个案编号
        /// </summary>
        public System.String case_id { get; set; }

        /// <summary>
        /// 登记日期
        /// </summary>
        public System.DateTime? regist_date { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 性别 1为男 2为女 0为未知
        /// </summary>
        public System.Int32? sex { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public System.Int32? age { get; set; }

        /// <summary>
        /// 身份证
        /// </summary>
        public System.String id_card { get; set; }

        /// <summary>
        /// 乡镇
        /// </summary>
        public System.String town { get; set; }

        /// <summary>
        /// 身份证地址
        /// </summary>
        public System.String id_card_addess { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public System.String phone { get; set; }

        /// <summary>
        /// 滴虫性阴道炎
        /// </summary>
        public System.Int32? trichomonal_vaginitis { get; set; }

        /// <summary>
        /// 外阴阴道假丝酵母菌病
        /// </summary>
        public System.Int32? vulvovaginal_candidiasis { get; set; }

        /// <summary>
        /// 细菌性阴道病
        /// </summary>
        public System.Int32? bacterial_vaginosis { get; set; }

        /// <summary>
        /// 外生殖器尖锐湿疣
        /// </summary>
        public System.Int32? condyloma { get; set; }

        /// <summary>
        /// 宫颈炎
        /// </summary>
        public System.Int32? cervicitis { get; set; }

        /// <summary>
        /// 宫颈息肉
        /// </summary>
        public System.Int32? cervical_polyp { get; set; }

        /// <summary>
        /// 子宫肌瘤
        /// </summary>
        public System.Int32? hysteromyoma { get; set; }

        /// <summary>
        /// 其他良性疾病
        /// </summary>
        public System.Int32? other_benign_diseases { get; set; }

        /// <summary>
        /// 乳腺彩色超声
        /// </summary>
        public System.String breast_color_ultrasound { get; set; }

        /// <summary>
        /// 宫颈癌细胞学检查（初筛人数） 巴氏分级
        /// </summary>
        public System.String papanicolaou_classification { get; set; }

        /// <summary>
        /// 未见异常
        /// </summary>
        public System.Int32? is_normal { get; set; }

        /// <summary>
        /// 不典型鳞状上皮细胞(ASC-US)
        /// </summary>
        public System.String ASC_US { get; set; }

        /// <summary>
        /// 不除外高度鳞状上皮内病变(ASC-H)
        /// </summary>
        public System.String ASC_H { get; set; }

        /// <summary>
        /// 低度鳞状上皮内病变(LSIL)
        /// </summary>
        public System.String LSIL { get; set; }

        /// <summary>
        /// 高度鳞状上皮内病变(HSIL)
        /// </summary>
        public System.String HSIL { get; set; }

        /// <summary>
        /// 鳞状细胞癌SCC
        /// </summary>
        public System.String SCC { get; set; }

        /// <summary>
        /// 不典型腺上皮细胞AGC
        /// </summary>
        public System.String AGC { get; set; }

        /// <summary>
        /// 不典型颈管腺细胞倾向瘤变
        /// </summary>
        public System.String AIS { get; set; }

        /// <summary>
        /// 颈管原位癌
        /// </summary>
        public System.String adenocarcinoma_insitu { get; set; }

        /// <summary>
        /// 腺癌
        /// </summary>
        public System.String adenocarcinoma { get; set; }

        /// <summary>
        /// 醋酸染色
        /// </summary>
        public System.String acetic_acid_dyeing { get; set; }

        /// <summary>
        /// 碘染色
        /// </summary>
        public System.String iodine_staining { get; set; }

        /// <summary>
        /// 阴道镜检查 诊断结果
        /// </summary>
        public System.String colposcopy { get; set; }

        /// <summary>
        /// HPV 检查结果 阴性/阳性
        /// </summary>
        public System.Int32? HPV { get; set; }

        /// <summary>
        /// 报告单返回结果
        /// </summary>
        public System.String report_result { get; set; }
    }
}