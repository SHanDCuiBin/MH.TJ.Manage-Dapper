using MH.TJ.Manage.IRepository.basicinfo;
using MH.TJ.Manage.Models.basicinfo;
using MH.TJ.Manage.Utility._Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH.TJ.Manage.Repository.basicinfo
{
    public class doctor_auth_userRepository : BaseRepository<doctor_auth_user>, Idoctor_auth_userRepository
    {
        public doctor_auth_userRepository (BunissDataBaseEmum baseType = BunissDataBaseEmum.basicinfoDB) : base(baseType)
        {

        }
    }
}
