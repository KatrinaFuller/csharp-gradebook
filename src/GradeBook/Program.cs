﻿using System;
using System.Collections.Generic;

namespace GradeBook
{

  class Program
  {
    static void Main(string[] args)
    {
      Book book = new Book("Katrina's Grade Book");
      book.AddGrade(89.1);
      book.AddGrade(90.5);
      book.AddGrade(77.5);

      var stats = book.GetStatistics();

      Console.WriteLine($"The lowest grade is {stats.Low}");
      Console.WriteLine($"The highest grade is {stats.High}");
      Console.WriteLine($"The average grade is {stats.Average:N1}");  //the :N1 makes it so there is 1 number after the decimal
    }
  }
}
