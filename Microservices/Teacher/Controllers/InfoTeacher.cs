using Microsoft.AspNetCore.Mvc;

[Route("[Action]")]
[ApiController]
public class Infoteacher:Controller
{

    [HttpGet]
    public IActionResult GetTeacherInfo()
    {
        return Ok("Teacher Service");
    }
    
}