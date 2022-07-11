using Acme.ClassManage.Entities.Commons;
using Acme.ClassManage.LopHocDTO;
using Acme.ClassManage.SinhVienDTO;
using AutoMapper;

namespace Acme.ClassManage;

public class ClassManageApplicationAutoMapperProfile : Profile
{
    public ClassManageApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        //sinh vien
        CreateMap<SinhVien, ResponseSinhVien>();
        CreateMap<RequestSinhVien, SinhVien>();
        CreateMap<ResponseSinhVien, RequestSinhVien>();


        //lop hoc
        CreateMap<LopHoc, ResponseLopHoc>();
        CreateMap<RequestLopHoc, LopHoc>();
        CreateMap<ResponseLopHoc, RequestLopHoc>();
    }
}
