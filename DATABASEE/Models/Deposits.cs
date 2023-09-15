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
        public float Amount { get; set; }

        [Required]
        public DateTime Transfer_Date { get; set; }


    }
}
