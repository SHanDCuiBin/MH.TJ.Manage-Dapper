using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH.TJ.Manage.Models.health_infoDTO
{
    public class mh_jktjDto
    {
        /// <summary>
        /// 沐华对应的档案编号 机构号_年份_条码
        /// </summary>
        public System.String mh_card { get; set; }

        /// <summary>
        /// 条码号 对应体检的条码号
        /// </summary>
        public System.String tmh { get; set; }

        /// <summary>
        /// 当前体检年龄
        /// </summary>
        public System.Int32? age { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String gender { get; set; }

        /// <summary>
        /// null/0 默认收费  1不收费
        /// </summary>
        public System.UInt32? is_fufei { get; set; }

        /// <summary>
        /// 人员类型   1老年人/2成年人/3精神病 /4体制内（免费）/5贫困人口/6其他人员类型
        /// </summary>
        public System.String ry_type { get; set; }

        /// <summary>
        /// 机构编号---体检所属机构ID号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 机构名称---体检所属机构名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 体检日期
        /// </summary>
        public System.DateTime? tjrq { get; set; }

        /// <summary>
        /// 体温
        /// </summary>
        public System.Double? tiwen { get; set; }

        /// <summary>
        /// 身高 ----身高体重模块
        /// </summary>
        public System.Double? sg { get; set; }

        /// <summary>
        /// 体重
        /// </summary>
        public System.Double? tz { get; set; }

    }
}
