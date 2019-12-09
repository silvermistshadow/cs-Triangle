using System;
using System.Collections.Generic;

public class Triangle 
{
  public int Side1;
  public int Side2;
  public int Side3;
  public string triangleType;

  public Triangle(int side1, int side2, int side3)
  {
    Side1 = side1;
    Side2 = side2;
    Side3 = side3;
  }

  public string TriangleType() {
    if(!((Side1 + Side2 < Side3) || (Side1 + Side3 < Side2) || (Side2 + Side3 < Side1))) 
    {
      if((Side1 == Side2) && (Side2 == Side3))
      {
        this.triangleType = "Equilateral";
      }
      else if((Side1 == Side2) || (Side2 == Side3) || (Side1 == Side3))
      {
        this.triangleType = "Isosceles";
      }
      else 
      {
        this.triangleType = "Scalene";
      }
    }
    else 
    {
      this.triangleType = "Not a triangle";
    }
  return this.triangleType;
  }
}

public class Program 
{
  public static void Main()
  {
    Console.WriteLine("This program takes three numbers and calculates the type of triangle they would make. \n Please enter three numbers, separated by spaces:");
    string[] nums = Console.ReadLine().Split(' ');
    int[] sides = Array.ConvertAll(nums, int.Parse);
    Triangle inputTriangle = new Triangle(side1: sides[0], side2: sides[1], side3: sides[2]);
    Console.WriteLine($"The numbers have been run and the result is: {inputTriangle.TriangleType()}");
  }
}