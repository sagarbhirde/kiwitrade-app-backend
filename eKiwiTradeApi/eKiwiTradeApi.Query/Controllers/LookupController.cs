using eKiwiTradeApi.Logic.Interface;
using Microsoft.AspNetCore.Mvc;

namespace eKiwiTradeApi.Query.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LookupController : Controller
    {
        private readonly ILookupService _lookupService;
        public LookupController(ILookupService lookupService)
        {
            _lookupService = lookupService;
        }


        [HttpGet("category")]
        public async Task<IActionResult> GetAllCategoryLookup()
        {
            return Ok(await _lookupService.GetAllCategoryLookup().ConfigureAwait(false));
        }

         [HttpGet("group")]
    public async Task<IActionResult> GetGroupLookupByCategoryId(int categoryId)
    {
        return Ok(await _lookupService.GetGroupLookupByCategoryId(categoryId).ConfigureAwait(false));
    }

    [HttpGet("type")]
    public async Task<IActionResult> GetTypeLookupByGroupAndCategoryId(int groupId, int categoryId)
    {
        return Ok(await _lookupService.GetTypeLookupByGroupAndCategoryId(groupId, categoryId).ConfigureAwait(false));
    }


 [HttpGet("district")]
        public async Task<IActionResult> GetAllDistrictLookup()
        {
            return Ok(await _lookupService.GetAllDistrictLookup().ConfigureAwait(false));
        }

        [HttpGet("city")]
        public async Task<IActionResult> GetCityLookupByDistrictId(int districtId)
        {
            return Ok(await _lookupService.GetCityLookupByDistrictId(districtId).ConfigureAwait(false));
        }

        [HttpGet("suburb")]
        public async Task<IActionResult> GetSuburbLookupByCityAndDistrictId(int cityId, int districtId)
        {
            return Ok(await _lookupService.GetSuburbLookupByCityAndDistrictId(cityId, districtId).ConfigureAwait(false));
        }


        //[HttpGet("field")]
        //public async Task<IActionResult> GetFieldLookup(int fieldId)
        //{
        //    return Ok(await _lookupService.GetFieldLookupAsync(fieldId).ConfigureAwait(false));
        //}
    }
}
