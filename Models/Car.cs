using System;

namespace Dealership.Models
{

  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }
    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }
    public string GetMakeModel()
    {
      return MakeModel;
    }

    public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }

    public void SalePrice(int percentage)
    {
      // double amountOff = (percentage * .01);
      // double newPrice = Price - (Price * amountOff);
      // int finalPrice = (int)newPrice;
      // SetPrice((int)newPrice);
      SetPrice((int)(Price - (Price * ((percentage * .01)))));
    }

    public double ValueOverTime(int years)
    {

      string[] ModelSplit = MakeModel.Split(' ');
      int ModelYear = int.Parse(ModelSplit[0]);
      double agedPrice;
      if (ModelYear <= 1979)
      {
        agedPrice = Price - (Price * (.02 * years));
      }
      else if (ModelYear <= 1989)
      {
        agedPrice = Price - (Price * (.01 * years));
      }
      else
      {
        agedPrice = Price;
      }
      return agedPrice;
    }
  }
}
