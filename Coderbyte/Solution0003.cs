/*
Have the function LongestWord(sen) take the sen parameter being passed and return the largest word in the 
string. If there are two or more words that are the same length, return the first word from the string with 
that length. Ignore punctuation and assume sen will not be empty.
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution0003
{
    public static string LongestWord(string sentence)
    {
        string result;

        var sentenceWithoutPunctuation = new StringBuilder();

        foreach (char element in sentence)
        {
            if (!char.IsPunctuation(element))
                sentenceWithoutPunctuation.Append(element);
        }

        sentence = sentenceWithoutPunctuation.ToString();


        List<string> wordsOfSentence = new List<string>();

        string[] words = sentence.Split(" ");

        int lengthOfWord = 0;

        foreach (string item in words)
        {
            if (item.Length > lengthOfWord)
            {
                wordsOfSentence = new List<string>() { item };
                lengthOfWord = item.Length;
            }

            if (item.Length == lengthOfWord)
                wordsOfSentence.Add(item);
        }

        result = wordsOfSentence[0];

        return result;
    }

    static void Main()
    {
        // keep this function call here
        Console.WriteLine(LongestWord(Console.ReadLine()));
    }
}