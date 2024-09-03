using System.ComponentModel.DataAnnotations;

namespace QLBH.Models
{
    internal class OrderTicket
    {
        public long OrderTicketID { get; set; }
        
       /* public TimeSpan OrderTime { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public TimeSpan?ReceiveTime { get; set; }
        [StringLength(250)]
        public string ReceiveAddress { get; set; } */
        //[ForeignKey(nameof(Propress))]
        public long CustomerID { get; set; }
        //[ForeignKey(nameof(Customer))]
        public long ChuyenBayID { get; set; }
        public DateTime OrderDate { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        
        public virtual Customer Customers { get; set; }

        public virtual ChuyenBay ChuyenBays { get; set; }
        //[InverseProperty("Orders")]



        public OrderTicket()
        {
            this.OrderTicketDetails = new HashSet<OrderTicketDetail>();
        }
        public virtual ICollection<OrderTicketDetail> OrderTicketDetails { get; set; } 
    }
}
