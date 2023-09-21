﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASEE.Models
{
    public class Transfer : BaseModels
    {

        [ForeignKey("User/Account_Number")]
        public string? Sender_Account { get; set; }

        [ForeignKey("User/ Account_Number")]
        public string? Receiver_Account { get; set; }

        [Required]
        public string? Amount { get; set;}

        [Required]
        public string? Transfer_Date { get; set; }


    }
}