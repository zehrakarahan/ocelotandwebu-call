using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet("CustomerGet")]
        public IActionResult CustomerGet()
        {
            return Ok(new List<string> { "Hilmi Celayir", "Saniye Yıldız", "Nevin Yıldız", "Fatih Yılmaz" });
        }
    }
}
