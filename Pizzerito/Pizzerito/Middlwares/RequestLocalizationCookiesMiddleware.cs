using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzerito.Middlwares
{
    public class RequestLocalizationCookiesMiddleware
    {
        public CookieRequestCultureProvider Provider { get; }
        private readonly RequestDelegate next;
        public RequestLocalizationCookiesMiddleware(IOptions<RequestLocalizationOptions>
            requestLocalizationOptions, RequestDelegate next)
        {
            this.next = next;
            Provider =
                requestLocalizationOptions
                    .Value
                    .RequestCultureProviders
                    .Where(x => x is CookieRequestCultureProvider)
                    .Cast<CookieRequestCultureProvider>()
                    .FirstOrDefault();
        }
        public async Task InvokeAsync(HttpContext context)
        {
            if (Provider != null)
            {
                var feature = context.Features.Get<IRequestCultureFeature>();

                if (feature != null)
                {
                    // remember culture across request
                    context.Response
                        .Cookies
                        .Append(Provider.CookieName,
                        CookieRequestCultureProvider
                        .MakeCookieValue(feature.RequestCulture));
                }
            }
            await next(context);
        }
    }
}
