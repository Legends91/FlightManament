using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Models
{
    internal class Ticket
    {
       /* public Ticket()
        {
            this.OrderTickets = new HashSet<OrderTicket>();
        } */

        public long TicketID { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        //[InverseProperty("Propress")]
        //public virtual ICollection<OrderTicket> OrderTickets { get; set; }
    }

}
