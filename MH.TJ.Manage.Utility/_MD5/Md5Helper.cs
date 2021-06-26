using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MH.TJ.Manage.Utility._MD5
{
    public static class Md5Helper
    {
        public static string Md5Encrypt32(string str)
        {
            string md5Str = "";
            MD5 md5 = MD5.Create();
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
            for (int i = 0; i < s.Length; i++)
            {
                md5Str += s[i].ToString("X");
            }
            return md5Str;
        }
    }
}
