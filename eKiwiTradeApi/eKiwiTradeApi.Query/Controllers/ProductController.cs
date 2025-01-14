using Microsoft.AspNetCore.Mvc;

namespace eKiwiTradeApi.Query.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet("GlobalSearch")]
        public async Task<IActionResult> GlobalSearch()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            // send requester details to product owner on mail and ack 

            return Ok();//
        }

        [HttpGet("GetProductByCatGroupType")]
        public async Task<IActionResult> GetProductByCatGroupType(int categoryId, int groupId, int TypeId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            // send requester details to product owner on mail and ack 

            return Ok();//
        }
    }
}
