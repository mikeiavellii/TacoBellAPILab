using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TacoBellAPI.Models;

namespace TacoBellAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BurritoController : ControllerBase
    {
        private TacoBellDbContext dbContext = new TacoBellDbContext();

        [HttpGet]
        public List<Burrito> GetAll()
        {
            return dbContext.Burritos.ToList();
        }
        [HttpGet("ContainsBeans")]
        public List<Burrito> GetBeanContent(bool beans)
        {
            return dbContext.Burritos.Where(b => b.Bean == beans).ToList();
        }

        [HttpPost("add")]
        public Burrito AddBurrito(string name, float cost, bool bean)
        {
            Burrito newBurrito = new Burrito(name, cost, bean);
            dbContext.Burritos.Add(newBurrito);

            dbContext.SaveChanges();
            return newBurrito;
        }

    }
}
