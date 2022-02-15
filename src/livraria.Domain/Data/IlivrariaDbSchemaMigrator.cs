using System.Threading.Tasks;

namespace livraria.Data;

public interface IlivrariaDbSchemaMigrator
{
    Task MigrateAsync();
}
