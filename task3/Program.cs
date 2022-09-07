using System;
using System.Text.RegularExpressions;

public class task3
{
    public static void Main(string[] args)
    {
        Regex re = new Regex(@"[0-9]");
        var m = re.Match(Console.ReadLine());
        if (m.Length > 0)
        {
            Console.WriteLine("Contain a digits xD");
        }
        else
        {
            Console.WriteLine("Doesn't contain a digits xD");
        }
    }
}