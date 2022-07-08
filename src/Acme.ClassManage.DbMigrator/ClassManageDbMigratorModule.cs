using Acme.ClassManage.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Acme.ClassManage.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ClassManageEntityFrameworkCoreModule),
    typeof(ClassManageApplicationContractsModule)
    )]
public class ClassManageDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
