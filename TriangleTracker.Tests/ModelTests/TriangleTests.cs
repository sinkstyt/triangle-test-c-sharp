using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;


namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void Triangle_testTriangle_True()
    {
      Triangle testTriangle = new Triangle(2,3,5);
      Assert.AreEqual(true, testTriangle.IsTriangle());
    }

    [TestMethod]
    public void Triangle_testConstructor_True()
    {
      Triangle testTriangle = new Triangle(2,3,5);
      Assert.AreEqual(3, testTriangle.Side1);
    }
  }
}