using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.ErrorHandler.Samples.Controllers
{
    [ApiController]
    [Route("prefix")]
    public class GeneralRoutePrefixController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
            => Ok("Success...");

        [HttpGet("with-prefix")]
        public IActionResult WithGeneralPrefix()
            => Ok("Success...");

        [HttpGet("/without-prefix")]
        public IActionResult WithoutGeneralPrefix()
            => Ok("Success...");
    }
}
