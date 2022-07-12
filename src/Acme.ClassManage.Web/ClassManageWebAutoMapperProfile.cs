using Acme.ClassManage.SinhVienDTO;
using AutoMapper;
using static Acme.ClassManage.Web.Pages.Commons.SinhVien.Editmodal;

namespace Acme.ClassManage.Web;

public class ClassManageWebAutoMapperProfile : Profile
{
    public ClassManageWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        CreateMap<RequestSinhVienModal, RequestSinhVien>();
    }
}
