using Acme.ClassManage.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace Acme.ClassManage.Repositories
{
    public interface ISinhVienRepositories : IRepository<SinhVien,Guid>
    {
        Task<PagedResultDto<SinhVien>> GetListAsync(PagedAndSortedResultRequestDto input);
    }
}
