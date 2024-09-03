using System.ComponentModel.DataAnnotations;

namespace QLBH.Models
{
    internal class Product
    {
        public Product()
        {
            this.ChuyenBays = new HashSet<ChuyenBay>();
            //this.OrderTicketDetails = new HashSet<OrderTicketDetail>();
        }

        public long ProductID { get; set; }
        public long CategoryID { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        /*public int Quantity { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? MarketPrice { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }*/
        [StringLength(200)]
        public string? ImageFile { get; set; }
        public string Manufacturer { get; set; }
        public bool Status { get; set; }

        public virtual Category Categories { get; set; }
        public virtual ICollection<ChuyenBay> ChuyenBays { get; set; }

        //public virtual ICollection<OrderTicketDetail> OrderTicketDetails { get; set; }  

    }




}
