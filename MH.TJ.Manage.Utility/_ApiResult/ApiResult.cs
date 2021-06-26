using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH.TJ.Manage.Utility._ApiResult
{
    public class ApiResult
    {
        public int Code { get; set; }

        public string Msg { get; set; }

        public int Total { get; set; }

        public dynamic Data { get; set; }
    }
}
