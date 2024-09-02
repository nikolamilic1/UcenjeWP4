using EdunovaAPP.Data;
using Microsoft.AspNetCore.Mvc;

namespace EdunovaAPP.Controllers
{



    [ApiController]
    [Route("api/v1/[controller]")]
    public class SmjerController : ControllerBase
    {
        //dependency injection
        // 1. defirniraš privatno svojstvo

        private readonly EdunovaContext _context;

        //dependency injection
        // 2. proslijediš instancu kroz konstruktor

        public SmjerController(EdunovaContext context)
        {
            _context = context;
        }

        // RUTE

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_context.Smjerovi);
        }





    }
}
