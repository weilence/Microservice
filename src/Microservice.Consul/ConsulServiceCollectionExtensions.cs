﻿using Consul;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Microservice.Consul
{
    public static class ConsulServiceCollectionExtensions
    {
        public static IServiceCollection AddConsul(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ConsulConfig>(configuration);
            services.AddSingleton<IConsulClient, ConsulClient>();
            services.AddHostedService<ConsulAgent>();

            return services;
        }
    }
}