using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
        
        
    }
}
