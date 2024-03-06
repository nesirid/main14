
using Practice_Interface_Services.Models;

namespace Practice_Interface_Services.Services
{
    public class Employee : BaseEntity
    {
        public string Name { get; internal set; }
        public string Surname { get; internal set; }
        public int Age { get; internal set; }
        public string Email { get; internal set; }
        public string Address { get; internal set; }
        public DateTime Birthday { get; internal set; }
        public object Addres { get; internal set; }
        public object ErrorMessage { get; internal set; }
    }
}