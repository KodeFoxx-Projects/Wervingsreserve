using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Wervingsreserve.Website.Features.Error
{
    public class ErrorController : Controller
    {
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
