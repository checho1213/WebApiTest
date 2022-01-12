using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data.Entities
{
    public class PropertyImage
    { 
        public int Id { get; set; }
        [Required]
        public Property Property { get; set; }
        [Required]
        public Byte[] Image { get; set; }
        public bool Enabled { get; set; }
    }
}
