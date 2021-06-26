

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 部门表
    /// </summary>
    public class sys_dept
    {
        /// <summary>
        /// 部门表
        /// </summary>
        public sys_dept()
        {
        }

        /// <summary>
        /// 主键id
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public System.Int32? num { get; set; }

        /// <summary>
        /// 父部门id
        /// </summary>
        public System.Int32? pid { get; set; }

        /// <summary>
        /// 父级ids
        /// </summary>
        public System.String pids { get; set; }

        /// <summary>
        /// 简称
        /// </summary>
        public System.String simplename { get; set; }

        /// <summary>
        /// 全称
        /// </summary>
        public System.String fullname { get; set; }

        /// <summary>
        /// 提示
        /// </summary>
        public System.String tips { get; set; }

        /// <summary>
        /// 版本（乐观锁保留字段）
        /// </summary>
        public System.Int32? version { get; set; }

        /// <summary>
        /// 是否冻结 0正常1冻结
        /// </summary>
        public System.Int32 state { get; set; }

        /// <summary>
        /// 级别 0公司 1.部门 2.团队
        /// </summary>
        public System.SByte? level { get; set; }
    }
}