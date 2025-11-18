namespace Task_7;

class Program
{
    static void Main()
    {
        //Use Case 1: User Creation
        User user1 = new User("test@example.com", "admin123");

        Console.WriteLine("\n-- Use Case 1: User Creation");
        Console.WriteLine(user1.Email);
        Console.WriteLine(user1.PasswordHash);
        Console.WriteLine(user1.CreatedAt);
        
        
        // Use Case 2: Database Connection
        DBConnection db = new DBConnection(
            "Server=localhost;Database=test;User=sa;Password=1234;"
        );
        Console.WriteLine("\n--- Use Case 2: Database Connection ---");
        Console.WriteLine($"Connected: {db.IsConnected}");
        
        //Use Case 3: Game Engines
        Game player = new Game("Rajak", 5, 100);
        Console.WriteLine("\n--- Use Case 3: Player ---");
        Console.WriteLine($"Name: {player.Name}");
        Console.WriteLine($"Level: {player.Level}");
        Console.WriteLine($"Health: {player.Health}");
    }
}