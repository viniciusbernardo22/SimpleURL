using SimpleURL.Data.Data;
using SimpleURL.Data.Interfaces;
using SimpleURL.Models;

namespace SimpleURL.Data.Repositories;

public class UrlRepository : IRepository
{
    private readonly AppDbContext _dbContext;

    public UrlRepository(AppDbContext conn)
    {
        _dbContext = conn;
    }
    
    public Url GetByUrl(string shortUrl)
    {
        return _dbContext.Urls.FirstOrDefault(u => u.ShortUrl == shortUrl);

    }

    public Url AddUrl(Url url)
    {
        _dbContext.Urls.Add(url);
        _dbContext.SaveChanges();
        return url;
    }
}