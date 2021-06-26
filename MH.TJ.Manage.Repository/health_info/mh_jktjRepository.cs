using MH.TJ.Manage.IRepository.health_info;
using MH.TJ.Manage.Models.health_info;
using MH.TJ.Manage.Utility._Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH.TJ.Manage.Repository.health_info
{
    public class mh_jktjRepository : BaseRepository<mh_jktj>, Imh_jktjRepository
    {
        public mh_jktjRepository(BunissDataBaseEmum baseType = BunissDataBaseEmum.healthInfoDB) : base(baseType)
        {

        }
    }
}
