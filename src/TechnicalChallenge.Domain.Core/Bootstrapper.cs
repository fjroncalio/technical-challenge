using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace TechnicalChallenge.Domain.Core
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddDomainContext(this IServiceCollection services)
        {
            services.AddMediatR(AppDomain.CurrentDomain.Load("TechnicalChallenge.Domain"));

            return services;
        }
    }
}