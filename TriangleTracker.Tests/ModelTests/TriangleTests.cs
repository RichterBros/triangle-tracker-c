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
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("Not a triangle", testTriangle.IsTriangle(3,4,20));
    }
    [TestMethod]
    public void IsTriangle_IsEquilateral_Equilateral()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("Equilateral", testTriangle.IsTriangle(3,3,3));
    }
    [TestMethod]
    public void IsTriangle_IsIsosceles_Isosceles()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("Isosceles", testTriangle.IsTriangle(3,4,4));
    }
    [TestMethod]
    public void IsTriangle_IsScalene_Scalene()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("Scalene", testTriangle.IsTriangle(3,4,5));
    }
  }
}