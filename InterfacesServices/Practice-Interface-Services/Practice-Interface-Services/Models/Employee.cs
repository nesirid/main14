using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Interface_Services.Models
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime Birtday { get; set; }

    }
}
