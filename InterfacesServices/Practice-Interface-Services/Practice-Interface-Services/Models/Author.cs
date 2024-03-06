using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Interface_Services.Models
{
    public class Author : BaseEntity
    {
        public string FullName { get; set; }
        public int Age { get; set; }
    }
}
