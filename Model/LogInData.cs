using BankManagementSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Data
{
    internal class LogInData
    {
        
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string UserName{ get; set; }
        [Required]
        [MaxLength(50)]
        public string Password{ get; set; }
       

    }
}
