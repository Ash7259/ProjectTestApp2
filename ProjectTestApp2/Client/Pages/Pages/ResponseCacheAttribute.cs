using System;

namespace Project20232.Client.Pages
{
    internal class ResponseCacheAttribute : Attribute
    {
        public int Duration { get; set; }
        public object Location { get; set; }
    }
}