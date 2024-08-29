using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{ 


[ApiController]
[Route("api/v1/[controller]")]
    public class HttpMetodeController:ControllerBase
    {
        [HttpGet]
        public string Pozdravi()
        {
            return "Hello!";
        }

    }
}
