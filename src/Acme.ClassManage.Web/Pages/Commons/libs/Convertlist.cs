using Acme.ClassManage.LopHocDTO;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Acme.ClassManage.Web.Pages.Commons.libs
{
    public class Convertlist : IConvertlist
    {
        public List<SelectListItem> Converselectlist(PagedResultDto<ResponseLopHoc> responseLopHoc ,string defaultname)
        {
            List<SelectListItem> LopHocList =new List<SelectListItem>();

            
            if (responseLopHoc.TotalCount == 0)
            {
                defaultname = "chua co lop hoc nao";
            }
            LopHocList.Add(new SelectListItem
            {
                Value = "",
                Text = defaultname,
                Selected = true

            });
            foreach (var item in responseLopHoc.Items)
            {
                LopHocList.Add(new SelectListItem
                {
                    Value = item.Id.ToString(),
                    Text = item.name,
                 

                });
            }





            return LopHocList;
        }

    }
}
