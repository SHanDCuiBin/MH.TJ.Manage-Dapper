
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 体检与血球中间表 --健康体检功能-体检与血球的对应关系表
    /// </summary>
    public class mh_jy_xqparson
    {
        /// <summary>
        /// 体检与血球中间表 --健康体检功能-体检与血球的对应关系表
        /// </summary>
        public mh_jy_xqparson()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String xq_parid { get; set; }

        /// <summary>
        /// 体检类型   1 公卫健康体检   2  幼儿园健康体检      3  学生健康体检 
        /// </summary>
        public System.Int32 tjtype { get; set; }

        /// <summary>
        /// 对应体检表  ID号  
        /// </summary>
        public System.String tjid { get; set; }

        /// <summary>
        /// 人员编号
        /// </summary>
        public System.String mh_card { get; set; }

        /// <summary>
        /// 条码号
        /// </summary>
        public System.String tmh { get; set; }

        /// <summary>
        /// 年度
        /// </summary>
        public System.Int32? year { get; set; }

        /// <summary>
        /// 检验日期
        /// </summary>
        public System.DateTime jyrq { get; set; }

        /// <summary>
        /// 机构号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public System.String gender { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public System.Int32? age { get; set; }

        /// <summary>
        /// 检验血液采集类型   末梢血/静脉血/其他
        /// </summary>
        public System.String specimentype { get; set; }

        /// <summary>
        /// 送检时间(采血时间)
        /// </summary>
        public System.DateTime? inspectiontime { get; set; }

        /// <summary>
        /// 检验机构
        /// </summary>
        public System.String hospital { get; set; }

        /// <summary>
        /// 检验者编号
        /// </summary>
        public System.String jy_user_id { get; set; }

        /// <summary>
        /// 检验者姓名
        /// </summary>
        public System.String jy_user_name { get; set; }

        /// <summary>
        /// 审核者姓名
        /// </summary>
        public System.String sh_user_name { get; set; }

        /// <summary>
        /// 批准情况    0/null  未批准  1  已批准  2 批准不通过  3 申请再次批准 
        /// </summary>
        public System.String approver_flag { get; set; }

        /// <summary>
        /// 批准不通过原因
        /// </summary>
        public System.String approverinfo { get; set; }

        /// <summary>
        /// 批准人
        /// </summary>
        public System.String approvername { get; set; }

        /// <summary>
        /// 批准时间
        /// </summary>
        public System.DateTime? approvertime { get; set; }

        /// <summary>
        /// 打印标记   0/null  未打印    1 已打印  2异常无法打印
        /// </summary>
        public System.String print_flag { get; set; }

        /// <summary>
        /// 打印时间
        /// </summary>
        public System.DateTime? printtime { get; set; }

        /// <summary>
        /// 打印人
        /// </summary>
        public System.String printuser { get; set; }

        /// <summary>
        /// 检验车辆
        /// </summary>
        public System.String jycar { get; set; }

        /// <summary>
        /// 样本状态
        /// </summary>
        public System.String ybzt { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 创建人ID号
        /// </summary>
        public System.String create_user_id { get; set; }

        /// <summary>
        /// 创建人姓名
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 修改时间 
        /// </summary>
        public System.DateTime? update_time { get; set; }

        /// <summary>
        /// 修改人ID 号 
        /// </summary>
        public System.String update_user_id { get; set; }

        /// <summary>
        /// 修改人名称
        /// </summary>
        public System.String update_user_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 检验结果状态是否人工审核 0不需要审核  1需要审核
        /// </summary>
        public System.Int32? jy_state { get; set; }
    }
}