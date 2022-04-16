using System;
using System.Linq;

public static class Transpose
{
    public static string String(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return "";
        }

        var numLines = input.Count(c => c.Equals('\n')) + 1;
        var maxLineSize = input.Split('\n').OrderByDescending(s => s.Length).First().Length - 1;
        string[] results = new string[maxLineSize];

        var lines = input.Split('\n').Select(line => line.ToCharArray(0, line.Length));
        // foreach (var (line, index) in lines)
        // {
        //     arr1[]
        // }

        for (int i = 0; i < maxLineSize; i++)
        {
            foreach (var line in lines)
            {
                if (i > line.Length)
                {
                    results[i] += "";
                }
                else
                {
                    results[i] += line[i];
                }
            }
        }

        return string.Join('\n', results);
    }
}