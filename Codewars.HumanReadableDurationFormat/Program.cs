public class HumanTimeFormat
{
    public static string formatDuration(int seconds)
    {
        var s = "";
        var sec = seconds;
        int[] divArr = { 60 * 60 * 24 * 365, 60 * 60 * 24, 60 * 60, 60, 1 };
        string[] nameArr = { "year", "day", "hour", "minute", "second" };
        if (seconds == 0)
            s = "now";
        var pref = "";
        for (var i = 0; i < divArr.Length; i++)
        {
            var k = sec / divArr[i];
            sec %= divArr[i];
            if (k == 0) continue;
            if (s != "")
                pref = sec == 0 ? " and " : ", ";
            s = s + pref + k + " " + nameArr[i];
            s += k > 1 ? "s" : "";
        }
        return s;
    }
}

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(HumanTimeFormat.formatDuration(60));
    }
}


