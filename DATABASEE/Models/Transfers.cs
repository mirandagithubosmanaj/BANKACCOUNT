﻿using System;
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

        [ForeignKey("Users/ Id")]
        public int Sender_account { get; set; }

        [ForeignKey("User/ Id")]
        public int Receiver_account { get; set; }

        [Required]
        public float Amount { get; set;}

        [Required]
        public DateTime Transfer_date { get; set; }

     // public virtual Users Sender_account { get; set; }

    }
}
