

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// RabbitMQ消息队列失败日志表
    /// </summary>
    public class qcs_rabbitmq_queue_log
    {
        /// <summary>
        /// RabbitMQ消息队列失败日志表
        /// </summary>
        public qcs_rabbitmq_queue_log()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// 消息队列名称
        /// </summary>
        public System.String routing_key { get; set; }

        /// <summary>
        /// 失败信息
        /// </summary>
        public System.String msg { get; set; }

        /// <summary>
        /// 队列消息主体参数
        /// </summary>
        public System.String body { get; set; }

        /// <summary>
        /// 0未解决1已解决
        /// </summary>
        public System.Boolean state { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        public System.String reason { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 解决时间
        /// </summary>
        public System.DateTime? update_time { get; set; }
    }
}