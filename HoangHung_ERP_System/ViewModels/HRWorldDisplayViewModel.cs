using System;
using System.ComponentModel.DataAnnotations;

namespace HoangHung_ERP_System.ViewModels
{
    public class HRWorldDisplayViewModel
    {

        [Display(Name = "Id")]
        public Int16 Id { get; set; }

        [Display(Name = "Tên ứng viên")]
        public string NameUngVien { get; set; }

        [Display(Name = "Ngày sinh")]
        public string NgaySinh { get; set; }


    }
}