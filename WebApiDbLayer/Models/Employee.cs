using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiDbLayer.Models
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int employeeId { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? name { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        public string? address { get; set; }
        [Column(TypeName ="varchar(30)")]
        public string? companyName { get; set; }
        [Column(TypeName="varchar(50)")]
        public string? designation { get; set; }
    }
}
