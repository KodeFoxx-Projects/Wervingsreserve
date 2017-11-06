using Microsoft.AspNetCore.Mvc;

namespace Wervingsreserve.Presentation.Website.Features.Debugging
{
    [Produces("application/json")]
    public class DebuggingController : Controller
    {
        [HttpGet]
        public IActionResult Version()
          => Ok("1.0.0");
    }
}
