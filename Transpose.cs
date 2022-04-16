using System.Collections.Generic;
using System.Linq;

public static class Transpose
{
    private static IEnumerable<char> AllNthChars(int index, IEnumerable<string> lines)
        => lines.Select(line => index < line.Length ? line[index] : ' ');

    public static string String(string input)
    {
        var lines = input.Split('\n');
        var maxLineSize = lines.Max(line => line.Length);

        var transposedLines = Enumerable.Range(0, maxLineSize)
            .Select(index => string.Concat(AllNthChars(index, lines)));

        return string.Join('\n', transposedLines).TrimEnd();
    }
}