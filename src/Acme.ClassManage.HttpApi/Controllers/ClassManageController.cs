using Acme.ClassManage.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.ClassManage.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ClassManageController : AbpControllerBase
{
    protected ClassManageController()
    {
        LocalizationResource = typeof(ClassManageResource);
    }
}
