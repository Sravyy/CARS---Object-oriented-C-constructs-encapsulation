using System;
using System.Collections.Generic;

class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;

  public bool WorthBuying(int maxPrice, int maxMiles)
  {
    return(Price < (maxPrice+ 6000) && Miles < maxMiles);
  }

  public Car(string carMakeModel, int carPrice, int carMiles)
  {
    MakeModel = carMakeModel;
    Price = carPrice;
    Miles = carMiles;
  }
}

public class Program
{
  public static void Main()
  {

    Car porsche = new Car("2014 Porsche 911", 114991, 7864)
    Car ford = new Car("2011 Ford F450", 55995, 14241)
    Car lexus = new Car("2013 Lexus RX 350", 44700, 20000)
    Car porsche = new Car("Mercedes Benz CLS550", 39900, 37979)

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
      Console.WriteLine(automobile.MakeModel);
    }
  }
}
