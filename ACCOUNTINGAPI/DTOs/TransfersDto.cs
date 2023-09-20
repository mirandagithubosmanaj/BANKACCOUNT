using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ACCOUNTINGAPI.DTOs
{
    public class TransfersDto
    {

        
        public int Sender_account { get; set; }

        
        public int Receiver_account { get; set; }

        
        public string Amount { get; set; }

        
      

        // public virtual ICollection<Deposits> Depositat { get; set; }










    }
}
