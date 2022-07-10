using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;
using Volo.Abp.Application.Dtos;
using Acme.ClassManage.LopHocDTO;

namespace Acme.ClassManage.Services
{
    public interface ILopHocAppService :
    ICrudAppService<
    ResponseLopHoc,Guid,PagedAndSortedResultRequestDto,RequestLopHoc,RequestLopHoc>
    {

    }
}
