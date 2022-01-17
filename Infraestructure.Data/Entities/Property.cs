using System.ComponentModel.DataAnnotations;

namespace Infraestructure.Data.Entities
{
    public class Property
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string CodeInternal { get; set; }
        public string Year { get; set; }

        public string IncomeStatement{ get; set; }

        public Owner Owner { get; set; }
        [Required]
        public int OwnerId { get; set; }
    }
}
