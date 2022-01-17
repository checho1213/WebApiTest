using Services.DTO;
using System;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IOwnerService
    {
        /// <summary>
        /// Obtiene el listado de propietarios
        /// </summary>
        /// <returns></returns>
        List<OwnerDTO> GetAllOwners();        
    }
}
