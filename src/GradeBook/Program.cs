using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      List<double> grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
      grades.Add(56.1);

      double result = 0.0;
      foreach (double number in grades)
      {
        result += number;
      }
      result /= grades.Count;
      Console.WriteLine($"The average grade is {result:N1}");  //the :N1 makes it so there is 1 number after the decimal

      Console.WriteLine("Hello Katrina!");
    }
  }
}
