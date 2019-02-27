using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HoangHung_ERP_System.Models
{
    public class City
    {

        [Key]
        [Column(Order = 1)]
        public int CityId { get; set; }

        [Required]
        [MaxLength(50)]
        public string CityName { get; set; }

        public int SortOrder { get; set; }

        public bool Status { get; set; }



    }
}