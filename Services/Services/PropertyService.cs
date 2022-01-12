using Infraestructure.Data.Context;
using Infraestructure.Data.Entities;
using Services.DTO;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

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

        #region Metodos

        /// <summary>
        /// Agrega una imagen a una propiedad
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public bool AddImageProperty(byte[] image, int propertyId)
        {
            try
            {
                PropertyImage propertyImage = new PropertyImage();
                propertyImage.Enabled = true;
                propertyImage.Image = image;
                propertyImage.PropertyId = propertyId;
                _context.PropertyImages.Add(propertyImage);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// lista todas las propiedades
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
                             Year = e.Year,
                            OwnerId =  e.OwnerId,
                            Owner =  e.Owner.Name
                         }).ToList();
            return query;
        }

        /// <summary>
        /// Obtiene las propiedades por filtro
        /// </summary>
        /// <returns></returns>
        public List<PropertyDTO> GetPropertiesByFilter(string filter)
        {

            var query = (from e in _context.Properties
                         where e.Address.Contains(filter) || e.CodeInternal.Contains(filter) || e.Name.Contains(filter) || e.Owner.Name.Contains(filter)
                         || e.Year.Contains(filter)
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

        /// <summary>
        /// crea una propiedad
        /// </summary>
        /// <returns></returns>
        public bool SaveProperty(PropertyDTO property)
        {
            try
            {
                Property propertySave = new Property();
                propertySave.Name = property.Name;
                propertySave.OwnerId = property.OwnerId;
                propertySave.Price = property.Price;
                propertySave.Year = property.Year;
                _context.Properties.Add(propertySave);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// actualiza la propiedad
        /// </summary>
        /// <returns></returns>
        public bool UpdateProperty(PropertyDTO property)
        {
            try
            {
                var propertySave = (from e in _context.Properties
                                    where e.Id == property.Id
                                    select e).FirstOrDefault();
                propertySave.Name = property.Name;
                propertySave.OwnerId = property.OwnerId;
                propertySave.Price = property.Price;
                propertySave.Year = property.Year;
                _context.Entry(propertySave).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion
    }
}
