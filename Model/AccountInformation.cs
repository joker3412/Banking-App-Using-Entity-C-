using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Model
{
    internal class AccountInformations
    {
        public int Id { get; set; }
        [Required]
        [Index(IsUnique = true)]
       
        public int AccountNumber { get; set; }
        [Required,MaxLength(20)]
        public string AccountType { get; set; }
        [Required]
        public int Balance { get; set; }

        public int Fk_CunstomerInformationId { get; set; }

        [ForeignKey(nameof(Fk_CunstomerInformationId))]
        public CustomerInformation CustomerInformation { get; set; }




    }
}
