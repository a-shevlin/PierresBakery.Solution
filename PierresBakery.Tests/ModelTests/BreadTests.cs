using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryBread.Model;

namespace BakeryBread.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Bread_TakeAmountAndReturn_Int()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(5, newBread.Amount);
    }
    [TestMethod]
    public void GetPrice_TakeAmountAndReturnPrice_Int()
    {
      Bread newBread = new Bread(5);
      newBread.GetPrice();
      Assert.AreEqual(5 * 5, newBread.Price);
    }
  }
}