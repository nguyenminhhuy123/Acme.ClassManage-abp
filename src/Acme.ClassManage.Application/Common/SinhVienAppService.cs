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
using Acme.ClassManage.LopHocDTO;
using Microsoft.AspNetCore.Mvc;
using Acme.ClassManage.Repositories;

namespace Acme.ClassManage.Common
{
    public class SinhVienAppService :
        CrudAppService<SinhVien, ResponseSinhVien, Guid, PagedAndSortedResultRequestDto,
        RequestSinhVien, RequestSinhVien>, ISinhVienAppService
    {
        private readonly ISinhVienRepositories _sinhVienRepositories;
       
        public SinhVienAppService(IRepository<SinhVien, Guid> repository , ISinhVienRepositories sinhVienRepositories) : base(repository)
        {
            _sinhVienRepositories = sinhVienRepositories;


        }
        public async override Task<PagedResultDto<ResponseSinhVien>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            PagedResultDto<SinhVien> listsv = await _sinhVienRepositories.GetListAsync(input);

            List<ResponseSinhVien> result = new List<ResponseSinhVien>();
            foreach (var item in listsv.Items)
            {
                var maplist = ObjectMapper.Map<SinhVien, ResponseSinhVien>(item);
                maplist.namelophoc = item.lophoc == null ? "" : item.lophoc.name;
                result.Add(maplist);
            }


            return new PagedResultDto<ResponseSinhVien>(listsv.TotalCount,result);
        } 


    }
}
