using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        StudentBO context = new StudentBO();
        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<StudentModel> Get()
        {
            return context.GetAll();
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public StudentModel Get(int id)
        {
            return context.GetById(id);
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] StudentModel s)
        {
            context.Add(s);
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] StudentModel s)
        {
            context.Edit(s, id);
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            context.Delete(id);
        }
    }
}
