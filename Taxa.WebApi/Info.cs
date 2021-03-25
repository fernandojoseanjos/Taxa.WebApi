using Microsoft.OpenApi.Models;

namespace Taxa.WebApi
{
    internal class Info : OpenApiInfo
    {
        public string Title { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }
    }
}