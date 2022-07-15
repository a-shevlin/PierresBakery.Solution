using System;

namespace BakeryBread.Model
{
  public class Bread
  {
    //private static int _price = 5;
    public string Amount { get; set; }
    //public int Cost { get; set; }
    
    public Bread(string input)
    {
      Amount = input;
    }

    // public int GetPrice()
    // {
    //   if (Amount <= 1)
    //   {
    //     Cost = (Amount * _price);
    //     return Cost;
    //   }
    //   else
    //   {
    //     Cost = 0;
    //     return Cost;
    //   }
    //   return Cost;
    // }
  }
}