using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Models
{
    public class Student
    {
        [Key]
    
        public int id { get; set; }
        [Column( TypeName ="nvarchar(225)")]
        [Required]
        public string fullname { get; set; }
        [Column(TypeName = "varchar(25)")]
        public string code { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public int Niveau { get; set; }
}
}
