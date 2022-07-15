using System;

namespace BakeryCart.Model
{
  public class Cart
  {
    public int BreadAmount { get; set; }
    public int BreadPrice { get; set; }
    public int PastryAmount { get; set; }
    public int PastryPrice { get; set; }

    public Cart(int brAmount, int brPrice, int paAmount, int paPrice)
    {
      BreadAmount = brAmount;
      BreadPrice = brPrice;
      PastryAmount = paAmount;
      PastryPrice = paPrice;
    }
  }
}