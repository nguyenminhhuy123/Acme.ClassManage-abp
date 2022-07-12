using Acme.ClassManage.LopHocDTO;
using Acme.ClassManage.Web.Pages.Commons.libs.DTO_convert;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Acme.ClassManage.Web.Pages.Commons.libs
{
    public interface IConvertlist
    {
        public List<SelectListItem> Converselectlist(PagedResultDto<ResponseLopHoc> responseLopHoc, Nameselectitem defaultname);
    }
}
