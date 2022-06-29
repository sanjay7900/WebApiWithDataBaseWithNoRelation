using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiDbLayer.Models
{
    public class Students
    {
     
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }
        [Column(TypeName="varchar(50)")]
        public string? name { get; set; }
        [Column(TypeName = "char(50)")]
        public string? courseName { get; set; }
        [Column(TypeName ="nvarchar(60)")]
        public string? address { get; set; }

    }
}
