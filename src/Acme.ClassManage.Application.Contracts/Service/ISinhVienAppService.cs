using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Acme.ClassManage.SinhVienDTO;
using Volo.Abp.Application.Services;
using System.Threading.Tasks;

namespace Acme.ClassManage.Services
{
    public interface ISinhVienAppService: 
    ICrudAppService< 
    ResponseSinhVien,Guid,PagedAndSortedResultRequestDto,RequestSinhVien,RequestSinhVien>
    {
       
        
       
        
    }
}
