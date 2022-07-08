using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.ClassManage.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.ClassManage.EntityFrameworkCore;

public class EntityFrameworkCoreClassManageDbSchemaMigrator
    : IClassManageDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreClassManageDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the ClassManageDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ClassManageDbContext>()
            .Database
            .MigrateAsync();
    }
}
