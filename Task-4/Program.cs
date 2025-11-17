namespace Task_4;

class Program
{
    static void Main(string[] args)
    {
        //Object Using default constructor
        Player p1 = new Player();
        
        // Print values
        Console.WriteLine("Player 1:");
        Console.WriteLine($"Name: {p1.playerName}");
        Console.WriteLine($"Level: {p1.level}");
        Console.WriteLine($"Health: {p1.health}");

        Console.WriteLine();
        
        //Object Using Parameterized Constructor
        Player p2 = new Player("Rajak", 10, 96);
        
        //Print Values
        Console.WriteLine("Player 2:");
        Console.WriteLine($"Name: {p2.playerName}");   
        Console.WriteLine($"Level: {p2.level}");
        Console.WriteLine($"Health: {p2.health}");
    }
}