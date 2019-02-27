using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HoangHung_ERP_System.Models
{
    public class Jobmanager
    {

        [Key]
        [Column(Order = 1)]
        public int JobmanageId { get; set; }

        [Required]
        [MaxLength(50)]
        public string JobmanageName { get; set; }

        [DefaultValue(false)]
        public Boolean Status { get; set; }
    }
}