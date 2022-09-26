public class Kata
{
    public static bool Narcissistic(int value) => 
        value == value.ToString().ToCharArray().Sum(variable => Math.Pow(int.Parse(variable.ToString()), value.ToString().Length));
}

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Kata.Narcissistic(153));
    }
}