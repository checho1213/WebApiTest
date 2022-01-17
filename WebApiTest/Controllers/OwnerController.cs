using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class OwnerController : Controller
    {

        IOwnerService _service;
        public OwnerController(IOwnerService service) {
            _service = service;
        }

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns>ActionResult.</returns>
        [HttpGet]
        
        public ActionResult Get()
        {
            var data = _service.GetAllOwners();
            return Ok(data);
        } 
    }
}
