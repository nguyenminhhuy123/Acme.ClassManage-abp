using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.ClassManage.Entities.Commons
{
    public class SinhVien:FullAuditedAggregateRoot<Guid>
    {
        public string name { get; set; }

        public int tuoi { get; set; }

        public string CMND { get; set; }

        public Guid lophocID { get; set; }

        public LopHoc lophoc { get; set; }

    }
}
