

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 升级记录表
    /// </summary>
    public class upgraderecord
    {
        /// <summary>
        /// 升级记录表
        /// </summary>
        public upgraderecord()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 升级版本id
        /// </summary>
        public System.String upgradeid { get; set; }

        /// <summary>
        /// 升级人账号
        /// </summary>
        public System.String username { get; set; }

        /// <summary>
        /// 升级人真实姓名
        /// </summary>
        public System.String realname { get; set; }

        /// <summary>
        /// 电脑类型  1一体机 2备用本  3采集模块  4检验模块 5审核模块 6检验科审核 7慢病系统
        /// </summary>
        public System.Int32? computertype { get; set; }

        /// <summary>
        /// 升级日期
        /// </summary>
        public System.DateTime? upgradedate { get; set; }

        /// <summary>
        /// 是否公司用户 0公司用户  1医院用户
        /// </summary>
        public System.String iscompany { get; set; }

        /// <summary>
        /// 医院用户升级的机构号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 是否是院内升级 0否 1是
        /// </summary>
        public System.String is_in_hospital { get; set; }

        /// <summary>
        /// 电脑注册码
        /// </summary>
        public System.String jym_info { get; set; }

        /// <summary>
        /// 是否上传 1为上传成功 0为未上传
        /// </summary>
        public System.Int32? up_flag { get; set; }
    }
}