using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Model
{
    internal class CustomerInformation
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(10)]
        public string Gender{ get; set; }
        [Required]
        [Column(TypeName ="datetime2")]
        public DateTime Dob { get; set; }
        [Required, MaxLength(20)]
        public string Nationality { get; set; }
        [Required,MaxLength(100)]
        public string Address{ get; set; }
        [Required,MaxLength(20)]
        public string PhoneNumber { get; set; }
        [Required,MaxLength(50)]
        public string Email { get; set; }
        [Required,MaxLength(20)]
        public string Occupation { get; set; }
    }
}
