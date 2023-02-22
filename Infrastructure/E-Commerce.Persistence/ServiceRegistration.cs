using E_Commerce.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace E_Commerce.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceService(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>(builder =>
        {
            builder.UseNpgsql("User ID = root; Password = myPassword; Host = localhost; Port = 5432; Database = myDataBase;");
        });
    }
}
