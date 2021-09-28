using Microsoft.AspNetCore.Mvc;

namespace CarLot.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public string Index() { 
      return View(); 
    }
  }  
}