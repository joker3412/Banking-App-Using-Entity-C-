using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Model
{
    internal class Transaction
    {
        public int Id { get; set; }
        [Required]
        // [Column()]
        public int SourceAccount { get; set; }
        public int DestinationAccount { get; set; }

        [Column(TypeName ="datetime2")]
        public DateTime TransactionDate { get; set; }
        [Required, MaxLength(20)] //not null
        public string Mode { get; set; }
        public int RemainingBalance { get; set; }

        public int FK_AccountNumberId { get; set; }
        [ForeignKey(nameof(FK_AccountNumberId))]
        public AccountInformation AccountInformation { get; set; }


    }
}