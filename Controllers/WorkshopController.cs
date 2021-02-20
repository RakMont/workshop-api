using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using workshop_api.business_logic.entities;
using workshop_api.business_logic.interfaces;
namespace workshop_api.Controllers
{
    [ApiController]
    [Route("workshop-controller")]
    public class WorkshopController : ControllerBase
    {
        private static readonly Workshop[] workshop = new Workshop[]
        {
            //"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WorkshopController> _logger;
        private readonly IBusinessLogic _business;
        public WorkshopController(ILogger<WorkshopController> logger,IBusinessLogic businessLogic)
        {
            _logger = logger;
            _business = businessLogic;
        }

        [HttpGet]
        public List<Workshop>  Get()
        {
            return _business.getWorkshops();
        }
        [HttpGet("workshop/{id}")] 
         public ActionResult<Workshop> Get(int id) 
        { 
        var workshop = _business.getOneWorkshop(id); 

        if (workshop == null) 
        { 
            return NotFound(); 
        } 

        return workshop; 
    }
    [HttpPost("workshop/create")] 
    public IActionResult Create(Workshop workshop) 
    { 
        _business.create_WorkShop(workshop); 
        return Accepted(); 
    }  
        [HttpPost]
        public int PostWorkShop()
        {
            return 200;
        }
    }
}
