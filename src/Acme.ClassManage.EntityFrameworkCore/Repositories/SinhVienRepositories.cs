using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.ClassManage.Entities.Commons;
using Acme.ClassManage.EntityFrameworkCore;
using Acme.ClassManage.Repositories;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Acme.ClassManage.Repositories
{
    public class SinhVienRepositories : EfCoreRepository<ClassManageDbContext, SinhVien, Guid>, ISinhVienRepositories
    {
        public SinhVienRepositories(IDbContextProvider<ClassManageDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<PagedResultDto<SinhVien>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            PagedResultDto<SinhVien> list = new PagedResultDto<SinhVien>();
            list.TotalCount = await GetQueryable().Where(w => !w.IsDeleted).CountAsync(); 
            list.Items = await GetQueryable().Where(w => !w.IsDeleted).Include(t => t.lophoc).OrderByDescending(w=>w.CreationTime )
                .ThenByDescending(w => w.LastModificationTime)
                .Skip(input.SkipCount).Take(input.MaxResultCount).AsNoTracking().ToListAsync();


            return list;

        }
    }
}
