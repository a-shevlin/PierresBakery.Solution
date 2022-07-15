using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryBread.Model;

namespace BakeryBread.Tests
{
  [TestClass]
  public class Bread
  {
    [TestMethod]
    public void Bread_TakeAmountAndReturn_Int()
    {
      int amount = 5;
      Bread newBread = new Bread(amount);
      Assert.AreEqual(amount, newBread.Amount);
    }
  }
}