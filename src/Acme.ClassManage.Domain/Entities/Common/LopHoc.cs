using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.ClassManage.Entities.Commons
{
    public class LopHoc: FullAuditedAggregateRoot<Guid>
    {
        public string name { get; set; }
        public string ghichu { get; set; }

        public List<SinhVien> sinhvien { get; set; }
    }
}
