using Acme.ClassManage.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.ClassManage;

[DependsOn(
    typeof(ClassManageEntityFrameworkCoreTestModule)
    )]
public class ClassManageDomainTestModule : AbpModule
{

}
