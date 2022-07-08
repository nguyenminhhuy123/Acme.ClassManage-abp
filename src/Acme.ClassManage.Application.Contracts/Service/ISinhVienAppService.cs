using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Acme.BookStore.SinhVienDTO;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Services
{
    public interface ISinhVienAppService: 
    ICrudAppService< 
    ResponseSinhVien,Guid,PagedAndSortedResultRequestDto,RequestSinhVien,RequestSinhVien>
    {

    }
}
