using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership
{

  public class Program
  {
    public static void Main()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
      Car yugo = new Car("1980 Yugo Koral", 700, 56000);
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
      Car amc = new Car("1976 AMC Pacer", 400, 198000);

      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };


      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      Console.WriteLine("DEALERSHIP ONLY: What's the sale percentage today?: ");
      string stringPercent = Console.ReadLine();
      int percentage = int.Parse(stringPercent);

      List<Car> CarsMatchingSearch = new List<Car>(0);

      foreach (Car automobile in Cars)
      {

        automobile.SalePrice(percentage);
        if (automobile.WorthBuying(maxPrice))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }
      Console.WriteLine("In how many years would you like to check the depreciation value?: ");
      string depreciationString = Console.ReadLine();
      int depreciationYears = int.Parse(depreciationString);

      foreach (Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine("----------------------");
        Console.WriteLine(automobile.GetMakeModel());
        Console.WriteLine(automobile.GetMiles() + " miles");
        if (automobile.GetMiles() <= 100000)
        {
          Console.WriteLine("This car would fair well in the Dakar Rally.");
        }
        else if (automobile.GetMiles() <= 200000)
        {
          Console.WriteLine("This car would fair okay in the Dakar Rally.");
        }
        else if (automobile.GetMiles() > 200000)
        {
          Console.WriteLine("This car would fair poorly in the Dakar Rally.");
        }
        Console.WriteLine("In " + depreciationYears + " years, your car will be worth: $" + automobile.ValueOverTime(depreciationYears));
        Console.WriteLine("Current Price: $" + automobile.GetPrice());
      }
    }
  }
}
