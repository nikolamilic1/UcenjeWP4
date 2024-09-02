using EdunovaAPP.Data;
using EdunovaAPP.Models;
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
        public IActionResult Get()
        {
            return Ok(_context.Smjerovi);
        }

        [HttpGet]
        [Route("{sifra:int}")]
        public IActionResult GetBySifra(int sifra) {
            return Ok(_context.Smjerovi.Find(sifra));
        }

        [HttpPost]
        public IActionResult Post(Smjer smjer)         
        { 
        _context.Smjerovi.Add(smjer);
            _context.SaveChanges();
            return StatusCode(StatusCodes.Status201Created, smjer);
        }
        [HttpPut]
        [Route("{sifra:int}")]
        public IActionResult Put(int sifra, Smjer smjer)
        {
            var smjerIzBaze = _context.Smjerovi.Find(sifra);

            //za sada ručno, kasnije Mapper
            smjerIzBaze.Naziv = smjer.Naziv;
            smjerIzBaze.Trajanje = smjer.Trajanje;
            smjerIzBaze.Cijena = smjer.Cijena; 
            smjerIzBaze.IzvodiSeOd = smjer.IzvodiSeOd;
            smjerIzBaze.Vaucer = smjer.Vaucer;

            _context.Smjerovi.Update(smjerIzBaze);
            _context.SaveChanges();

            return Ok(new { poruka = "Uspješno promjenjeno" });
        }









    }
}
