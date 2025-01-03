using eKiwiTradeApi.Logic.Model;
using Microsoft.AspNetCore.Mvc;

namespace eKiwiTradeApi.Command.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        [HttpPost("ProductEnquiry")]
        public async Task<IActionResult> ProductEnquiry()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            // send requester details to product owner on mail and ack 

            return Ok();//
        }

        [HttpPost("CreateProduct")]
        public async Task<IActionResult> CreateProduct()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            // Create new product  

            return Ok();//
        }

        [HttpPost("UpdateProduct")]
        public async Task<IActionResult> UpdateProduct()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            // Updsate product  

            return Ok();//
        }

        [HttpPost("DeleteProduct")]
        public async Task<IActionResult> DeleteProduct()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            // delete Product

            return Ok();//
        }

       
    }
}
