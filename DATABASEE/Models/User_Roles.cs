using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASEE.Models
{
    public class User_Roles: BaseModels
    {
       // [PrimaryKey("User_Roles")]  duhet me kqyr se edhe ni qels primar e trashegon pre basmodel
        public string? Role_Id { get; set; }


        [Required]
        public string? Role_Name { get; set; }
    }
}
