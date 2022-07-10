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

namespace Acme.ClassManage.Common
{
    public class SinhVienAppService :
        CrudAppService<SinhVien, ResponseSinhVien, Guid, PagedAndSortedResultRequestDto,
        RequestSinhVien, RequestSinhVien>, ISinhVienAppService
    {
        public ILopHocAppService _lopHocAppService { get; set; }
        public SinhVienAppService(IRepository<SinhVien, Guid> repository, ILopHocAppService lopHocAppService) : base(repository)
        {
            _lopHocAppService = lopHocAppService;
        }

        [HttpGet]
        public override async  Task<PagedResultDto<ResponseSinhVien>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
         
            PagedResultDto<ResponseSinhVien> listsinhvien =  this.GetListAsync(input).Result;

         


            foreach (var item in listsinhvien.Items)
            {

                item.namelophoc =  _lopHocAppService.GetAsync(item.Id).Result.name;
            }


            return listsinhvien;
            
        }
    }
}
