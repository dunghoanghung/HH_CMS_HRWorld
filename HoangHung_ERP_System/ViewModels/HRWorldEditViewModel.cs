using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace HoangHung_ERP_System.ViewModels
{
    public class HRWorldEditViewModel
    {

        [Display(Name = "Mã Ứng viên")]
        public string Id { get; set; }

        [Required (ErrorMessage = "Tên ứng viên yêu cầu phải nhập.") ]
        [Display(Name = "Tên ứng viên")]
        [StringLength(50)]
        public string NameUngVien { get; set; }

        [Required(ErrorMessage = "Ngày sinh yêu cầu phải nhập.")]
        [Display(Name = "Ngày sinh")]
        public string NgaySinh { get; set; }


        [Display(Name = "Tỉnh thành phố")]
        public string SelectedCity { get; set; }
        public IEnumerable<SelectListItem> Cities { get; set; }

   
        [Display(Name = "Công ty")]
        public string SelectCompany { get; set; }
        public IEnumerable<SelectListItem> Companies { get; set; }

  
        [Display(Name = "Phòng ban")]
        public string SelectDepartment { get; set; }
        public IEnumerable<SelectListItem> Departments { get; set; }

  
        [Display(Name = "Cán bộ tuyển dụng")]
        public string SelectEmployee { get; set; }
        public IEnumerable<SelectListItem> Employees { get; set; }

        [Display(Name = "Người phụ trách job")]
        public string SelectJobmanager { get; set; }
        public IEnumerable<SelectListItem> Jobmanagers { get; set; }

    }
}