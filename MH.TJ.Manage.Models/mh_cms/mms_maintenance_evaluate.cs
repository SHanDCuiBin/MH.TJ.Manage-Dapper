

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 维修评价表
    /// </summary>
    public class mms_maintenance_evaluate
    {
        /// <summary>
        /// 维修评价表
        /// </summary>
        public mms_maintenance_evaluate()
        {
        }

        /// <summary>
        /// id UUID
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 维修明细表id
        /// </summary>
        public System.String datil_code { get; set; }

        /// <summary>
        /// 累计维修时长
        /// </summary>
        public System.String sum_time { get; set; }

        /// <summary>
        /// 状态 1 维修完成
        /// </summary>
        public System.Int32? type { get; set; }

        /// <summary>
        /// 维修是否合格 0 不合格 1 合格
        /// </summary>
        public System.Int32? is_qualified { get; set; }

        /// <summary>
        /// 星级 1 差 3 良 5 优
        /// </summary>
        public System.Int32? star { get; set; }

        /// <summary>
        /// 评价
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 快捷短语 1 维修快 2 质量好 3 效率高 4 专业强 5 态度恶劣 6 不合格
        /// </summary>
        public System.Int32? shortcut_str { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }
    }
}