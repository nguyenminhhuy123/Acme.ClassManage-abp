using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;
using Volo.Abp.Application.Dtos;
using Acme.ClassManage.LopHocDTO;
using System.Threading.Tasks;
using Acme.ClassManage.Model.Search;

namespace Acme.ClassManage.Services
{
    public interface ILopHocAppService :
    ICrudAppService<
    ResponseLopHoc,Guid,PagedAndSortedResultRequestDto,RequestLopHoc,RequestLopHoc>
    {
        Task<PagedResultDto<ResponseLopHoc>> SearchAsync(SearchConditionRequest searchConditionRequest);
    }
}
