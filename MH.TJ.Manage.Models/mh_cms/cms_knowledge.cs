

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 知识库表
    /// </summary>
    public class cms_knowledge
    {
        /// <summary>
        /// 知识库表
        /// </summary>
        public cms_knowledge()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 类型ID
        /// </summary>
        public System.String typeid { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public System.String title { get; set; }

        /// <summary>
        /// 附件地址 格式:[file1],[file2]
        /// </summary>
        public System.String accessory { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public System.String contents { get; set; }

        /// <summary>
        /// 图片id
        /// </summary>
        public System.String imgid { get; set; }

        /// <summary>
        /// 视频地址
        /// </summary>
        public System.String video_url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? sort { get; set; }

        /// <summary>
        /// 阅读次数
        /// </summary>
        public System.Int32? readcount { get; set; }

        /// <summary>
        /// 删除 0未删除 1已删除
        /// </summary>
        public System.String is_delete { get; set; }

        /// <summary>
        /// 附件
        /// </summary>
        public System.String attachmentPath { get; set; }

        /// <summary>
        /// 是否采纳 0未被采纳  1采纳
        /// </summary>
        public System.Int32? is_used { get; set; }

        /// <summary>
        /// 点赞数量
        /// </summary>
        public System.Int32? praise_count { get; set; }

        /// <summary>
        /// 点赞人   [1,2,3,4,]
        /// </summary>
        public System.String praise_user { get; set; }

        /// <summary>
        /// 大分类  0知识库数据 1问题解决方案数据
        /// </summary>
        public System.String max_type { get; set; }

        /// <summary>
        /// 问题表主键id
        /// </summary>
        public System.String problemid { get; set; }

        /// <summary>
        /// 创建人,编写人
        /// </summary>
        public System.Int32? create_user_id { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 创建人姓名
        /// </summary>
        public System.String create_user_name { get; set; }
    }
}