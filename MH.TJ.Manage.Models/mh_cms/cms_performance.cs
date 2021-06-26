

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 公司绩效表
    /// </summary>
    public class cms_performance
    {
        /// <summary>
        /// 公司绩效表
        /// </summary>
        public cms_performance()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 绩效月度
        /// </summary>
        public System.String month { get; set; }

        /// <summary>
        /// 部门
        /// </summary>
        public System.Int32 dept_id { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public System.String dept_name { get; set; }

        /// <summary>
        /// 岗位
        /// </summary>
        public System.String jobs { get; set; }

        /// <summary>
        /// 被考核人
        /// </summary>
        public System.Int32 create_user { get; set; }

        /// <summary>
        /// 考核人姓名
        /// </summary>
        public System.String create_name { get; set; }

        /// <summary>
        /// 考核人
        /// </summary>
        public System.Int32? reviewers { get; set; }

        /// <summary>
        /// 考核人姓名
        /// </summary>
        public System.String reviewers_name { get; set; }

        /// <summary>
        /// 政委
        /// </summary>
        public System.Int32? political_commissar { get; set; }

        /// <summary>
        /// 政委姓名
        /// </summary>
        public System.String political_commissar_name { get; set; }

        /// <summary>
        /// 状态码 0提交状态1确认权重2绩效自评3领导评分4经理确认5人事确认
        /// </summary>
        public System.Int32 state { get; set; }

        /// <summary>
        /// 自评总分
        /// </summary>
        public System.Int32? zp_num { get; set; }

        /// <summary>
        /// 领导评分总分
        /// </summary>
        public System.Int32? parent_num { get; set; }

        /// <summary>
        /// 总分
        /// </summary>
        public System.Double? num { get; set; }

        /// <summary>
        /// 价值观自评总分
        /// </summary>
        public System.Int32? jzg_zp_num { get; set; }

        /// <summary>
        /// 价值观总分
        /// </summary>
        public System.Int32? jzg_num { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime create_date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? update_date { get; set; }

        /// <summary>
        /// 考核时间
        /// </summary>
        public System.DateTime? reviewers_date { get; set; }

        /// <summary>
        /// 业绩等级ABCD
        /// </summary>
        public System.String yj_rating { get; set; }

        /// <summary>
        /// 价值观等级ABCD
        /// </summary>
        public System.String jzg_rating { get; set; }

        /// <summary>
        /// 评级ABCD
        /// </summary>
        public System.String rating { get; set; }

        /// <summary>
        /// 用于判断经理是否修改绩效
        /// </summary>
        public System.Int32 flag { get; set; }
    }
}