using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Interface_Services.Models
{
    internal class Book : BaseEntity
    {
        public string Name { get; set; }
        public Author Author { get; set; }
    }
}
