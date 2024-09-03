using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Models
{
    internal class Role
    {
        public Role()
        {
            this.Employees = new HashSet<Employee>();
        }

        public long RoleID { get; set; }
        
        public string Name { get; set; }

        //[InverseProperty("Propress")]
        public virtual ICollection<Employee> Employees{ get; set; }
    }
}
