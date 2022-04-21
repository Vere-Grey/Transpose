using System;
using System.Collections.Generic;
using System.Linq;

public static class Transpose
{
    private static string GetTransponsedLineForIndex(int lineIndex, IEnumerable<string> lines, List<int> linesSizes)
    {
        var line = string.Concat(lines.Select(line => lineIndex < line.Length ? line.Substring(lineIndex, 1) : " "));
        var padding = linesSizes.Select((size, sizeIndex) => size > lineIndex ? sizeIndex + 1 : 0).Max();
        return line.TrimEnd().PadRight(padding);
    }

    public static string String(string input)
    {
        var lines = input.Split('\n');
        var linesSizes = lines.Select(line => line.Length).ToList();

        var transposedLines = Enumerable.Range(0, linesSizes.Max())
            .Select(index => GetTransponsedLineForIndex(index, lines, linesSizes));

        return string.Join('\n', transposedLines).TrimEnd();
    }
}