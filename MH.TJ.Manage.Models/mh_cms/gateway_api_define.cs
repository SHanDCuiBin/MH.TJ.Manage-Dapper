

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 
    /// </summary>
    public class gateway_api_define
    {
        /// <summary>
        /// 
        /// </summary>
        public gateway_api_define()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String service_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String url { get; set; }

        /// <summary>
        /// 测试接口名, 例如: /test
        /// </summary>
        public System.String test_uri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Boolean? retryable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Boolean enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? strip_prefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String api_name { get; set; }

        /// <summary>
        ///  0不更新 1更新
        /// </summary>
        public System.Byte state { get; set; }
    }
}