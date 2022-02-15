using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using livraria.Data;
using Volo.Abp.DependencyInjection;

namespace livraria.EntityFrameworkCore;

public class EntityFrameworkCorelivrariaDbSchemaMigrator
    : IlivrariaDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCorelivrariaDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the livrariaDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<livrariaDbContext>()
            .Database
            .MigrateAsync();
    }
}
