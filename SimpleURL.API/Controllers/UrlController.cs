using Microsoft.AspNetCore.Mvc;
using SimpleURL.API.Interfaces;

namespace SimpleURL.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UrlController : ControllerBase
    {
        private readonly IUrlRepository _urlRepository;

        public UrlController(IUrlRepository urlRepository)
        {
            _urlRepository = urlRepository;
        }
    
        [HttpPost("shorten")]
        public IActionResult ShortenUrl([FromBody] string originalUrl)
        {
            return Ok();
        }

        [HttpGet("{shortUrl}")]
        public IActionResult RedirectUrl(string shortUrl)
        {
            return Ok();
        }
    }
}