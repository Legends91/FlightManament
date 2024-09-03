using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Models
{
    internal class SanBay
    {
        
        public string SanBayID { get; set; }
        [StringLength(100)]
        public string TenSanBay { get; set; }
        [StringLength(100)]
        public string Address { get; set; }




        //[InverseProperty("Category")]
        public virtual ICollection<ChuyenBay> ChuyenBays { get; set; }
    }
}
