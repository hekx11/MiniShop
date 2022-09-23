using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace basicapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EndPointOneController : ControllerBase
    {
        private static List<EndPointOne>  people = new List<EndPointOne> 
        {
            new EndPointOne{Id = 1, Name="Nie wiem"}
        };
        private readonly DataContext context;

        public EndPointOneController(DataContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<EndPointOne>>> Get()
        {
            return Ok(await this.context.EndPoints.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<EndPointOne>>> Get(int id)
        {
            var person = await this.context.EndPoints.FindAsync(id);
            if (person == null)
                return BadRequest("Not found");
            return Ok(person);
        }
        [HttpPost]
        public async Task<ActionResult<List<EndPointOne>>> AddItem(EndPointOne person)
        {
            this.context.EndPoints.Add(person);
            await this.context.SaveChangesAsync();
            return Ok(await this.context.EndPoints.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<EndPointOne>>> UpdateItem(EndPointOne request)
        {
            var dbPerson = await this.context.EndPoints.FindAsync(request.Id);
            if (dbPerson == null)
                return BadRequest("Not found");
            dbPerson.Name = request.Name;
            await this.context.SaveChangesAsync();
            return Ok(await this.context.EndPoints.ToListAsync());
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<EndPointOne>>> Delete(int id)
        {
            var dbPerson = await this.context.EndPoints.FindAsync(id);
            if (dbPerson == null)
                return BadRequest("Not found");
            this.context.EndPoints.Remove(dbPerson);
            await this.context.SaveChangesAsync();
            return Ok(await this.context.EndPoints.ToListAsync());
        }

    }
}
