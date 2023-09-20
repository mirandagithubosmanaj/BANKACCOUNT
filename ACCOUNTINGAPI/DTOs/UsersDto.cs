using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ACCOUNTINGAPI.DTOs
{
    public class UsersDto
    {

    
        public string Username { get; set; }

     
        public int Pin { get; set; }

        
        public int Account_Number { get; set; }

        
        public string Balance { get; set; }

        
     


       
        

        // public virtual IEnumerable<Withdraws> Withdrawsat { get; set; }











    }
}
