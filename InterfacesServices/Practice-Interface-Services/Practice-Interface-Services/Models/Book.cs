
namespace Practice_Interface_Services.Models
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public Author Author { get; set; }
    }
}
