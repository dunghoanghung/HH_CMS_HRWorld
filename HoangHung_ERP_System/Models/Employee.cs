using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HoangHung_ERP_System.Models
{
    public class Employee
    {
        [Key]
        [Column(Order = 1)]
        public int EmployeeId { get; set; }

        [Required]
        [MaxLength(50)]
        public string EmployeeName { get; set; }

        [DefaultValue(false)]
        public Boolean Status { get; set; }

    }
}