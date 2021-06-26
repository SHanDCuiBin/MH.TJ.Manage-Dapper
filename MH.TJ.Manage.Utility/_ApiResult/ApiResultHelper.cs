using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH.TJ.Manage.Utility._ApiResult
{
    public static class ApiResultHelper
    {
        public static ApiResult Success(dynamic data)
        {
            return new ApiResult { Code = 200, Msg = "操作成功", Total = 0, Data = data };
        }

        public static ApiResult Success(dynamic data, int total)
        {
            return new ApiResult { Code = 200, Msg = "操作成功", Total = total, Data = data };
        }

        public static ApiResult Error(string msg)
        {
            return new ApiResult { Code = 500, Msg = msg, Total = 0, Data = null };
        }

    }
}
