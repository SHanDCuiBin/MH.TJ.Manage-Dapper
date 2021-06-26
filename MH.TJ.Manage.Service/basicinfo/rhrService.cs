using MH.TJ.Manage.IRepository.basicinfo;
using MH.TJ.Manage.IService.basicinfo;
using MH.TJ.Manage.Models.basicinfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH.TJ.Manage.Service.basicinfo
{
    public class rhrService : BaseService<rhr>, IrhrService
    {
        private readonly IrhrRepository _Repository;
        public rhrService(IrhrRepository Repository)
        {
            base._iBaseRepository = Repository;
        }
    }
}
