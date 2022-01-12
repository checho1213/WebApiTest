using System;
using System.ComponentModel.DataAnnotations;

namespace Infraestructure.Data.Entities
{
    public class PropertyImage
    { 
        public int Id { get; set; }

        public int PropertyId { get; set; }
        [Required]
        public Property Property { get; set; }
        [Required]
        public Byte[] Image { get; set; }
        public bool Enabled { get; set; }
    }
}
