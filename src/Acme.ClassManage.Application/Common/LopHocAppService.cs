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
using Acme.ClassManage.Model.Search;
using Microsoft.AspNetCore.Mvc;

namespace Acme.ClassManage.Common
{
    public class LopHocAppService : 
        CrudAppService<Acme.ClassManage.Entities.Commons.LopHoc, ResponseLopHoc, Guid, PagedAndSortedResultRequestDto,
        RequestLopHoc, RequestLopHoc>, ILopHocAppService

    {
        public LopHocAppService(IRepository<Acme.ClassManage.Entities.Commons.LopHoc, Guid> repository) : base(repository)
        {
        }

        [HttpGet]
        public async Task<PagedResultDto<ResponseLopHoc>> SearchAsync(string searchConditionRequest)
        {
            var input = new PagedAndSortedResultRequestDto { MaxResultCount = 1000, SkipCount = 0 };
            if(searchConditionRequest== null)
            {
                searchConditionRequest = "";
            }
            PagedResultDto<ResponseLopHoc> listresultDto = new PagedResultDto<ResponseLopHoc>();
            var list = this.GetListAsync(input).Result;
            var resultSearch = list.Items.Where(x => x.name.Contains(searchConditionRequest));
            listresultDto.TotalCount = resultSearch.Count();
            listresultDto.Items = resultSearch.Skip(0).Take(10)
                .ToList();


            return listresultDto;
        }
    }
}
