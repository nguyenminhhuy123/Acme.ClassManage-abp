using Acme.ClassManage.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.ClassManage.Permissions;

public class ClassManagePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ClassManagePermissions.GroupName);
        var myGroupCommon = context.AddGroup(ClassManagePermissions.GroupNameCommon, L("Permission:Common"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BookStorePermissions.MyPermission1, L("Permission:MyPermission1"));



        var PermissionLopHoc = myGroupCommon.AddPermission(ClassManagePermissions.LopHoc.Default, L("Permission:LopHoc"));
        PermissionLopHoc.AddChild(ClassManagePermissions.LopHoc.Create, L("Permission:Create"));
        PermissionLopHoc.AddChild(ClassManagePermissions.LopHoc.Update, L("Permission:Update"));
        PermissionLopHoc.AddChild(ClassManagePermissions.LopHoc.Delete, L("Permission:Delete"));


        var PermissionSinhVien = myGroupCommon.AddPermission(ClassManagePermissions.SinhVien.Default, L("Permission:SinhVien"));
        PermissionSinhVien.AddChild(ClassManagePermissions.SinhVien.Create, L("Permission:Create"));
        PermissionSinhVien.AddChild(ClassManagePermissions.SinhVien.Update, L("Permission:Update"));
        PermissionSinhVien.AddChild(ClassManagePermissions.SinhVien.Delete, L("Permission:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ClassManageResource>(name);
    }
}
