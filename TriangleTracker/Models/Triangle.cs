using System;
using System.Collections.Generic;

namespace TriangleTracker
{
  public class Triangle
  {
    public int Side1;
    public int Side2;
    public int Side3;
  
    public string IsTriangle(int side1, int side2, int side3)
    {
      if (side1 + side2 <= side3 || side2 + side3 <= side1 || side3 + side1 <= side2)
      {
        return "Not a triangle";
      }
      else if ((side1 == side2) && (side2 == side3))
      {
        return "Equilateral";
      }
      else if (side1 == side2 || side2 == side3 || side1 == side3)
      {
        return "Isosceles";
      }
      else
      {
        return "hey";
      }
    }
  }
}
