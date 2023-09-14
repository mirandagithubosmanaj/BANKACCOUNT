using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASEE.Models
{
    public class Deposits : BaseModels

    {

        [Required]
        public string? Amount { get; set; }

        [Required]
        public string? Transfer_Date { get; set; }

    }
}
