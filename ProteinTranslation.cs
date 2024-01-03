using System;
using System.Collections.Generic;

public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        Dictionary<string, string> proteinDict = new Dictionary<string, string> {
            {"AUG","Methionine"}, {"UUU", "Phenylalanine"}, {"UUC", "Phenylalanine"},
            {"UUA", "Leucine"}, {"UUG", "Leucine"}, {"UCU", "Serine"}, {"UCC", "Serine"},
            {"UCA", "Serine"}, {"UCG", "Serine"}, {"UAU", "Tyrosine"}, {"UAC", "Tyrosine"},
            {"UGU", "Cysteine"}, {"UGC", "Cysteine"}, {"UGG", "Tryptophan"}, {"UAA", "STOP"},
            {"UAG", "STOP"}, {"UGA", "STOP"}
        };

        List<string> translation = new List<string>();

        for (int i = 0; i < strand.Length; i += 3)
        {
            // Extract a codon (sequence of three nucleotides)
            string codon = strand.Substring(i, Math.Min(3, strand.Length - i));

            // Check if the codon is a stop codon
            if (proteinDict[codon] == "STOP")
            {
                break;
            }
            else
            {
                translation.Add(proteinDict[codon]);
            }
        }

        string[] translationArray = translation.ToArray();
        return translationArray;
    }
}