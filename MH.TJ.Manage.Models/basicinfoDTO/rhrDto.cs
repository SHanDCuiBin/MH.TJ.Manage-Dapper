using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH.TJ.Manage.Models.basicinfoDTO
{
    public class rhrDto
    {
        /// <summary>
        /// 个人姓名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 姓名拼音
        /// </summary>
        public string name_pinyin { get; set; }

        /// <summary>
        /// 0未知性别1 男 2 女 9 未说明性别
        /// </summary>
        public int? gender_code { get; set; }
    }
}
