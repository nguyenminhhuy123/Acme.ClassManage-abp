using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Acme.ClassManage.Web;

[Dependency(ReplaceServices = true)]
public class ClassManageBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ClassManage";
}
