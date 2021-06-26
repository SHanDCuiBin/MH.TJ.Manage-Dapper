

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 报告档案打印   医院需求信息表（医生，签字等信息）
    /// </summary>
    public class dy_xqinfo
    {
        /// <summary>
        /// 报告档案打印   医院需求信息表（医生，签字等信息）
        /// </summary>
        public dy_xqinfo()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 打印类型  1 老年人  2 儿童 3 成年人  4 学生 5 教师 6 贫困人口 7 其他类型
        /// </summary>
        public System.Int32 dy_type { get; set; }

        /// <summary>
        /// 联系电话是否显示   1 显示 2不显示  默认显示
        /// </summary>
        public System.String is_lxdh { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public System.String lxr { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public System.String phone { get; set; }

        /// <summary>
        /// 咨询QQ 号
        /// </summary>
        public System.String zx_qq { get; set; }

        /// <summary>
        /// 邮政编码
        /// </summary>
        public System.String yzbh { get; set; }

        /// <summary>
        /// 报告，档案上的卫生院名称
        /// </summary>
        public System.String qt_text { get; set; }

        /// <summary>
        /// 血球检验者
        /// </summary>
        public System.String xq_jyz { get; set; }

        /// <summary>
        /// 血球检验者图片
        /// </summary>
        public System.String xq_jyz_img { get; set; }

        /// <summary>
        /// 血球审核者
        /// </summary>
        public System.String xq_shz { get; set; }

        /// <summary>
        /// 血球审核者签名
        /// </summary>
        public System.String xq_shz_img { get; set; }

        /// <summary>
        /// 生化检验者
        /// </summary>
        public System.String sh_jyz { get; set; }

        /// <summary>
        /// 生化检验者签名
        /// </summary>
        public System.String sh_jyz_img { get; set; }

        /// <summary>
        /// 生化审核者
        /// </summary>
        public System.String sh_shz { get; set; }

        /// <summary>
        /// 生化审核者签名
        /// </summary>
        public System.String sh_shz_img { get; set; }

        /// <summary>
        /// 尿检 检验者
        /// </summary>
        public System.String nj_jyz { get; set; }

        /// <summary>
        /// 尿检 检验者签名
        /// </summary>
        public System.String nj_jyz_img { get; set; }

        /// <summary>
        /// 尿检  审核者
        /// </summary>
        public System.String nj_shz { get; set; }

        /// <summary>
        /// 尿检  审核者签名
        /// </summary>
        public System.String nj_shz_img { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        public System.String mb_name { get; set; }

        /// <summary>
        /// 档案模板
        /// </summary>
        public System.String da_mbname { get; set; }

        /// <summary>
        /// 心电图医生
        /// </summary>
        public System.String xdt_doctor { get; set; }

        /// <summary>
        /// 心电图医生签名
        /// </summary>
        public System.String xdt_doctor_img { get; set; }

        /// <summary>
        /// B超医生
        /// </summary>
        public System.String bc_doctor { get; set; }

        /// <summary>
        /// B超医生签名
        /// </summary>
        public System.String bc_doctor_img { get; set; }

        /// <summary>
        /// 中医体质医生
        /// </summary>
        public System.String zytz_doctor { get; set; }

        /// <summary>
        /// 中医体质医生签名
        /// </summary>
        public System.String zytz_doctor_img { get; set; }

        /// <summary>
        /// 二维码
        /// </summary>
        public System.String qr_code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String create_user_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime create_user_date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String update_user_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? update_user_date { get; set; }

        /// <summary>
        /// 年度
        /// </summary>
        public System.Int32 year { get; set; }

        /// <summary>
        /// 状态 0正常 1禁用
        /// </summary>
        public System.Int32 state { get; set; }
    }
}