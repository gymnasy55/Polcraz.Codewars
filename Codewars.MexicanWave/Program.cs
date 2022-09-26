namespace CodeWars
{
    public class Kata
    {
        public List<string> wave(string str)
        {
            var result = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                string temp_result = "";
                for (int j = 0; j < str.Length; j++)
                {
                    if (j == i && str[j] != ' ')
                        temp_result += str[j].ToString().ToUpper();
                    else
                        temp_result += str[j];
                }
                result.Add(temp_result);
            }
            return result.Where(x => x != str).ToList();
        }
    }
}

public static class Program
{
    public static void Main()
    {
        var wave = new CodeWars.Kata().wave("aboba");
        Console.WriteLine(string.Join(", ", wave));
    }
}