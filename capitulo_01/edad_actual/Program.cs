class Program
{
    static void Main(string[] args)
    { 
        var birthYear = 1979;
        var currentYear = 2025;
        var age = currentYear - birthYear;

        Console.WriteLine($"You are {age} years old.");
    }
}