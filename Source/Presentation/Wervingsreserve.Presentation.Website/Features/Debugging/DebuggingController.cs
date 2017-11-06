using Microsoft.AspNetCore.Mvc;

namespace Wervingsreserve.Presentation.Website.Features.Debugging
{
    public class DebuggingController : Controller
    {
        public IActionResult Index()
            => View();        
    }
}