using Volo.Abp.Modularity;

namespace Acme.ClassManage;

[DependsOn(
    typeof(ClassManageApplicationModule),
    typeof(ClassManageDomainTestModule)
    )]
public class ClassManageApplicationTestModule : AbpModule
{

}
