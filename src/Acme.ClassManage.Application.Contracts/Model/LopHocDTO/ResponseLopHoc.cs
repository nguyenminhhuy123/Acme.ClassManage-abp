using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.ClassManage.LopHocDTO
{
    public class ResponseLopHoc : EntityDto<Guid>
    {
        public string name { get; set; }

        public string GhiChu { get; set; }

    }
}
