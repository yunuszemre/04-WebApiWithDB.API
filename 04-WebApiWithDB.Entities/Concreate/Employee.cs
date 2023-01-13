using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_WebApiWithDB.Entities.Concreate
{
    public class Employee
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(75)] //Maxlenght ile aynı işi yapar ---> minimum ve maximum aralık verilebilir
        [Required]
        public string LastName { get; set; }

        [StringLength(75)]
        public string Department { get; set; }

    }
}
