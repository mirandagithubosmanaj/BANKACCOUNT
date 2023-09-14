using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASEE.Models
{
    public class Users : BaseModels
    {
        [Required]
        public string? Username { get; set; }

        [Required]
        public string? Password { get; set; }

        [Required]
        public string? Account_Number { get; set; }

        [Required]
        public string? Balance { get; set; }

        [ForeignKey("User_Roles/Role_Id")]
        public string? User_Roles { get; set; }


             
    }
}
