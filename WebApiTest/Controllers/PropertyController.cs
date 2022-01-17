using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Services.DTO;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class PropertyController : Controller
    {

        IPropertyService _service;
        public PropertyController(IPropertyService service) {
            _service = service;
        }

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns>ActionResult.</returns>
        [HttpGet]
        
        public ActionResult Get()
        {
            var data = _service.GetAllProperties();
            return Ok(data);
        }


        /// <summary>
        /// Obtiene las propiedades por filtro
        /// </summary>
        /// <returns>ActionResult.</returns>
        [HttpGet]
        [Route("GetPropertiesByFilter")]
        public ActionResult GetPropertiesByFilter(string name, string address, string internalCode)
        {
            var data = _service.GetPropertiesByFilter(name,address,internalCode);
            return Ok(data);
        }

        /// <summary>
        /// Actualiza la propiedad
        /// </summary>
        /// <returns>ActionResult.</returns>
        [HttpPost]
        [Route("UpdateProperty")]
        public ActionResult UpdateProperty([FromBody]PropertyDTO property)
        {
            var data = _service.UpdateProperty(property);
            return Ok(data);
        }
        /// <summary>
        /// guarda la propiedad
        /// </summary>
        /// <returns>ActionResult.</returns>
        [HttpPost]
        [Route("SaveProperty")]
        public ActionResult SaveProperty([FromBody] PropertyDTO property)
        {
            var data = _service.SaveProperty(property);
            return Ok(data);
        }
    }
}
