using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLBH.Models
{
    internal class Customer
    {
        public Customer()
        {
            this.OrderTickets = new HashSet<OrderTicket>();
        }
        public long CustomerID { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(10, MinimumLength = 10), Column(TypeName = "nchar(10)")]
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]

        [StringLength(100)]
        public string? Email { get; set; }
        [StringLength(12)]
        public string CCCD { get; set; }

        public bool? Gender { get; set; }
        [Column(TypeName = "Date")]
        public DateTime BirthDay { get; set; }
        
        
        
       
        //[InverseProperty("Customer")]
        public virtual ICollection<OrderTicket> OrderTickets { get; set; }
    }
}