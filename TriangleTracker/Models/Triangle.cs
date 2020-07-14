using System;
using System.Collections.Generic;

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
  public class Program
  {
    public static void Main()
    {
      //for(i=1; i<4; i++)
      //Console.WriteLine("Enter a number from 0-100");
      // string stringSideOne = Console.ReadLine();
      //int "side"+ i = int.Parse(stringSideOne);

      Console.WriteLine("Enter a number from 0-100");
      string stringSideOne = Console.ReadLine();
      int sideOne = int.Parse(stringSideOne);

      Console.WriteLine("Enter a number from 0-100");
      string stringSideTwo = Console.ReadLine();
      int sideTwo = int.Parse(stringSideTwo);

      Console.WriteLine("Enter a number from 0-100");
      string stringSideThree = Console.ReadLine();
      int sideThree = int.Parse(stringSideThree);

      Triangle triangle = new Triangle(sideOne, sideTwo, sideThree);

      string triangleType = triangle.IsTriangle();

      Console.WriteLine(triangleType);
    }
  }
}
