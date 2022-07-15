using System;

namespace BakeryBread.Model
{
  public class Bread
  {
    private static int _price = 5;
    public int Amount { get; set; }
    public int Price { get; set; }
    
    public Bread(int input)
    {
      Amount = input;
    }

    public int GetPrice()
    {
      if (Amount >= 1)
      {
        Price = (Amount * _price);
        return Price;
      }
      else
      {
        Price = 0;
        return Price;
      }
      return Price;
    }
  }
}