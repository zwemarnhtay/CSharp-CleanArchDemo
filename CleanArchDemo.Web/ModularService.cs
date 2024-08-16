using CleanArchDemo.Application.Interfaces;
using CleanArchDemo.Application.Services;
using CleanArchDemo.Domain.Entities;
using CleanArchDemo.Domain.Interfaces;
using CleanArchDemo.Infrastructure.Repositories;

namespace CleanArchDemo.Web;

public static class ModularService
{
  public static IServiceCollection AddServices(this IServiceCollection services)
  {
    services.AddApplicationServices();
    services.AddInfrastructureServices();
    return services;
  }

  public static IServiceCollection AddApplicationServices(this IServiceCollection services)
  {
    services.AddScoped<IUserService, UserService>();
    return services;
  }

  public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
  {
    services.AddScoped<IRepository<User>, UserRepository>();
    return services;
  }
}
