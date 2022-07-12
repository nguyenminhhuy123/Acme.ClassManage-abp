using Acme.ClassManage.LopHocDTO;
using Acme.ClassManage.Web.Pages.Commons.libs.DTO_convert;
using Microsoft.AspNetCore.Mvc.Rendering;

using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Acme.ClassManage.Web.Pages.Commons.libs
{
    public class Convertlist : IConvertlist
    {
        public List<SelectListItem> Converselectlist(PagedResultDto<ResponseLopHoc> responseLopHoc , Nameselectitem defaultname)
        {
        
      
            List<SelectListItem> LopHocList =new List<SelectListItem>();


            if (defaultname.defaultname != null)
            {
                LopHocList.Add(iTem("",defaultname.defaultname,true));
            }

           
            foreach (var item in responseLopHoc.Items)
            {
                if (defaultname.id == item.Id)
                {

                    LopHocList.AddFirst(iTem(item.Id.ToString(),item.name,true));

                }
                else
                {
                    LopHocList.Add(iTem(item.Id.ToString(), item.name, false));
                }

               

            }
            return LopHocList;
        }

        public SelectListItem iTem(string value,string text,bool _selected)
        {
         
                return new SelectListItem
                {
                    Value = value,
                    Text = text,
                    Selected =_selected
                };
            


        }

    }
}
