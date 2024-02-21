using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SimpleURL.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        [AllowAnonymous]
        [NonAction]
        [Route("/")]
        public object GetStatus()
        {
            return Ok(new
            {
                Status = "Ok",
                Hora = DateTime.Now
            });
        }
    }
}