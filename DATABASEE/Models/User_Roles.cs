﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASEE.Models
{
    public class User_roles: BaseModels
    {
        
        [Required]
        public string Role_name { get; set; }
    }
}
