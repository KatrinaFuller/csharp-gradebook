using System;
using System.Collections.Generic;

namespace GradeBook
{
  public class Book
  {
    //constructor
    public Book(string name)
    {
      grades = new List<double>();
      this.name = name;
    }

    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }

    public void ShowStatistics()
    {
      double result = 0.0;
      var highGrade = double.MinValue; //provides with the smallest value
      var lowGrade = double.MaxValue;

      foreach (double number in grades)
      {
        lowGrade = Math.Min(number, lowGrade);
        highGrade = Math.Max(number, highGrade);
        result += number;
      }
      result /= grades.Count;
      Console.WriteLine($"The lowest grade is {lowGrade}");
      Console.WriteLine($"The highest grade is {highGrade}");
      Console.WriteLine($"The average grade is {result:N1}");  //the :N1 makes it so there is 1 number after the decimal

    }

    private List<double> grades; //field
    private string name;
  }
}