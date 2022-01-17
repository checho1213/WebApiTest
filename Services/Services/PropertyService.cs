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
                             OwnerId = e.OwnerId,
                             IncomeStatement = e.IncomeStatement,
                             Owner = e.Owner.Name
                         }).ToList();
            return query;
        }

        /// <summary>
        /// Obtiene las propiedades por filtro
        /// </summary>
        /// <returns></returns>
        public List<PropertyDTO> GetPropertiesByFilter(string name, string address, string internalCode)
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
                             IncomeStatement =  e.IncomeStatement,
                             Owner =  e.Owner.Name

                         }).ToList();
            query = !string.IsNullOrEmpty(name) ? query.Where(e => e.Name.ToUpper().Contains(name.ToUpper())).ToList() : query;
            query = !string.IsNullOrEmpty(address) ? query.Where(e => e.Address.ToUpper().Contains(address.ToUpper())).ToList() : query;
            query = !string.IsNullOrEmpty(internalCode) ? query.Where(e => e.CodeInternal.ToUpper().Contains(internalCode.ToUpper())).ToList() : query;
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
                propertySave.Address = property.Address;
                propertySave.CodeInternal = property.CodeInternal;
                propertySave.Price = property.Price;
                propertySave.Year = property.Year;
                propertySave.IncomeStatement = "Available";
                _context.Properties.Add(propertySave);
                _context.SaveChanges();
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
                propertySave.Address = property.Address;
                propertySave.CodeInternal = property.CodeInternal;
                propertySave.Price = property.Price;
                propertySave.Year = property.Year;
                propertySave.IncomeStatement = property.IncomeStatement;
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
