using Microsoft.AspNetCore.Mvc;
using System.Net.Security;

namespace WebAPI.Controllers
{


    [ApiController]
    [Route("api/v1/[controller]")]
    public class HttpMetodeController: ControllerBase
    {
        
        // ovdje počinje ruta
        [HttpGet]
       
        public string Pozdravi()
        {
            return "Hello";
        }
        // ovdje završava ruta



        // ovdje počinje ruta
        [HttpGet]
        [Route("pozdrav")]

        public string Pozdravi(string s)
        {
            return "Hello " + s;
        }
        // ovdje završava ruta


        [HttpGet]
        [Route("Hello")]
        public IActionResult Pozdravi(int id, string ime)
        {
            return Ok(new {sifra = id, naziv = ime});
        }




    }
}
