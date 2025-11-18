namespace Task_7
{
    
}
public class Game
{
    public string Name { get; }
    public int Health { get; private set; }
    public int Level { get; private set; }

    public Game(string name, int level, int health)
    {
        Name = name;
        Level = level;
        Health = health;
    }
}