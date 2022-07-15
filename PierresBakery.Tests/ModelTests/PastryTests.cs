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
      Pastry newPastry = new Pastry("1");
      int price = (2);
      newPastry.GetPrice();
      Assert.AreEqual(price, newPastry.Price);
    }
    [TestMethod]
    public void GetDiscount_TakeAmountAndReturnDiscount_Int()
    {
      Pastry newPastry = new Pastry("3");
      int discount = newPastry.GetDiscount();
      Assert.AreEqual(1, discount);
    }
    [TestMethod]
    public void GetPrice_TakeAmountAndReturnDiscountedPrice_Int()
    {
      Pastry newPastry = new Pastry("5");
      newPastry.GetPrice();
      int price = (5 * 2) - ((5 -(5 % 3))/ 3);
      Assert.AreEqual(price, newPastry.Price);
    }
  }
}