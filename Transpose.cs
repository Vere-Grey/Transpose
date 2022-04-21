using System.Collections.Generic;
using System.Linq;

public static class Transpose
{
    private static string GetTransposedLineFromCharsAtIndex(int charIndex, IEnumerable<string> lines,
        IEnumerable<int> linesSizes)
    {
        var charsAtIndex = lines.Select(line => charIndex < line.Length ? line[charIndex] : ' ');
        var transponsedLine = string.Concat(charsAtIndex);
        var padding = linesSizes
            .Select((value, index) => (value, index))
            .Last(size => size.value > charIndex)
            .index + 1;

        return transponsedLine.TrimEnd().PadRight(padding);
    }

    public static string String(string input)
    {
        var lines = input.Split('\n');
        var linesSizes = lines.Select(line => line.Length);
        var transposedLines = Enumerable.Range(0, linesSizes.Max())
            .Select(index => GetTransposedLineFromCharsAtIndex(index, lines, linesSizes));

        return string.Join('\n', transposedLines);
    }
}