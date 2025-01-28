using System;
using System.Transactions;

static void Main(string[] args)
{
    
    Console.WriteLine("enter an integer: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int number))
    {
      if (number % 2 == 0)
      {
        Console.WriteLine($"{number} is an Even Number"); 
      }

      else 
      {
        Console.WriteLine($"{number} is an Odd Number");
      }
    }  

      else
      {
        Console.WriteLine("Invalid Input, Please enter another number");
      } 

    Console.ReadLine();
}

