

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 图片表
    /// </summary>
    public class imagedb
    {
        /// <summary>
        /// 图片表
        /// </summary>
        public imagedb()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 类型 1知识库  2数据上报确认照
        /// </summary>
        public System.String type { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        public System.String taskid { get; set; }

        /// <summary>
        /// 路径
        /// </summary>
        public System.String imgpath { get; set; }
    }
}