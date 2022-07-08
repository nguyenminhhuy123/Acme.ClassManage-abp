using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Acme.BookStore.Entities.Commons;
using Acme.BookStore.LopHocDTO;
using Acme.BookStore.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Common
{
    public class LopHocAppService : 
        CrudAppService<LopHoc, ResponseLopHoc, Guid, PagedAndSortedResultRequestDto,
        RequestLopHoc, RequestLopHoc>, ILopHocAppService

    {
        public LopHocAppService(IRepository<LopHoc, Guid> repository) : base(repository)
        {
        }

        

    }
}
