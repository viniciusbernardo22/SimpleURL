using SimpleURL.Models;

namespace SimpleURL.Data.Interfaces;

public interface IRepository
{
    Url GetByUrl(string shortUrl);
    Url AddUrl(Url url);
}