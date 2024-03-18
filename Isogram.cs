using System;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        string lowerWord = word.ToLower();
        Dictionary<char, int> alphabet = new Dictionary<char, int>{
            {'a', 0}, {'b', 0}, {'c', 0}, {'d', 0}, {'e', 0}, {'f', 0}, {'g', 0},
            {'h', 0}, {'i', 0}, {'j', 0}, {'k', 0}, {'l', 0}, {'m', 0}, {'n', 0}, 
            {'o', 0}, {'p', 0}, {'q', 0}, {'r', 0}, {'s', 0}, {'t', 0}, {'u', 0}, 
            {'v', 0}, {'w', 0}, {'x', 0}, {'y', 0}, {'z', 0}
        };
        foreach (char character in lowerWord){
            if(alphabet.ContainsKey(character)){
                alphabet[character] += 1;
        }
        }

        foreach (KeyValuePair<char, int> letter in alphabet){
            if(letter.Value > 1){
                return false;
            }
        }
        return true;
    }
}