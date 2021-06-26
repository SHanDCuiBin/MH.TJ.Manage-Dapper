
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// B超分部位检查情况
    /// </summary>
    public class mh_jktj_bc
    {
        /// <summary>
        /// B超分部位检查情况
        /// </summary>
        public mh_jktj_bc()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 健康体检ID 号
        /// </summary>
        public System.String jktj_id { get; set; }

        /// <summary>
        /// B超检查部位正异常标记  1 正常  2异常
        /// </summary>
        public System.Int32? bc_flag { get; set; }

        /// <summary>
        /// 检查部位  肝、胆、胰、脾、双肾、甲状腺、膀胱
        /// </summary>
        public System.String bc_position { get; set; }

        /// <summary>
        /// 检查结果
        /// </summary>
        public System.String bc_result { get; set; }

        /// <summary>
        /// 部位所见
        /// </summary>
        public System.String bc_seen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String remark { get; set; }
    }
}