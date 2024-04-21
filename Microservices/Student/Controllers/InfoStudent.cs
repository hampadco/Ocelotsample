using Microsoft.AspNetCore.Mvc;

[Route("[Action]")]
[ApiController]
public class InfoStudent:Controller
{

    [HttpGet]
    public IActionResult GetStudentInfo()
    {
        return Ok("Student Service");
    }
    
}