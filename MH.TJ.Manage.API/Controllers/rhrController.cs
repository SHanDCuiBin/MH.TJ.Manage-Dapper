using AutoMapper;
using MH.TJ.Manage.IService.basicinfo;
using MH.TJ.Manage.IService.health_info;
using MH.TJ.Manage.Models.basicinfo;
using MH.TJ.Manage.Models.basicinfoDTO;
using MH.TJ.Manage.Models.health_info;
using MH.TJ.Manage.Models.health_infoDTO;
using MH.TJ.Manage.Utility._ApiResult;
using MH.TJ.Manage.Utility._DESEncrypt;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MH.TJ.Manage.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class rhrController : ControllerBase
    {
        private readonly IrhrService _irhrService;
        private readonly Imh_jktjService _imh_jktjService;
        public rhrController(IrhrService irhrService, Imh_jktjService imh_JktjService)
        {
            this._irhrService = irhrService;
            this._imh_jktjService = imh_JktjService;
        }

        /// <summary>
        /// 获取个人基本信息
        /// </summary>
        /// <param name="id_card"></param>
        /// <param name="mapper"></param>
        /// <returns></returns>
        [HttpPost("GetUsers")]
        public async Task<ApiResult> GetUsers(string id_card, [FromServices] IMapper mapper)
        {
            // string idcard = DESEncrypt.JiaMiStr(id_card);
            // var infos = await _irhrService.QueryAsync(c => c.id_card == idcard);
            // if (infos != null && infos.Count > 0)
            // {
            //
            //     var dto = mapper.Map<List<rhrDto>>(infos);
            //     return ApiResultHelper.Success(dto);
            // }
            // else
            // {
            //     return ApiResultHelper.Error("未获取到查询结果");
            // }

            return ApiResultHelper.Error("未获取到查询结果");
        }


        /// <summary>
        /// 获取健康体检记录 【当年】
        /// </summary>
        /// <param name="tmh"></param>
        /// <param name="mapper"></param>
        /// <returns></returns>
        [HttpPost("GetJktj")]
        public async Task<ApiResult> GetJktj(string tmh, [FromServices] IMapper mapper)
        {
            //var users = await _imh_jktjService.GetAsync("32132203002_120005703211089_20210120");
            //if (users != null )
            //{
            //    var dto = mapper.Map<mh_jktjDto>(users);
            //    return ApiResultHelper.Success(dto);
            //}
            //else
            //{
            //    return ApiResultHelper.Error("未获取到查询结果");
            //}

            return ApiResultHelper.Error("未获取到查询结果");
        }

        /// <summary>
        /// 获取健康体检记录  【跨年】
        /// </summary>
        /// <param name="tmh"></param>
        /// <param name="mapper"></param>
        /// <returns></returns>
        [HttpPost("GetJktjOld")]
        public async Task<ApiResult> GetJktjOld([FromServices] IMapper mapper,string tmh, int startyear = 0, int endyear = 0)
        {
            var users = _imh_jktjService.Get<mh_jktj>(tmh, startyear, endyear);
            if (users != null)
            {
                var dto = mapper.Map<mh_jktjDto>(users);
                return ApiResultHelper.Success(dto);
            }
            else
            {
                return ApiResultHelper.Error("未获取到查询结果");
            }

            return ApiResultHelper.Error("未获取到查询结果");
        }

        /// <summary>
        /// 分页查询获取健康体检记录  【跨年】
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="mapper"></param>
        /// <returns></returns>
        [HttpPost("GetJktjFenyeKuaNian")]
        public async Task<ApiResult> GetJktjFenyeKuaNian(int page, int size, [FromServices] IMapper mapper)
        {
            //RefAsync<int> total = 0;
            //var users = await _imh_jktjService.QueryAsync(page, size, total, 2020, 2021);
            //if (users != null && users.Count > 0)
            //{
            //    var dto = mapper.Map<List<mh_jktjDto>>(users);
            //    return ApiResultHelper.Success(dto, total);
            //}
            //else
            //{
            //    return ApiResultHelper.Error("未获取到查询结果");
            //}

            return ApiResultHelper.Error("未获取到查询结果");
        }

        /// <summary>
        /// 分页查询获取健康体检记录
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="mapper"></param>
        /// <returns></returns>
        [HttpPost("GetJktjFenye")]
        public async Task<ApiResult> GetJktjFenye(int page, int size, [FromServices] IMapper mapper)
        {
            //RefAsync<int> total = 0;
            //var users = await _imh_jktjService.QueryAsync(page, size, total);
            //if (users != null && users.Count > 0)
            //{
            //    var dto = mapper.Map<List<mh_jktjDto>>(users);
            //    return ApiResultHelper.Success(dto, total);
            //}
            //else
            //{
            //    return ApiResultHelper.Error("未获取到查询结果");
            //}

            return ApiResultHelper.Error("未获取到查询结果");
        }
    }
}
