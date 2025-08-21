using Acme.BookStore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Acme.BookStore.Permissions;

public class BookStorePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BookStorePermissions.GroupName);


        var todoPermission = myGroup.AddPermission(BookStorePermissions.Todo.Default, L("Permission:Default"));
        todoPermission.AddChild(BookStorePermissions.Todo.Create, L("Permission:Create"));
        todoPermission.AddChild(BookStorePermissions.Todo.Update, L("Permission:Update"));
        todoPermission.AddChild(BookStorePermissions.Todo.Delete, L("Permission:Delete"));

        //Define your own permissions here. Example:
        //myGroup.AddPermission(BookStorePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BookStoreResource>(name);
    }
}
