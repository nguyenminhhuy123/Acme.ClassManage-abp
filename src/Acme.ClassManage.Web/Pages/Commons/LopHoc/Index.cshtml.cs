using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Acme.ClassManage.Web.Pages.Commons.LopHoc
{
    public class IndexModel : ClassManagePageModel
    {

        public virtual async void OngetAsync() { 
            await Task.CompletedTask;
        }

    }
}
