using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASEE.Models
{
    public class UserRoles: BaseModels
    {
        [Required]
        public string RoleID { get; set; }


        [Required]
        public string RoleName { get; set; }
    }
}
