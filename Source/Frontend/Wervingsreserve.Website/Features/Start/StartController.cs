using Microsoft.AspNetCore.Mvc;

namespace Wervingsreserve.Website.Features.Start
{
    [Route("[controller]")]
    public class StartController : Controller
    {
        [Route("")]
        public IActionResult Start() => View();
    }
}
