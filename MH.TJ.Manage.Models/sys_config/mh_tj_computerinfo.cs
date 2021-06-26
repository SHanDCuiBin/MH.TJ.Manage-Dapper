

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 【沐华健康体检管理系统】体检   电脑注册信息表--记录电脑软件安装的注册信息
    /// </summary>
    public class mh_tj_computerinfo
    {
        /// <summary>
        /// 【沐华健康体检管理系统】体检   电脑注册信息表--记录电脑软件安装的注册信息
        /// </summary>
        public mh_tj_computerinfo()
        {
        }

        /// <summary>
        /// 编号
        /// </summary>
        public System.String jym_id { get; set; }

        /// <summary>
        /// 机器码
        /// </summary>
        public System.String jym_info { get; set; }

        /// <summary>
        /// 加密后  机器码
        /// </summary>
        public System.String jym_jminfo { get; set; }

        /// <summary>
        /// 机器类别   1 一体机  2  备用本   3  采集本  
        /// </summary>
        public System.String jym_type { get; set; }

        /// <summary>
        /// 软件类型
        /// </summary>
        public System.String software_type { get; set; }

        /// <summary>
        /// 机器权限       1 公司电脑   2  医院电脑  
        /// </summary>
        public System.String jym_qx { get; set; }

        /// <summary>
        /// 体检内容    lnr 老年人   yey 幼儿园  xues   学生  jiaos 教师
        /// </summary>
        public System.String jym_tjnr { get; set; }

        /// <summary>
        /// 检验码过期日期
        /// </summary>
        public System.DateTime? jym_jqsj { get; set; }

        /// <summary>
        /// 机器所属机构
        /// </summary>
        public System.String jym_org_id { get; set; }

        /// <summary>
        /// 申请人
        /// </summary>
        public System.String jym_user_id { get; set; }

        /// <summary>
        /// 申请姓名
        /// </summary>
        public System.String jym_user_name { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String jym_create_user_id { get; set; }

        /// <summary>
        /// 创建人名称
        /// </summary>
        public System.String jym_create_user_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? jym_create_time { get; set; }

        /// <summary>
        /// 设备启用状态    0启用  2/null 禁用
        /// </summary>
        public System.UInt32? jym_enable { get; set; }

        /// <summary>
        /// 查询权限    1启用  2/null 禁用
        /// </summary>
        public System.UInt32? jym_sel_enable { get; set; }

        /// <summary>
        /// 添加权限     1启用  2/null 禁用
        /// </summary>
        public System.UInt32? jym_add_enable { get; set; }

        /// <summary>
        /// 修改权限    1启用  2/null 禁用
        /// </summary>
        public System.UInt32? jym_upd_enable { get; set; }

        /// <summary>
        /// 删除权限     1启用  2/null 禁用
        /// </summary>
        public System.Int32? jym_del_enable { get; set; }

        /// <summary>
        /// 操作查询次数
        /// </summary>
        public System.UInt32? jym_sel_num { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.UInt32? jym_add_num { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.UInt32? jym_upd_num { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.UInt32? jym_del_num { get; set; }

        /// <summary>
        /// 最后操作时间s
        /// </summary>
        public System.DateTime? jym_last_time { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String jym_remark { get; set; }

        /// <summary>
        /// 电脑编号
        /// </summary>
        public System.String jym_num { get; set; }

        /// <summary>
        /// 钉钉id
        /// </summary>
        public System.String ding_talk_id { get; set; }

        /// <summary>
        /// 审批人id
        /// </summary>
        public System.String audit_user_ids { get; set; }

        /// <summary>
        /// 审批人姓名
        /// </summary>
        public System.String audit_users { get; set; }

        /// <summary>
        /// 状态（1.已申请，2.已同意，3.已拒绝，4.已撤回）
        /// </summary>
        public System.Int32? status { get; set; }
    }
}