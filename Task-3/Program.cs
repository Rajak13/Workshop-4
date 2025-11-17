namespace Task_3;

class Program
{
    static void Main(string[] args)
    {
        ParameterDemo demo = new ParameterDemo();
        
        //Call increase(ref)
        int value = 30;
        demo.Increase(ref value);
        Console.WriteLine("Value after increase: " + value);
        
        //Call GetFullName(out)
        demo.GetFullName(out string myFullName);
        Console.WriteLine("Full Name : " + myFullName);
        
        //Call SumAll(params)
        int total = demo.SumAll(10, 15, 20, 25, 30);
        Console.WriteLine("Total : " + total);
    }
}