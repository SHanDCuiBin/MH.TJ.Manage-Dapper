

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 字典表
    /// </summary>
    public class sys_dict
    {
        /// <summary>
        /// 字典表
        /// </summary>
        public sys_dict()
        {
        }

        /// <summary>
        /// 主键id
        /// </summary>
        public System.UInt32 id { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public System.Int32? num { get; set; }

        /// <summary>
        /// 父级字典
        /// </summary>
        public System.Int32? pid { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 提示
        /// </summary>
        public System.String tips { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        public System.String code { get; set; }

        /// <summary>
        /// 是否删除 0不删除，1删除
        /// </summary>
        public System.Int32? delflag { get; set; }
    }
}