using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH.TJ.Manage.Models.basicinfoDTO
{
    public class doctor_auth_userDTO
    {
        /// <summary>
        /// 医生登录用户信息表--原表mh_et_auth_user
        /// </summary>
        public doctor_auth_userDTO()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 用户注册时填写的名称，由字母数字下划线组成。
        /// </summary>
        public System.String user_id { get; set; }

        /// <summary>
        /// 用户的姓名
        /// </summary>
        public System.String real_name { get; set; }

        /// <summary>
        /// 人员类型  11 审核医生  12 主任  13 检验审核医生 14公卫医生  15心电图审核医生 16体检医生  17X光审核医生 18儿童审核医生
        /// </summary>
        public System.String user_type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? enable { get; set; }

        /// <summary>
        /// 机构号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public System.String description { get; set; }

    }
}
