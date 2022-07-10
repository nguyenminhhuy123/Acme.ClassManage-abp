using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Acme.ClassManage.LopHocDTO;
using Acme.ClassManage.Services;

namespace Acme.ClassManage.Web.Pages.Commons.LopHoc
{
    public class CreateModalModel : ClassManagePageModel
    {
        [BindProperty]
        public RequestLopHoc LopHoc { get; set; }

        private readonly ILopHocAppService _classAppService;

        public CreateModalModel(ILopHocAppService classAppService)
        {
            _classAppService = classAppService;
        }

        public void OnGet()
        {
            LopHoc = new RequestLopHoc();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _classAppService.CreateAsync(LopHoc);
            return NoContent();
        }
    }
}
