

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 对接平台解决方案表
    /// </summary>
    public class platform_solution
    {
        /// <summary>
        /// 对接平台解决方案表
        /// </summary>
        public platform_solution()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String Id { get; set; }

        /// <summary>
        /// 平台基本信息id，对应platform_base表id
        /// </summary>
        public System.String platform_id { get; set; }

        /// <summary>
        /// 解决方案名称及介绍
        /// </summary>
        public System.String solve_program { get; set; }

        /// <summary>
        /// 对接程序类型  1、Java  2、C#  3、Java与C#  4、C#模拟
        /// </summary>
        public System.Int32? type { get; set; }

        /// <summary>
        /// 对接程序负责人
        /// </summary>
        public System.String developer { get; set; }

        /// <summary>
        /// 开发日期
        /// </summary>
        public System.DateTime? create_date { get; set; }

        /// <summary>
        /// 备注，描述所用技术及注意事项
        /// </summary>
        public System.String remark { get; set; }
    }
}