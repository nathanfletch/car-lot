using Microsoft.AspNetCore.Mvc;

namespace CarLot.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index() { 
      return View(); 
    }

    //carscontroller
    //form route and view
    //display list route and view
  }  
}