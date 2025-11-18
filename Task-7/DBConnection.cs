namespace Task_7;

public class DBConnection
{
    public string ConnectionString { get; }
    public bool IsConnected { get; }

    public DBConnection(string conn)
    {
        ConnectionString = conn;
        IsConnected = ConnectToDatabase();
    }

    private bool ConnectToDatabase()
    {
        // Fake connection simulation
        Console.WriteLine("Connecting to database...");
        return true;
    }
}