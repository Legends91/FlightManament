using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace QLBH.Models
{
    internal class Employee
    {
       /* public Employee()
        {
            this.ChuyenBays = new HashSet<ChuyenBay>();
        } */
        public long EmployeeID { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(10, MinimumLength = 10), Column(TypeName = "nchar(10)")]
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(15)]
        public string Password { get; set; }
        public bool? Gender { get; set; }
        [Column(TypeName = "Date")]
        public DateTime BirthDay { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DayWork { get; set; }
        [StringLength(12)]
        public string CCCD { get; set; }
        public long RoleID { get; set; }

        //public long ChuyenBayID { get; set; }
        public virtual Role Roles { get; set; }

        //public virtual ICollection<ChuyenBay> ChuyenBays { get; set; }
    }

}

    
