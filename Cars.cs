using System;
using System.Collections.Generic;

class Car
{
  private string _makeModel;
  private int _price;
  private int _miles;

  public void SetPrice (int newPrice)
  {
    if (newPrice >= 0) {
      _price = newPrice;
    }
    else
    {
      Console.WriteLine("Not valid");
    }
  }
  public int GetPrice()
  {
    return _price;

  }

  public void SetMakeModel(string newMakeModel)
  {
    _makeModel = newMakeModel;
  }
  public string GetMakeModel()
  {
    return _makeModel;
  }

  public void SetMiles(int newMiles)
  {
    _miles = newMiles;
  }
  public int GetMiles()
  {
    return _miles;
  }

  public Car (string SetMakeModel, int SetMiles, int SetPrice = 10000){
    _makeModel = SetMakeModel;
    _price = SetPrice;
    _miles = SetMiles;
  }

  public bool WorthBuying(int maxPrice, int maxMiles)
  {
    return (_price < maxPrice && _miles < maxMiles);
  }
}

public class Program
{
  public static void Main()
  {
    Car porsche = new Car("2014 Porsche 911", 7864);

    Car ford = new Car("2011 FOrd F450", 14241);

    Car lexus = new Car("2013 Lexus RX 350", 20000);

    Car mercedes = new Car("Mercedes Benz CLS550", 37979);

    Car nissan = new Car("2011 Pathfinder", 20000, 35000);

    Console.WriteLine("Our current selection");
    List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };
    Cars.Add(nissan);

    foreach(Car automobile in Cars)
    {
      Console.WriteLine(automobile.GetMakeModel());
      Console.WriteLine(automobile.GetPrice());
    }

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    Console.WriteLine("Enter maximum miles: ");
    string stringMaxMiles = Console.ReadLine();
    int maxMiles = int.Parse(stringMaxMiles);

    List<Car> CarsMatchingSearch = new List<Car>();

    foreach (Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice, maxMiles))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    Console.WriteLine("Results matching your search");
    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.GetMakeModel());
    }
  }
}
