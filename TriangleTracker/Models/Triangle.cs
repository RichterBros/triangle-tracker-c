using System;

namespace TriangleTracker
{
  public class Triangle
  {
    public int Side1;
    public int Side2;
    public int Side3;

    public Triangle(int side1, int side2, int side3)
    {
      Side1 = side1;
      Side2 = side2;
      Side3 = side3;
    }
  
    public string IsTriangle()
    {
      if (Side1 + Side2 <= Side3 || Side2 + Side3 <= Side1 || Side3 + Side1 <= Side2)
      {
        return "Not a triangle";
      }
      else if ((Side1 == Side2) && (Side2 == Side3))
      {
        return "Equilateral";
      }
      else if (Side1 == Side2 || Side2 == Side3 || Side1 == Side3)
      {
        return "Isosceles";
      }
      else
      {
        return "Scalene";
      }
    }
  }
}
