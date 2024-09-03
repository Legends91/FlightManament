namespace QLBH.Models
{
    internal class ChuyenBay
    {
        public ChuyenBay()
        {
            this.OrderTickets = new HashSet<OrderTicket>();
        }

        public long ChuyenBayID { get; set; }
        public long ProductID { get; set; }
        public string SanBayDi { get; set; }
        public string SanBayDen { get; set; }

     
        public TimeSpan ThoiGianDi { get; set; }

        public TimeSpan ThoiGianDen { get; set; }

        public virtual SanBay SanBays { get; set; }

        public virtual Product Products { get; set; }

        public virtual ICollection<OrderTicket> OrderTickets { get; set; }
    }
}
