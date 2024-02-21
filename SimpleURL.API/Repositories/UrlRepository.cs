using SimpleURL.API.Data;
using SimpleURL.API.Interfaces;
using SimpleURL.API.Models;

namespace SimpleURL.API.Repositories
{
    public class UrlRepository : IUrlRepository
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
}