using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Rookie.Ecom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Test ok");
        }
    }
}
