using EdunovaApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace EdunovaApp.Controllers
{




    [ApiController]
    [Route("api/v1/[controller]")]
    public class SmjerController:ControllerBase
    {

        //dependency injection
        // 1.definiranje privatnog svojstva
        private readonly EdunovaContext _context;

        // 2. proslijeđivanje instance kroz konstruktor
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
