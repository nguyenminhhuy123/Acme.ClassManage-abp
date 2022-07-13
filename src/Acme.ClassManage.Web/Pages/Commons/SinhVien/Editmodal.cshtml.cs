using Acme.ClassManage.Services;
using Acme.ClassManage.SinhVienDTO;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
using Acme.ClassManage.LopHocDTO;
using Acme.ClassManage.Web.Pages.Commons.libs;
using Acme.ClassManage.Web.Pages.Commons.libs.ConvertInfor;

namespace Acme.ClassManage.Web.Pages.Commons.SinhVien
{
    public class Editmodal : ClassManagePageModel
    {

        public readonly ISinhVienAppService _sinhVienAppService;
        public readonly ILopHocAppService _lopHocAppService;
        public  IConvertlist _convertlist;
        public Editmodal(ISinhVienAppService sinhVienAppService, ILopHocAppService lopHocAppService)
        {
            _sinhVienAppService = sinhVienAppService;
            _lopHocAppService = lopHocAppService;
           
        } 
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public RequestSinhVienModal requestSinhVienModal { get; set; }
        public List<SelectListItem> listlophoc { get; set; }
        public async Task OnGetAsync()
        {
         
            
            _convertlist = new Convertlist();
            PagedAndSortedResultRequestDto input = new PagedAndSortedResultRequestDto
            {
                MaxResultCount = 1000
            };
            PagedResultDto<ResponseLopHoc> listlophocrespone = await _lopHocAppService.GetListAsync(input);
          
      
            requestSinhVienModal = new RequestSinhVienModal();

            ResponseSinhVien responsesinhvien = await _sinhVienAppService.GetAsync(Id);
            requestSinhVienModal = ObjectMapper.Map<ResponseSinhVien, RequestSinhVienModal>(responsesinhvien);
          

            Nameselectitem nameselectitem = new Nameselectitem();
            nameselectitem.id = responsesinhvien.lophocID;
            listlophoc = _convertlist.Converselectlist(listlophocrespone, nameselectitem);


        }

        public async Task<IActionResult> OnPostAsync()
        {
            RequestSinhVien requestSinhVien = ObjectMapper.Map<RequestSinhVienModal, RequestSinhVien>(requestSinhVienModal);   
            await _sinhVienAppService.UpdateAsync(Id, requestSinhVien);
            return NoContent();
        }

        public class RequestSinhVienModal : RequestSinhVien
        {
            [SelectItems(nameof(listlophoc))]
            [Display(Name ="lop hoc")]
            public override Guid lopHocID { get; set; } 

        }

    }
}
