using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;
using Volo.Abp.Application.Dtos;
using Acme.BookStore.LopHocDTO;

namespace Acme.BookStore.Services
{
    public interface ILopHocAppService :
    ICrudAppService<
    ResponseLopHoc,Guid,PagedAndSortedResultRequestDto,RequestLopHoc,RequestLopHoc>
    {

    }
}
