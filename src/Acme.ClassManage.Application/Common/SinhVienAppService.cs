using Acme.BookStore.Entities.Commons;
using Acme.BookStore.SinhVienDTO;
using Acme.BookStore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Common
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
