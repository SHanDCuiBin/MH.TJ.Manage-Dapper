

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 系统角色表
    /// </summary>
    public class sys_role
    {
        /// <summary>
        /// 系统角色表
        /// </summary>
        public sys_role()
        {
        }

        /// <summary>
        /// 主键id
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public System.Int32? num { get; set; }

        /// <summary>
        /// 父角色id
        /// </summary>
        public System.Int32? pid { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public System.Int32? deptid { get; set; }

        /// <summary>
        /// 提示
        /// </summary>
        public System.String tips { get; set; }

        /// <summary>
        /// 保留字段(暂时没用）
        /// </summary>
        public System.Int32? version { get; set; }

        /// <summary>
        /// 0不是 1.正负责人 2.副负责人
        /// </summary>
        public System.SByte principal { get; set; }

        /// <summary>
        /// 公司绩效个人打分占比数值，10 20
        /// </summary>
        public System.SByte? performance { get; set; }
    }
}