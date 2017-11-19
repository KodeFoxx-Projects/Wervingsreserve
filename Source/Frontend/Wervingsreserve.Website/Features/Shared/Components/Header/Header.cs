using System;

namespace Wervingsreserve.Website.Features.Shared.Components.Header
{
    public sealed class Header
    {
        public string Title { get; }

        public Header(string title) 
            => Title = String.IsNullOrWhiteSpace(title) ? "?" : title.Trim();        
    }
}
