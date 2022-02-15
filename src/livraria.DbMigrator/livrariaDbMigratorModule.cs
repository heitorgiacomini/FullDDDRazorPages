using livraria.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace livraria.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(livrariaEntityFrameworkCoreModule),
    typeof(livrariaApplicationContractsModule)
    )]
public class livrariaDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
