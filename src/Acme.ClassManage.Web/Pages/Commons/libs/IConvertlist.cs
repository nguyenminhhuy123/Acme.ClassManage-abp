using Acme.ClassManage.LopHocDTO;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Acme.ClassManage.Web.Pages.Commons.libs
{
    public interface IConvertlist
    {
        public List<SelectListItem> Converselectlist(PagedResultDto<ResponseLopHoc> responseLopHoc,string defaultname);
    }
}
