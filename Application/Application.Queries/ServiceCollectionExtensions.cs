﻿using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Queries;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationQueryServices(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        return services;
    }
}