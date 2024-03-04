using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {

         private static List<Hero> heroes = new List<Hero>
            {
                new Hero {
                    Id = 1,
                    Name = "Spider Man",
                    FirstName = "Peter",
                    LastName = "Parker",
                    Place = "New York"
                }
            };

        [HttpGet]
        public async Task<ActionResult<List<Hero>>> GetAllHeroes()
        {
         
            return Ok(heroes);
        }

        [HttpPost]
        public async Task<ActionResult<List<Hero>>> AddHero(Hero hero)  
        {
            heroes.Add(hero);
            return Ok(heroes);
        }



    }
}
