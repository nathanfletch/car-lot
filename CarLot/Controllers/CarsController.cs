using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarLot.Models;
using System;
using System.Reflection;


namespace CarLot.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/cars")]
    public ActionResult Index() { 
      List<Car> allCars = Car.GetAll();
      //allCars will be referenced as "Model" inside the view
      return View(allCars); 
    }

    [HttpGet("/cars/new")]
    public ActionResult AddCar()
    {
      return View();
    }
    //can we overload ActionResult methods?
    //can we pass 2 args to Redirect
    

    [HttpPost("/cars")]
    public ActionResult Create(string make, string carModel, string year, string price, string miles)
    {
      // List<string> arguments = new List<string>(5) { make, carModel, year, price, miles};
      string message = "";
      // for (int i = 0; i < arguments.Count; i++)
      // {
      //   if (arguments[i] == null)
      //   {
      //     message += nameof(arguments[i]);
      //   }
      // }
      // foreach (string item in arguments)
      // {
      //   if (item == null)
      //   {
      //     message += item;
      //   }
      // }

      if(make == null)
      {
        message += nameof(make);//"make";
      } 
      if(carModel == null)
      {
        message += "model";
      } 
      if(year == null)
      {
        message += "year";
      } 
      if(price == null)
      {
        message += "price";
      } 
      if(miles == null)
      {
        message += "miles";
      } 
      
      if (message.Length > 0)
      {
        ViewData["Error"] = "Please enter " + message; 
        return View("AddCar");
      }
      else
      {
        Car myCar = new Car(make, carModel, int.Parse(year) , int.Parse(price), int.Parse(miles));
        return RedirectToAction("Index");
      }
     
      // //general list of possible properties for the Car type.
      // PropertyInfo[] props = typeof(Car).GetProperties();
      // //campare possible props with the props in our specific instance
      // List<string> propNames = new List<string>();
      // for (int index = 0; index < props.Length; index++)
      // {
      //   var thing = props[index].ToString();
      //   string[] propNameArray = thing.Split(' ');
      //   string propName = propNameArray[1];
      //   propNames.Add(propName);
      // }

      // string message = "";
      // for (int i = 0; i < propNames.Count; i++)
      // {
      //   string name = propNames[i];
      //   var value = myCar.GetType().GetProperty(name).GetValue(myCar, null);
      //   if (value == null)
      //   {
      //     message += $"Please enter {propNames[i]}";
      //   }
      // }
    }

    /*
    filter by diff properties - buttons
    sell a car (delete)
    money - lot/dealership object/ static variable?

    Create - AddCar
    Read - Index
    Update - edit/chanhge properties for one car
    Delete - sell
    */
  }  
}
