using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsTriangle_CreatesTriangle_NotTriangle()
    {
      Triangle testTriangle = new Triangle(3, 4, 20);
      Assert.AreEqual("Not a triangle", testTriangle.IsTriangle());
    }
    [TestMethod]
    public void IsTriangle_IsEquilateral_Equilateral()
    {
      Triangle testTriangle = new Triangle(3,3,3);
      Assert.AreEqual("Equilateral", testTriangle.IsTriangle());
    }
    [TestMethod]
    public void IsTriangle_IsIsosceles_Isosceles()
    {
      Triangle testTriangle = new Triangle(3,4,4);
      Assert.AreEqual("Isosceles", testTriangle.IsTriangle());
    }
    [TestMethod]
    public void IsTriangle_IsScalene_Scalene()
    {
      Triangle testTriangle = new Triangle(3,4,5);
      Assert.AreEqual("Scalene", testTriangle.IsTriangle());
    }
  }
}