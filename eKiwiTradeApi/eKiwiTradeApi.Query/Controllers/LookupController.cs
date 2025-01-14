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

        //[HttpGet("field")]
        //public async Task<IActionResult> GetFieldLookup(int fieldId)
        //{
        //    return Ok(await _lookupService.GetFieldLookupAsync(fieldId).ConfigureAwait(false));
        //}
    }
}
