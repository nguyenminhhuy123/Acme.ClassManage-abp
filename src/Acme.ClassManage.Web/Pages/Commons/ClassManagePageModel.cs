using Acme.ClassManage.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.ClassManage.Web.Pages.Commons;

/* Inherit your PageModel classes from this class.
 */
public abstract class ClassManagePageModel : AbpPageModel
{
    protected ClassManagePageModel()
    {
        LocalizationResourceType = typeof(ClassManageResource);
    }
}
