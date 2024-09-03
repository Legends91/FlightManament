using Microsoft.EntityFrameworkCore;

namespace QLBH
{

    internal class OrderTicketDetailsAndChuyenBay
    {
        public long? OrderTicketDetailID { get; set; }
        public long? OrderTicketID { get; set; }
        public long? TicketID { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public bool? Status { get; set; }
        public DateTime? OrderDate { get; set; }
        
       
        public decimal? Amount { get { return Quantity * Price; } }

        
    }
}