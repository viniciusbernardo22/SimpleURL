using SimpleURL.API.Models;

namespace SimpleURL.API.Interfaces
{
    public interface IUrlRepository
    {
        Url GetByUrl(string shortUrl);
        Url AddUrl(Url url);
    }
}