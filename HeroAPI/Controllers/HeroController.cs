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
                },
                new Hero
                {
                    Id = 2,
                    Name = "Batman",
                    FirstName = "Bruce",
                    LastName = "Wayne",
                    Place = "Gotham"
                }
            };

        [HttpPost]
        public async Task<ActionResult<List<Hero>>> AddHero(Hero hero)
        {
            heroes.Add(hero);
            return Ok(heroes);
        }

        [HttpGet]
        public async Task<ActionResult<List<Hero>>> GetAllHeroes()
        {
            return Ok(heroes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Hero>> GetHeroById(int id)
        {

            var hero = heroes.Find(h => h.Id == id);

            if (hero == null)
            {
                NotFound("Hero not found");
            }
            return Ok(hero);
        }
    

       [HttpPut]
       public async Task<ActionResult<List<Hero>>> PutHero(Hero request)
       {
           var hero = heroes.Find(h => h.Id == request.Id);
           if (hero == null)
               NotFound("Hero not found");

            hero.Name = request.Name;
            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.Place = request.Place;

            return Ok(hero);
       }


        [HttpDelete("{id}")]
        public async Task<ActionResult<Hero>> Delete(int id)
        {
            var hero = heroes.Find(h => h.Id == id);
            if (hero == null)
                NotFound("Hero not found");

            heroes.Remove(hero);
            return Ok(hero);
        }



    }
}


    
