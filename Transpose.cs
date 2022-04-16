using System;
using System.Collections.Generic;
using System.Linq;

public static class Transpose
{

    private static char[] AllNthChars(int index, IEnumerable<char[]> lines)
        => lines.Select(line => index < line.Length ? line[index] : ' ').ToArray();

    public static string String(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return "";
        }
        

        var lines = input
            .Split('\n')
            .Select(line => line.ToCharArray(0, line.Length));
        var maxLineSize = lines.Max(line => line.Length);

        var transposedLines = Enumerable
            .Range(0, maxLineSize)
            .Select(index => new string(AllNthChars(index, lines)));

        return string.Join('\n', transposedLines).Trim();

        // for (var i = 0; i < maxLineSize; i++)
        // {
        //     foreach (var line in lines)
        //     {
        //         var isEndOfLine = i >= line.Length
        //         if (isEndOfLine)
        //         {
        //             results[i] += "";
        //         }
        //         else
        //         {
        //             results[i] += line[i];
        //         }
        //     }
        // }
        //
        // return string.Join('\n', results);
    }
}