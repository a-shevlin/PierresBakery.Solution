using System;

namespace BakeryPastry.Model
{
  public class Pastry
  {
    private static int _price = 2;
    public int Amount { get; set; }
    public int Price { get; set; }
    
    public Pastry(string input)
    {
      Amount = int.Parse(input);
    }

    public int GetPrice()
    {
      if (Amount >= 3)
      {
        Price = (Amount * _price) - GetDiscount();
        return Price;
      }
      else
      {
        Price = (Amount * _price);
        return Price;
      }
      return Price;
    }
    public int GetDiscount()
    {                 //3    - (0) / 3 * 5
      int discount = (Amount - (Amount % 3)) / 3;
      return discount;
    }
  }
}