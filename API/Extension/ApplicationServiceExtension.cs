
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Repository;
using Infrastructure.UnitOfWork;
using Microsoft.EntityFrameworkCore;
namespace API.Extension;

public static class ApplicationServiceExtension
{
    public static void ConfigureCors(this IServiceCollection service){
        service.AddCors(e => {
            e.AddPolicy("CorsPolicy", f => {
                f.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            });
        });
    }
    public static void AddAplicationService(this IServiceCollection services){
        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}
