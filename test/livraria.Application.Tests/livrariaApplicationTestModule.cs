using Volo.Abp.Modularity;

namespace livraria;

[DependsOn(
    typeof(livrariaApplicationModule),
    typeof(livrariaDomainTestModule)
    )]
public class livrariaApplicationTestModule : AbpModule
{

}
