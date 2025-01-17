using Mediachase.Commerce.Anonymous;

namespace Foundation
{
    public class AnonymousIdFeature : IAnonymousIdFeature
    {
        private readonly RequestDelegate _next;

        public AnonymousIdFeature(RequestDelegate next) => _next = next;

        public string AnonymousId { get; set; }

        public async Task InvokeAsync(HttpContext context)
        {
            await _next(context);
        }
    }
}
