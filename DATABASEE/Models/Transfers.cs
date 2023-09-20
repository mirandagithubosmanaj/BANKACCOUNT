using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASEE.Models
{
    public class Transfers : BaseModels
    {

        [ForeignKey("Users/Account_Number")]
        public string? Sender_Account { get; set; }

        [ForeignKey("Users/ Account_Number")]
        public string? Receiver_Account { get; set; }

        [Required]
        public string? Amount { get; set;}

        [Required]
        public string? Transfer_Date { get; set; }

     // public virtual Users Sender_account { get; set; }

    }
}
