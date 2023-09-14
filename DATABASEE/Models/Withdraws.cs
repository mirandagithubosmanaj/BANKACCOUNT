using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASEE.Models
{
    public class Withdraws : BaseModels
    {


        [ForeignKey("Users/User_Id")]
        public string? User_Id { get; set; }

        [Required]
        public string? Amount { get; set; }

        [Required]
        public string? Transfer_Date { get; set; }


    }
}
