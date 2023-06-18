namespace APP_LAWYER.WEB.Areas.Admin.Models;

public static class StringExtensions
{
    public static string TruncateAtWord(this string input, int numWords)
    {
        var words = input.Split(' ');

        if (words.Length <= numWords)
            return input;

        return string.Join(" ", words.Take(numWords)) + "...";
    }
}