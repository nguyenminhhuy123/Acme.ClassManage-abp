using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.ClassManage.Data;

/* This is used if database provider does't define
 * IClassManageDbSchemaMigrator implementation.
 */
public class NullClassManageDbSchemaMigrator : IClassManageDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
