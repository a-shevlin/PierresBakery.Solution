using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BakeryCart.Model;

namespace BakeryCart.Tests
{
  [TestClass]
  public class CartTests
  {
    [TestMethod]
    public void Cart_TakeInputAndReturn_Int()
    {
      Cart newCart = new Cart(0, 0, 0, 0);
      Assert.AreEqual(0, newCart.BreadAmount);
    }
  }
}