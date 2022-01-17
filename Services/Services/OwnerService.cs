using Infraestructure.Data.Context;
using Infraestructure.Data.Entities;
using Services.DTO;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Services
{
    public class OwnerService : IOwnerService
    {

        #region Constructor

        private DataBaseContext _context;
        public OwnerService(DataBaseContext context)
        {
            _context = context;
        }

        #endregion

        #region Metodos

        public List<OwnerDTO> GetAllOwners()
        {
            var query = (from e in _context.Owners
                         select new OwnerDTO()
                         {
                             Id = e.Id,
                             Name = e.Name
                         }).ToList();
            return query;
        }


        #endregion
    }
}
