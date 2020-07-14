using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]

    public void IsTriangle_CreatesTriangle_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsTriangle(3,3,3));
    }
  }
}