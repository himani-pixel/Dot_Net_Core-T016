using Microsoft.AspNetCore.Mvc;

namespace StudentPWA.Controllers
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
                RollNo = "T016",
                Name = "Himani"
            });
        }
    }
}
