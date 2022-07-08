using System;
using System.Collections.Generic;
using System.Text;
using Acme.ClassManage.Localization;
using Volo.Abp.Application.Services;

namespace Acme.ClassManage;

/* Inherit your application services from this class.
 */
public abstract class ClassManageAppService : ApplicationService
{
    protected ClassManageAppService()
    {
        LocalizationResource = typeof(ClassManageResource);
    }
}
