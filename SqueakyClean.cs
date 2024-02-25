using System;
using System.Text.RegularExpressions;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        string newIdentifier = identifier.Replace(' ', '_');
        string pattern = @"[\x00-\x1F\x7F]";
        string nonLetterPattern = @"[^\p{L}_]";
        newIdentifier = Regex.Replace(newIdentifier, pattern, "CTRL");
        string[] words = newIdentifier.Split('-');
        string lowerGreekPattern = "[α-ω]";
        
        StringBuilder camelCaseBuilder = new StringBuilder(words[0]);
        for (int i = 1; i < words.Length; i++)
        {
            camelCaseBuilder.Append(char.ToUpper(words[i][0]) + words[i].Substring(1));
        }
        newIdentifier = camelCaseBuilder.ToString();
        newIdentifier = Regex.Replace(newIdentifier, nonLetterPattern, "");
        newIdentifier = Regex.Replace(newIdentifier, lowerGreekPattern, "");
        return newIdentifier;
    }
}
