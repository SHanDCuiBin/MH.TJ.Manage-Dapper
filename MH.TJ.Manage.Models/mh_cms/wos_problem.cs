

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 问题记录表
    /// </summary>
    public class wos_problem
    {
        /// <summary>
        /// 问题记录表
        /// </summary>
        public wos_problem()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        public System.String task_id { get; set; }

        /// <summary>
        /// 查体信息id
        /// </summary>
        public System.String ctxx_id { get; set; }

        /// <summary>
        /// 负责人id
        /// </summary>
        public System.Int32? user_id { get; set; }

        /// <summary>
        /// 负责人名称
        /// </summary>
        public System.String user_name { get; set; }

        /// <summary>
        /// 体检查体类型id
        /// </summary>
        public System.Int32? type_id { get; set; }

        /// <summary>
        /// 体检查体类型名称
        /// </summary>
        public System.String type_name { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 钉钉推送时间
        /// </summary>
        public System.DateTime? push_time { get; set; }

        /// <summary>
        /// 问题类型名称
        /// </summary>
        public System.String type { get; set; }

        /// <summary>
        /// 超时类型状态：
        ///0 上传超时
        ///1 自审超时；
        ///2 组审超时；
        ///3 数审超时；
        ///4 医审超时；
        ///5 申请打印超时；
        ///6 打印审核超时；
        ///7 打印超时
        /// </summary>
        public System.Int32? type_status { get; set; }

        /// <summary>
        /// 出现时间
        /// </summary>
        public System.DateTime? start_time { get; set; }

        /// <summary>
        /// 解决时间
        /// </summary>
        public System.DateTime? end_time { get; set; }

        /// <summary>
        /// 解决状态：0 未解决；1 已解决
        /// </summary>
        public System.Int32? status { get; set; }

        /// <summary>
        /// 体检日期
        /// </summary>
        public System.DateTime? tjrq { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public System.DateTime create_time { get; set; }
    }
}