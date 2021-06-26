using MH.TJ.Manage.IRepository.health_info;
using MH.TJ.Manage.IService.health_info;
using MH.TJ.Manage.Models.health_info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH.TJ.Manage.Service.health_info
{
    public class mh_jktjService : BaseService<mh_jktj>, Imh_jktjService
    {
        private readonly Imh_jktjRepository _Repository;
        public mh_jktjService(Imh_jktjRepository Repository)
        {
            base._iBaseRepository = Repository;
        }
    }
}
