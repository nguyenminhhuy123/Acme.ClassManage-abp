using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Acme.ClassManage.LopHocDTO
{
    public class RequestLopHoc
    {
        [Required(ErrorMessage ="lacking name of class")]
        [StringLength(255)]
        [Display(Name ="name",Prompt ="PlaceHolder")]
        public string name { get; set; }

        [Required(ErrorMessage = "lacking note of class")]
        [StringLength(1000)]
        [Display(Name = "ghichu", Prompt = "PlaceHolder")]
        public string ghichu { get; set; }
    }
}
