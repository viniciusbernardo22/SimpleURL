using SimpleURL.Models;

namespace SimpleURL.Data.Interfaces;

public interface IUrlRepository
{
    Url GetByUrl(string shortUrl);
    Url AddUrl(Url url);
}