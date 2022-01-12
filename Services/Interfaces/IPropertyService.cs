using Services.DTO;
using System;
using System.Collections.Generic;

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

        /// <summary>
        /// actualiza una propiedad
        /// </summary>
        /// <returns></returns>
        bool UpdateProperty(PropertyDTO property);

        /// <summary>
        /// Agrega una imagen a una propiedad
        /// </summary>
        /// <returns></returns>
        bool AddImageProperty(Byte[] image, int propertyId);

        /// <summary>
        /// Obtiene el listado de propiedades por filtros
        /// </summary>
        /// <returns></returns>
        List<PropertyDTO> GetPropertiesByFilter(string filter);
    }
}
