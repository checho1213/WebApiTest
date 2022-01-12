using Infraestructure.Data.Context;
using Services.DTO;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class PropertyService : IPropertyService
    {

        #region Constructor

        private DataBaseContext _context;
        public PropertyService(DataBaseContext context)
        {
            _context = context;
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<PropertyDTO> GetAllProperties()
        {
            var query = (from e in _context.Properties
                         select new PropertyDTO()
                         {
                             Address = e.Address,
                             CodeInternal = e.CodeInternal,
                             Id = e.Id,
                             Name = e.Name,
                             Price = e.Price,
                             Year = e.Year

                         }).ToList();
            return query;
        }
    }
}
