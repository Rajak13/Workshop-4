using System;

namespace Task_2;

class Program
{
    static void Main(string[] args)
    {
        //Create object of calculator
        Calculator calc = new Calculator();
        
        //Call Welcome Method
        calc.PrintWelcome();
        
        //Calling Add Method
        int sum = calc.Add(7, 13);
        
        //Calling Multiply Method with Default Parameter
        int mul1 = calc.Multiply(12);
        int mul2 = calc.Multiply(12, 8);
        
        //Print Results
        Console.WriteLine($"Addition Result: {sum}");
        Console.WriteLine($"Multiplication Result with default parameter: {mul1}");
        Console.WriteLine($"Multiplication Result: {mul2}");
    }
}