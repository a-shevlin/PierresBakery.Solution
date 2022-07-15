using System;

namespace BakeryBread.Model
{
  public class Bread
  {
    private static int _price = 5;
    public int Amount { get; set; }
    public int Price { get; set; }
    
    public Bread(string input)
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
    }
    public int GetDiscount()
    {                 //3    - (0) / 3 * 5
      int discount = (Amount - (Amount % 3)) / 3 * _price;
      return discount;
    }
  }
}