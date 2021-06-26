
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 家医签约表
    /// </summary>
    public class mh_jyqy
    {
        /// <summary>
        /// 家医签约表
        /// </summary>
        public mh_jyqy()
        {
        }

        /// <summary>
        /// 
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
        /// 姓名
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public System.String lxdh { get; set; }

        /// <summary>
        /// 签约机构号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 签约机构名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 签约日期
        /// </summary>
        public System.String qyrq { get; set; }

        /// <summary>
        /// 签约团队ID
        /// </summary>
        public System.String team_id { get; set; }

        /// <summary>
        /// 签约团队名称
        /// </summary>
        public System.String qyteam { get; set; }

        /// <summary>
        /// 签约医生
        /// </summary>
        public System.String doctorname { get; set; }

        /// <summary>
        /// 家庭医生id
        /// </summary>
        public System.String doctorid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String nurse_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String nurse_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String publichealth_doc_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String publichealth_doc { get; set; }

        /// <summary>
        /// 人员类型
        /// </summary>
        public System.String ry_type { get; set; }

        /// <summary>
        /// 医保签约是否在本机构(是：1；否：0；)
        /// </summary>
        public System.String medicareqy { get; set; }

        /// <summary>
        /// 公卫信息是否在本机构(是：1；否：0；)
        /// </summary>
        public System.String phinfo { get; set; }

        /// <summary>
        /// 签约服务包
        /// </summary>
        public System.String servicepack { get; set; }

        /// <summary>
        /// 到期时间（格式：yyyy-MM-dd）
        /// </summary>
        public System.String mature { get; set; }

        /// <summary>
        /// 是否上传(是：1；否：0；)，汇总库用
        /// </summary>
        public System.String isupload { get; set; }

        /// <summary>
        /// 上传详情信息
        /// </summary>
        public System.String uploadmsg { get; set; }

        /// <summary>
        /// 是否推送（中台）(是：1；否：0；)
        /// </summary>
        public System.String ispush { get; set; }

        /// <summary>
        /// 推送详情
        /// </summary>
        public System.String pushmsg { get; set; }

        /// <summary>
        /// 创建工程师
        /// </summary>
        public System.String create_user_id { get; set; }

        /// <summary>
        /// 工程师姓名
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 数据来源（同步：1；采集：2；）
        /// </summary>
        public System.String datatype { get; set; }

        /// <summary>
        /// 是否删除（是：1；否：0）
        /// </summary>
        public System.String isdelete { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 图片上传结果
        /// </summary>
        public System.String picture_msg { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        public System.String picture_path { get; set; }
    }
}