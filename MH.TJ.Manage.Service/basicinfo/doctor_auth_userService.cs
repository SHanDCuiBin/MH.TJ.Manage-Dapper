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
    public class doctor_auth_userService : BaseService<doctor_auth_user>, Idoctor_auth_userService
    {
        //ctor+tab  构造函数快捷键
        // ~ +tab   析构函数的快捷键


        private readonly Idoctor_auth_userRepository _Repository;
        public doctor_auth_userService(Idoctor_auth_userRepository Repository)
        {
            base._iBaseRepository = Repository;
        }
    }
}
