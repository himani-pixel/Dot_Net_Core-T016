using Microsoft.AspNetCore.Mvc;

namespace Practical_8A.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                RollNo = 101,
                Name = "Amit Sharma",
                Course = "B.Sc. IT"
            });
        }
    }
}
