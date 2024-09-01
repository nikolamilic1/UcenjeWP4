using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{


    [ApiController]
    [Route("api/v1/[controller]")]
    public class HttpMetodeController : ControllerBase
    {

        // Ovdje počinje ruta
        [HttpGet]
        public string Pozdravi()
        {
            return "Hello!";
        }
        // Ovdje završava ruta


        // Ovdje počinje ruta
        [HttpGet]
        [Route("Pozdrav")]
        public string Pozdravi(string s)
        {
            return "Hello " + s;
        }
        // Ovdje završava ruta




        // Ovdje počinje ruta
        [HttpGet]
        [Route("hello")]
        public IActionResult Pozdravi(int id, string ime)
        {
            return Ok(new { sifra = id, naziv = ime });  //napravljena nova instanca klase koja ima dva svojstva sifra i naziv
        }

        // Ovdje završava ruta


        // Ovdje počinje ruta
        [HttpPost]
        public IActionResult Post()
        {
            return BadRequest("Nešto ne valja");
        }
        // Ovdje završava ruta


        // Ovdje počinje ruta
        [HttpPut]
        public IActionResult Put(Osoba osoba)  // ne prima boolean, nego cijelu klasu
        {

        }
        
            


        }
    }
