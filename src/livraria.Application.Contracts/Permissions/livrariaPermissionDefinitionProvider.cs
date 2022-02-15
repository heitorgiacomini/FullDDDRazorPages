using livraria.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace livraria.Permissions;

public class livrariaPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        
        var livrariaGroup = context.AddGroup(livrariaPermissions.GroupName, L("Permission:Permission:BookStore"));

        var booksPermission = livrariaGroup.AddPermission(livrariaPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(livrariaPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(livrariaPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(livrariaPermissions.Books.Delete, L("Permission:Books.Delete"));

        var authorsPermission = livrariaGroup.AddPermission(livrariaPermissions.Authors.Default, L("Permission:Authors"));
        authorsPermission.AddChild(livrariaPermissions.Authors.Create, L("Permission:Authors.Create"));
        authorsPermission.AddChild(livrariaPermissions.Authors.Edit, L("Permission:Authors.Edit"));
        authorsPermission.AddChild(livrariaPermissions.Authors.Delete, L("Permission:Authors.Delete"));

        //Define your own permissions here. Example:
        //myGroup.AddPermission(livrariaPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<livrariaResource>(name);
    }
}

         
