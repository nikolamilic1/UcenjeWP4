using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{ 


[ApiController]
[Route("api/v1/[controller]")]
    public class HttpMetodeController:ControllerBase
    {
        
        // Ovdje počinje ruta
        [HttpGet]
        public string Pozdravi()
        {
            return "Hello!";
        }
        // Ovdje završava ruta

        [HttpGet]
        [Route("pozdrav")]
        public string Pozdravi(string s)
        {
            return "Hello" + s;
        }
    }
}
