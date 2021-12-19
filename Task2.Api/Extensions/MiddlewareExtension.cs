using Microsoft.Extensions.DependencyInjection;
using Task2.Services.Implementations;
using Task2.Services.Interfaces;

namespace SchMgr.Api.Extension
{
    public static class MiddlewareExtension
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IPhoneService, PhoneService>();
        }
    }
}
