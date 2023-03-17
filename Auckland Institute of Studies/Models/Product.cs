using System.ComponentModel.DataAnnotations;

namespace Auckland_Institute_of_Studies.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }
    }
}
