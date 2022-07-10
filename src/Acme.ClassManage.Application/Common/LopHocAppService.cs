using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Acme.ClassManage.Entities.Commons;
using Acme.ClassManage.LopHocDTO;
using Acme.ClassManage.Services;
using Volo.Abp.Domain.Repositories;


namespace Acme.ClassManage.Common
{
    public class LopHocAppService : 
        CrudAppService<Acme.ClassManage.Entities.Commons.LopHoc, ResponseLopHoc, Guid, PagedAndSortedResultRequestDto,
        RequestLopHoc, RequestLopHoc>, ILopHocAppService

    {
        public LopHocAppService(IRepository<Acme.ClassManage.Entities.Commons.LopHoc, Guid> repository) : base(repository)
        {
        }

        

    }
}
