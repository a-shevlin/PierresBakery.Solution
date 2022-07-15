using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BakeryPastry.Model;

namespace BakeryPastry.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastry_TakeAmountAndReturn_Int()
    {
      Pastry newPastry = new Pastry("5");
      Assert.AreEqual(5, newPastry.Amount);
    }
    [TestMethod]
    public void GetPrice_TakeAmountAndReturnPrice_Int()
    {
      Pastry newPastry = new Pastry("5");
      int price = (5 *2) - ((5 -(5 % 3))/ 3);
      newPastry.GetPrice();
      Assert.AreEqual(price, newPastry.Price);
    }
    // [TestMethod]
    // public void GetDiscount_TakeAmountAndReturnDiscount_Int()
    // {
    //   Bread newBread = new Bread("3");
    //   int discount = newBread.GetDiscount();
    //   Assert.AreEqual(5, discount);
    // }
    // [TestMethod]
    // public void GetPrice_TakeAmountAndReturnDiscountedPrice_Int()
    // {
    //   Bread newBread = new Bread("3");
    //   newBread.GetPrice();
    //   Assert.AreEqual(10, newBread.Price);
    // }
  }
}