using System;
using System.Collections.Generic;

namespace CarLot.Models
{
    
  public class Car
  {
    public string Make {get; set;}
    public string CarModel {get; set;} 
    public int Year {get; set;}
    public int Price {get; set;}
    public int Miles {get; set;}

    private static List<Car> _cars = new List<Car>();

    public Car(string make, string carModel, int year, int price, int miles)
    {
      Make = make;
      CarModel = carModel;
      Year = year;
      Price = price;
      Miles = miles;
      _cars.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _cars;
    }

    /*
    public int SuggestPrice()

    
    */
  }
}
