using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.ClassManage.SinhVienDTO
{
    public class ResponseSinhVien:EntityDto<Guid>
    {
        public string name { get; set; }

        public int tuoi { get; set; }

        public string CMND { get; set; }

        public string bophan { get; set; }
    }
}
