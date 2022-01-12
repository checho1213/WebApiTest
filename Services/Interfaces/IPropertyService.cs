using Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IPropertyService
    {
        /// <summary>
        /// Obtiene el listado de propiedades
        /// </summary>
        /// <returns></returns>
        List<PropertyDTO> GetAllProperties();

        /// <summary>
        /// crea o actualiza una propiedad
        /// </summary>
        /// <returns></returns>
        bool SaveProperty(PropertyDTO property);
    }
}
