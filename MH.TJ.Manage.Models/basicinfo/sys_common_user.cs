

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 系统用户表
    /// </summary>
    public class sys_common_user
    {
        /// <summary>
        /// 系统用户表
        /// </summary>
        public sys_common_user()
        {
        }

        /// <summary>
        /// 主键id
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public System.String avatar { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        public System.String account { get; set; }

        /// <summary>
        /// 沐华编号
        /// </summary>
        public System.String mhno { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public System.String password { get; set; }

        /// <summary>
        /// md5密码盐
        /// </summary>
        public System.String salt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String cpassword { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public System.DateTime? birthday { get; set; }

        /// <summary>
        /// 性别（1：男 2：女）
        /// </summary>
        public System.Int32? sex { get; set; }

        /// <summary>
        /// 电子邮件
        /// </summary>
        public System.String email { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public System.String phone { get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        public System.String roleid { get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        public System.Int32? deptid { get; set; }

        /// <summary>
        /// 状态(1：启用  2：冻结  3：删除）
        /// </summary>
        public System.Int32? status { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? createtime { get; set; }

        /// <summary>
        /// 保留字段
        /// </summary>
        public System.Int32? version { get; set; }

        /// <summary>
        /// 上级领导id
        /// </summary>
        public System.String leaderid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String leaderids { get; set; }

        /// <summary>
        /// 上级领导姓名
        /// </summary>
        public System.String leadername { get; set; }

        /// <summary>
        /// 工作状态 0空闲  1忙碌  2休假
        /// </summary>
        public System.String workstatus { get; set; }

        /// <summary>
        /// 职工当前状态   1 在职  2 离职 3 休假 4 其他
        /// </summary>
        public System.String positionstate { get; set; }
    }
}