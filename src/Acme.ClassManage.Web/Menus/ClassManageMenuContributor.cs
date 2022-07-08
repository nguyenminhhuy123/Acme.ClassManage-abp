using System.Threading.Tasks;
using Acme.ClassManage.Localization;
using Acme.ClassManage.MultiTenancy;
using Acme.ClassManage.Permissions;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Acme.ClassManage.Web.Menus;

public class ClassManageMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<ClassManageResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                ClassManageMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );
        context.Menu.AddItem(new ApplicationMenuItem("TongQuan", "Tổng Quan", url: "/#", icon: "fa fa-singal", order: 1, cssClass: "tongQuan"));

        var lopHoc = await context.IsGrantedAsync(ClassManagePermissions.LopHoc.Default);
        if (lopHoc)
        {
            context.Menu.AddItem(new ApplicationMenuItem("LopHoc", "Lớp Học", icon: "fa fa-circle", order: 2, url: "/Commons/LopHoc"));
        }

        var sinhVien = await context.IsGrantedAsync(ClassManagePermissions.SinhVien.Default);
        if (lopHoc)
        {
            context.Menu.AddItem(new ApplicationMenuItem("SinhVien", "Sinh Viên", icon: "fa fa-users", order: 3, url: "/Commons/SinhVien"));
        }



        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);
    }
}
