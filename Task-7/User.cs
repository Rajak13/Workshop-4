namespace Task_7;

public class User
{
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public DateTime CreatedAt { get; set; }

    // ✔ Correct Constructor
    public User(string email, string password)
    {
        Email = ValidateEmail(email);
        PasswordHash = Hash(password);
        CreatedAt = DateTime.Now;
    }

    private string ValidateEmail(string email)
    {
        // Simple example validation
        return email.Contains("@") ? email : "Invalid email";
    }

    private string Hash(string password)
    {
        // Fake hashing for example
        return "HASHED_" + password;
    }
}