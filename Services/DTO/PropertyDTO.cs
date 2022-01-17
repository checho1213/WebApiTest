using Microsoft.AspNetCore.Http;

namespace Services.DTO
{
    public class PropertyDTO
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        public string Address { get; set; }
        
        public decimal Price { get; set; }
        
        public string CodeInternal { get; set; }
        public string Year { get; set; }
        public int OwnerId { get; set; }
        public string Owner { get; set; }

        public string IncomeStatement { get; set; }

        public IFormFile  ImageFile { get; set; }


    }
}
