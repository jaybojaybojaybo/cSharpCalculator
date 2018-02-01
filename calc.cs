using System;


class Calculator
{
  static void Main()
  {
    Console.WriteLine("Let's Calculate! Enter your first number: ");
    string stringNumberOne = Console.ReadLine();
    int numberOne = int.Parse(stringNumberOne);

    Console.WriteLine("Do What (+,-,*,/)?");
    string stringOperator = Console.ReadLine();

    Console.WriteLine("Enter your second number: ");
    string stringNumberTwo = Console.ReadLine();
    int numberTwo = int.Parse(stringNumberTwo);

    int solution = 0;

    if (stringOperator == "+")
    {
      solution = numberOne + numberTwo;
    }
    else if (stringOperator == "-")
    {
      solution = numberOne - numberTwo;
    } else if (stringOperator == "*")
    {
      solution = numberOne * numberTwo;
    } else if (stringOperator == "/")
    {
      solution = numberOne / numberTwo;
    };

    string stringSolution = solution.ToString();

    Console.WriteLine("Here is your solution: " + stringSolution);
  }
}
