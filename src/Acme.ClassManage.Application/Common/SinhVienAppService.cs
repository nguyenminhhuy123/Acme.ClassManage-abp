using Acme.ClassManage.Entities.Commons;
using Acme.ClassManage.SinhVienDTO;
using Acme.ClassManage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.ClassManage.Common
{
    public class SinhVienAppService :
        CrudAppService<SinhVien, ResponseSinhVien, Guid, PagedAndSortedResultRequestDto,
        RequestSinhVien, RequestSinhVien>, ISinhVienAppService
    {
        public SinhVienAppService(IRepository<SinhVien, Guid> repository) : base(repository)
        {
        }
    }
}
