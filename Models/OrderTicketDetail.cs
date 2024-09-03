using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLBH.Models
{
    //[PrimaryKey(nameof(OrderTicketID))]
    internal class OrderTicketDetail
    {
        public long OrderTicketDetailID { get; set; }
        public long OrderTicketID { get; set; }
        public long TicketID { get; set; }
        public decimal? Price { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "Date")]
        public DateTime OrderDate { get; set; }
        public bool? Status { get; set; }
        

        
         //nếu muốn bảng có cột này
        public virtual Ticket Tickets { get; set; }
        public virtual OrderTicket OrderTickets { get; set; }

        
    }
}
