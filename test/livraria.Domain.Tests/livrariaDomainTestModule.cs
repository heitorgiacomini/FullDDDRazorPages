using livraria.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace livraria;

[DependsOn(
    typeof(livrariaEntityFrameworkCoreTestModule)
    )]
public class livrariaDomainTestModule : AbpModule
{

}
