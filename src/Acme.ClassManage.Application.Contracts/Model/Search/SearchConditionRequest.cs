using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.ClassManage.Model.Search
{
    public class SearchConditionRequest : PagedAndSortedResultRequestDto
    {
        public string Keyword { get; set; }

        public  int MaxResultCount1 { get; set; }
        public int SkipCount1 { get; set; }


    }
}
