using System;
using System.Collections.Generic;
using System.Linq;

public static class Languages
{
    public static List<string> NewList()
    {
        List<string> newList = new List<string>();
        return newList;
    }

    public static List<string> GetExistingLanguages()
    {
        List<string> langList = new List<string> { "C#", "Clojure", "Elm" };
        return langList;
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages)
    {
        return languages.Count;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        if (languages.Contains(language))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static List<string> ReverseList(List<string> languages)
    {
        List<string> reverseList = new List<string>();
        for (int i = languages.Count; i > 0; i--)
        {
            reverseList.Add(languages[i - 1]);
        }
        return reverseList;
    }

    public static bool IsExciting(List<string> languages)
    {
        if (languages.Count > 0)
        {
            if (languages[0] == "C#")
            {
                return true;
            }
            else if (languages[1] == "C#" && (languages.Count == 2 || languages.Count == 3))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        bool unique = languages.Distinct().Count() == languages.Count;
        return unique;
    }
}
