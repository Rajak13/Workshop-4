namespace Task_3;

public class ParameterDemo
{
    //Method using ref parameter
    public void Increase(ref int number)
    {
        number += 10;
    }
    
    //Method using out parameter
    public void GetFullName(out string fullName)
    {
        fullName = "Abdul Razzaq Ansari";
    }
    
    //Method using params
    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        return sum;
    }
}