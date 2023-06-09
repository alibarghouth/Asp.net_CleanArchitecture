﻿using CleanArchitecture.Domain.Shared;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Application.Configurations;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var assemblies = typeof(DependencyInjection).Assembly;
        services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(assemblies));
        services.AddValidatorsFromAssembly(assemblies);

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        
        return services;
    }
}