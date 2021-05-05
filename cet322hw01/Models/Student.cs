using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cet322hw01.Models
{
    public class Student
    {
        public int Id { get; set; }
        [DisplayName("Ad")]
        [Required]
        public string Name { get; set; }
        [DisplayName("Soyad")]
        [Required]
        public string Surname { get; set; }
        [DisplayName("Bölüm")]
        public string? Departmant { get; set; } //opt
        [DisplayName("Doğum Tarihi")]
        [Required]
       
        public DateTime BirthDate { get; set; }
        [DisplayName("Boy")]
        public decimal? Height { get; set; } //opt
        [DisplayName("Kilo")]
        public decimal? Weight { get; set; } //opt
        
        public DateTime CreationDate { get; set; }
       
        public DateTime LastUpdateDate { get; set; }
        public int Age;
        
       


    }
}
