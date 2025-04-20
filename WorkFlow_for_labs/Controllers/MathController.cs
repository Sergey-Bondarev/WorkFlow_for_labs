using Microsoft.AspNetCore.Mvc;

namespace WorkFlow_for_labs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {
        [HttpGet("add")]
        public ActionResult<int> Add(int a, int b)
        {
            return Ok(a + b);
        }
    }
}
