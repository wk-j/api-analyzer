using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAnalyzer.Controllers {
    public class Student {

    }

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class StudentController : ControllerBase {

        [HttpGet]
        [ProducesResponseType(typeof(Student), StatusCodes.Status200OK)]
        [ProducesResponseType(401)]
        [ProducesResponseType(404)]
        public ActionResult<Student> Get(int id) {
            if (id == 0) {
                return NotFound();
            }

            if (id == 1) {
                return Unauthorized();
            }
            return new Student();
        }

    }
}