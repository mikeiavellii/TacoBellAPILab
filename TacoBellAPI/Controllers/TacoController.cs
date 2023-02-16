using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TacoBellAPI.Models;

namespace TacoBellAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TacoController : ControllerBase
    {
        private TacoBellDbContext dbContext = new TacoBellDbContext();

        [HttpGet]
        public List<Taco> GetAll()
        {
            return dbContext.Tacos.ToList();
        }

        [HttpGet("HasDoritoShell")]
        public List<Taco> GetDoritoed(bool dorito)
        {
            return dbContext.Tacos.Where(t => t.Dorito == dorito).ToList();
        }

        [HttpGet("name")]
        public Taco SearchByName(string name)
        {
            return dbContext.Tacos.FirstOrDefault(t => t.Name.ToLower().Contains(name));
        }

        [HttpDelete]
        public Taco DeleteTaco(string name)
        {
            Taco t = dbContext.Tacos.FirstOrDefault(t => t.Name == name);
            dbContext.Tacos.Remove(t);

            return t;
        }


        //ANY CHANGES TO DB (ADDING OR UPDATING) DON'T FORGET TO dbContext.SaveChanges()
    }
}
