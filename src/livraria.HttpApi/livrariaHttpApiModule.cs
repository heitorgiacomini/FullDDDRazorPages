using Localization.Resources.AbpUi;
using livraria.Localization;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using Microsoft.AspNetCore.Mvc.RazorPages;
using livraria.Permissions;
using Microsoft.Extensions.DependencyInjection;

namespace livraria;

[DependsOn(
    typeof(livrariaApplicationContractsModule),
    typeof(AbpAccountHttpApiModule),
    typeof(AbpIdentityHttpApiModule),
    typeof(AbpPermissionManagementHttpApiModule),
    typeof(AbpTenantManagementHttpApiModule),
    typeof(AbpFeatureManagementHttpApiModule),
    typeof(AbpSettingManagementHttpApiModule)
    )]
public class livrariaHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
        //Configure<RazorPagesOptions>(options =>
        //{
        //    options.Conventions.AuthorizePage("/Authors/Index", livrariaPermissions.Authors.Default);
        //    options.Conventions.AuthorizePage("/Authors/CreateModal", livrariaPermissions.Authors.Create);
        //    options.Conventions.AuthorizePage("/Authors/EditModal", livrariaPermissions.Authors.Edit);
        //});
        //Configure<RazorPagesOptions>(options =>
        //{
        //    options.Conventions.AuthorizePage("/Books/Index", livrariaPermissions.Authors.Default);
        //    options.Conventions.AuthorizePage("/Books/CreateModal", livrariaPermissions.Authors.Create);
        //    options.Conventions.AuthorizePage("/Books/EditModal", livrariaPermissions.Authors.Edit);
        //});
    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<livrariaResource>()
                .AddBaseTypes(
                    typeof(AbpUiResource)
                );
        });
    }
}
