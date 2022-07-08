using System.Threading.Tasks;

namespace Acme.ClassManage.Data;

public interface IClassManageDbSchemaMigrator
{
    Task MigrateAsync();
}
