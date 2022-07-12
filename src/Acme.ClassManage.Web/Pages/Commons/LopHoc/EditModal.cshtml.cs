using Acme.ClassManage.LopHocDTO;
using Acme.ClassManage.Services;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Threading.Tasks;

namespace Acme.ClassManage.Web.Pages.Commons.LopHoc
{
    public class EditModal : ClassManagePageModel

    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public RequestLopHoc LopHoc { get; set; }

        private readonly ILopHocAppService _classAppService;

        public EditModal(ILopHocAppService classAppService)
        {
            _classAppService = classAppService;
        }

        public async Task OnGetAsync()
        {
            var responedto = await _classAppService.GetAsync(Id);
            LopHoc = ObjectMapper.Map<ResponseLopHoc, RequestLopHoc>(responedto);
         
           

           
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _classAppService.UpdateAsync(Id, LopHoc);
            return NoContent();
        }
    }
}
