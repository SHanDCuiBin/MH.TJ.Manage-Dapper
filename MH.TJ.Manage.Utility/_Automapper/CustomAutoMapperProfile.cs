using AutoMapper;
using MH.TJ.Manage.Models.basicinfo;
using MH.TJ.Manage.Models.basicinfoDTO;
using MH.TJ.Manage.Models.health_info;
using MH.TJ.Manage.Models.health_infoDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH.TJ.Manage.Utility._Automapper
{

    public class CustomAutoMapperProfile : Profile
    {
        public CustomAutoMapperProfile()
        {
            base.CreateMap<mh_jktj, mh_jktjDto>();
            base.CreateMap<rhr, rhrDto>();
        }
    }
}
