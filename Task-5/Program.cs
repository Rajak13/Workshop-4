namespace Task_5
{
    public enum DayType
    {
        Weekend,
        Weekday
    }

    public record Book(string title, string author, double price);

    public class Program
    {
        public static void Main(string[] args)
        {
            // ==== ENUM + DAY CHECKING ====

            Console.Write("Enter a day : ");
            string dayInput = Console.ReadLine().Trim().ToLower();

            DayType dayType;

            // Weekend: Friday + Saturday
            if (dayInput == "friday" || dayInput == "saturday")
            {
                dayType = DayType.Weekend;
            }
            else
            {
                dayType = DayType.Weekday;
            }

            Console.WriteLine($"It is: {dayType}");
            Console.WriteLine();


            // ==== RECORDS ====

            // Create first book object
            Book book1 = new Book("Spring Snow", "Yukio Mishima", 999.50);

            // Create second book using with-expression
            Book book2 = book1 with { title = "Runaway Horses", price = 1599.00 };

            // Print first book
            Console.WriteLine("Book 1 Details:");
            Console.WriteLine(book1);
            Console.WriteLine();

            // Deconstruct second book
            var (title, author, price) = book2;

            Console.WriteLine("Book 2 Deconstructed:");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {price}");
        }
    }
}