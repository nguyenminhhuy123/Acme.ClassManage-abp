using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.ClassManage.Model.Search
{
    public class SearchConditionRequest
    {
        public string Keyword { get; set; }
        public int SkipCount { get; set; }
        public int MaxResultCount { get; set; }
    }
}
