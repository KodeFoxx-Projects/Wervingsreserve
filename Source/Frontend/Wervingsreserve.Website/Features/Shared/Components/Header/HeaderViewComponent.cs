using System;
using Microsoft.AspNetCore.Mvc;

namespace Wervingsreserve.Website.Features.Shared.Components.Header
{
    public class HeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string title) {
            var viewModel = new Header(title);
            return View(viewModel);
        }
    }
}
