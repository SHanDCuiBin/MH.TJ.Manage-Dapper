

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 月计划模板表
    /// </summary>
    public class soc_plan_templete
    {
        /// <summary>
        /// 月计划模板表
        /// </summary>
        public soc_plan_templete()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// 父级ID
        /// </summary>
        public System.Int64? p_id { get; set; }

        /// <summary>
        /// 模块名称
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 角色Id(岗位) 0代表所有人
        /// </summary>
        public System.String role_ids { get; set; }

        /// <summary>
        /// 角色名称(岗位)
        /// </summary>
        public System.String role_names { get; set; }

        /// <summary>
        /// 顺序 显示顺序
        /// </summary>
        public System.Int32? num { get; set; }

        /// <summary>
        /// 级别 (1 2 3)
        /// </summary>
        public System.Int32? level { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 创建人Id
        /// </summary>
        public System.Int32? create_user_id { get; set; }

        /// <summary>
        /// 创建人姓名
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 可否添加1.可添加2.不可添加
        /// </summary>
        public System.Int32 is_add { get; set; }

        /// <summary>
        /// 何时显示 1.所有时间 2.增加 3.修改 4.追加
        /// </summary>
        public System.SByte? show_type { get; set; }
    }
}