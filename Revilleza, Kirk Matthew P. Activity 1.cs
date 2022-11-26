using System;

namespace Kirky
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter two numbers");
      
      Console.Write("Enter your unang grado: ");
      int b = Convert.ToInt32(Console.ReadLine()); 
      Console.Write("Enter your ikalawang grado: ");
      int c = Convert.ToInt32(Console.ReadLine()); 
     
      int a = b * c;
      
      Console.WriteLine(a);
      
      Console.WriteLine("This is C# program");
      
      
    }
  }
}