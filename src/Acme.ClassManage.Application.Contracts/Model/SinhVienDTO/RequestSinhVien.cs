using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.SinhVienDTO
{
    public class RequestSinhVien
    {
        [Required(ErrorMessage ="lackname")]
        [StringLength(255)]
        [Display(Name ="SinhVienName",Prompt ="PlaceHolder")]

        public string name { get; set; }

        [Required(ErrorMessage ="lackage")]
        [Display(Name ="tuoi sinh vien" ,Prompt ="PlaceHolder")]
        
        public int tuoi { get; set; }

        [Required(ErrorMessage ="LackCMND")]
        [StringLength (20)]
        [Display(Name = "CMND",Prompt ="PlaceHolder")]
        public string CMND { get; set; }

        [Required(ErrorMessage ="Requried")]
        public virtual Guid BophanID { get; set; }
    }
}
