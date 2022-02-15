using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace livraria.Data;

/* This is used if database provider does't define
 * IlivrariaDbSchemaMigrator implementation.
 */
public class NulllivrariaDbSchemaMigrator : IlivrariaDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
