using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("ProductList")]
        public IActionResult ProductList()
        {
            return Ok(new List<string> { "Kalem", "Kitap", "Silgi", "Defter" });
        }
    }
}
