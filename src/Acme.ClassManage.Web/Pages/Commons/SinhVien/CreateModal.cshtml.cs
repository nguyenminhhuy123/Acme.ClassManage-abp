using Acme.ClassManage.Services;
using Acme.ClassManage.SinhVienDTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
using Volo.Abp.Application.Dtos;
using Acme.ClassManage.Web.Pages.Commons.libs;
using Acme.ClassManage.LopHocDTO;
using Acme.ClassManage.Web.Pages.Commons.libs.DTO_convert;

namespace Acme.ClassManage.Web.Pages.Commons.SinhVien
{
    public class CreateModal : ClassManagePageModel
    {
        [BindProperty]
        public SinhvienModal sinhvien { get; set; }

        public List<SelectListItem> LopHocList { get; set; }
        public IConvertlist convertlist { get; set; }


        public readonly ILopHocAppService _lophocappservice;
        public readonly ISinhVienAppService _sinhvienappservice;
        public CreateModal(ISinhVienAppService sinhvienappservice, ILopHocAppService lophocappservice)
        {
            _sinhvienappservice = sinhvienappservice;
            _lophocappservice = lophocappservice;
        }
        public virtual async Task OnGetAsync()
        {
            Nameselectitem nameselectitem = new Nameselectitem();
            nameselectitem.defaultname = "CHON LOP";
            PagedResultDto<ResponseLopHoc> adw = await _lophocappservice.GetListAsync(new PagedAndSortedResultRequestDto
            {
                MaxResultCount = 1000
            });
            convertlist = new Convertlist();
            LopHocList = convertlist.Converselectlist(adw, nameselectitem);
                
          
       
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            await _sinhvienappservice.CreateAsync(sinhvien);
            return NoContent();
        }
    

        public class SinhvienModal : RequestSinhVien
        {
            [SelectItems(nameof(LopHocList))]
            [Display(Name = "Lop hoc")]
            public override Guid lopHocID { get; set; }



        }
    }
}
