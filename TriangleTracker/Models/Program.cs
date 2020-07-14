using System;
using TriangleTracker;

public class Program
  {
    public static void Main()
    {
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