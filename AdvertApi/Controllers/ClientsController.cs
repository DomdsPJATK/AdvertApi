using AdvertApi.DTOs.Requests;
using Microsoft.AspNetCore.Mvc;

namespace AdvertApi.Controllers
{    
    [ApiController]
    [Route("api/clients")]
    public class ClientsController : ControllerBase
    {

        public IActionResult RegisterUser()
        {
            return Ok("Wszystko jednak okej :)");
        }
        
    }
}