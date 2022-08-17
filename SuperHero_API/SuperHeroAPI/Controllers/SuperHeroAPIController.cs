using Microsoft.AspNetCore.Mvc;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroAPIController : ControllerBase
    {
        private static List<SuperHero> heros = new List<SuperHero>
        {
            new SuperHero
            {
                Id =1,
                Name = "Spider Man",
                FirstName="Peter",
                LastName="Paker",
                Place="New york"
            },
            new SuperHero
            {
                Id =2,
                Name = "Ironman",
                FirstName="Tony",
                LastName="Stark",
                Place="New york"
            },
            new SuperHero
            {
                Id =3,
                Name = "Bat Man",
                FirstName="Bruce",
                LastName="Wayn",
                Place="Gothem"
            },
            new SuperHero
            {
                Id =4,
                Name = "Ironman",
                FirstName="Steave",
                LastName="Rogers",
                Place="New york"
            }
        };

        [HttpGet]
        [Route("getAllHeros")]
        public async Task<ActionResult<IEnumerable<SuperHero>>> Get()
        {
            return Ok(heros);
        }

        //[HttpGet]
        //[Route("getHeroById")]
        //public async Task<ActionResult<SuperHero>> GetById(int id)
        //{
        //    var hero = heros.Find(h => h.Id == id);
        //    if (hero == null)
        //    {
        //        return BadRequest("Hero not found");
        //    }
        //    return Ok(hero);
        //}

        //Search Heros
        [HttpGet]
        [Route("searchHeroByName")]
        public async Task<ActionResult<IEnumerable<SuperHero>>> SearchByName(string name)
        {
            


            var hero = heros.Find(h => h.Name == name);
            if (hero == null)
            {
                return BadRequest("Hero not found");
            }
            return Ok(hero);
        }

        //Add heros
        [HttpPost]
        [Route("addHeros")]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            heros.Add(hero);
            return Ok(heros);
        }

    }
}
