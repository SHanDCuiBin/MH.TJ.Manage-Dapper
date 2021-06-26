

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 健康体检  老年人 机构    档案完善模板配置信息主 表    对应子表   mh_lnr_wsinfo
    /// </summary>
    public class mh_lnr_wsmb
    {
        /// <summary>
        /// 健康体检  老年人 机构    档案完善模板配置信息主 表    对应子表   mh_lnr_wsinfo
        /// </summary>
        public mh_lnr_wsmb()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String mb_id { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        public System.String mb_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String mb_org_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String mb_org_name { get; set; }

        /// <summary>
        /// 模板级别   0共有模板   1 私有模板
        /// </summary>
        public System.Int32? mb_level { get; set; }

        /// <summary>
        /// 是否启用  0 启用  1禁用
        /// </summary>
        public System.UInt32? mb_enable { get; set; }

        /// <summary>
        /// 模板描述
        /// </summary>
        public System.String mb_msg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String mb_create_user_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String mb_create_user_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String mb_create_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String mb_remark { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String mb_sq_user_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String mb_qr_user_id { get; set; }
    }
}