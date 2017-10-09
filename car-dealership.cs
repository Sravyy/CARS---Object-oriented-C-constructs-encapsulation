using System;
using System.Collections.Generic;

class Car
{
  public string _makeModel;
  private int _price;
  private int _miles;

  public void SetPrice(int carPrice)
   {
     if(carPrice >= 0)
     {
       _price = carPrice;
     }
     else
     {
       Console.WriteLine("The price for this item is not valid.");
     }
   }

   public int GetPrice()
   {
     return _price;
   }

  public void SetMiles(int carMiles)
   {
     _miles = carMiles;
   }
   public int GetMiles()
   {
     return _miles;
   }

  public bool WorthBuying(int maxPrice, int maxMiles)
  {
    return(_price < (maxPrice + 6000) && _miles < maxMiles);
  }

  public Car(string carMakeModel, int carPrice, int carMiles = 20000)
  {
    _makeModel = carMakeModel;
    _price = carPrice;
    _miles = carMiles;
  }
}

public class Program
{
  public static void Main()
  {

    Car porsche = new Car("2014 Porsche 911", 114991, 7864);
    Car ford = new Car("2011 Ford F450", 55995);
    Car lexus = new Car("2013 Lexus RX 350", 44700);
    Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979);

    List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    Console.WriteLine("Enter maximum miles: ");
    string stringMaxMiles = Console.ReadLine();
    int maxMiles = int.Parse(stringMaxMiles);

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice, maxMiles))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile._makeModel);
    }
  }
}
