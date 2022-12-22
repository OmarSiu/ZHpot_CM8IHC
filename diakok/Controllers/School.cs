using diakok.Models;
using Microsoft.AspNetCore.Mvc;


namespace diakok.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class School : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Models.Diak context = new Models.Diak();
            return Ok(context.Students.ToList());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Models.Diak context = new Models.Diak();
            var keresid = (from x in context.Students
                           where x.Id == id
                           select x).FirstOrDefault();
            return Ok(keresid);
        }
        [HttpGet("Name/{Name}")]
        public IActionResult Get(String Name)
        {
            Models.Diak context = new Models.Diak();
            var keresnev = (from x in context.Students
                            where x.Name == Name
                            select x).FirstOrDefault();
            return Ok(keresnev);
        }

        [HttpPost("newstudent")]
        public void Post([FromBody] Student újstudent)
        {
            Models.Diak context = new Models.Diak();
            context.Add(újstudent);
            context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Models.Diak context = new Models.Diak();
            var torlendo = (from x in context.Students
                            where x.Id == id
                            select x).FirstOrDefault();
            context.Remove(torlendo);
            context.SaveChanges();
        }
    }
}