/*
Have the function LetterCapitalize(str) take the str parameter being passed and capitalize the first 
letter of each word. Words will be separated by only one space.
*/

using System;
using System.Collections.Generic;
using System.Text;

public class Solution0006
{
    public static string LetterCapitalize(string text)
    {
        string result = "";

        string[] arrayOfText = text.Split(" ");

        List<string> listOfNewText = new List<string>();

        foreach (string item in arrayOfText)
        {
            byte[] bytesOfWord = Encoding.ASCII.GetBytes(item);

            bytesOfWord[0] -= 32;

            int length = bytesOfWord.Length;
            char[] charArrayOfWord = new char[length];

            for (int l = 0; l < length; l++)
            {
                charArrayOfWord[l] = (char)bytesOfWord[l];
            }

            string newWord = new string(charArrayOfWord);

            listOfNewText.Add(newWord);
        }

        int numberOfWords = listOfNewText.Count;

        string newText = "";

        for (int i = 0; i < numberOfWords; i++)
        {
            newText += listOfNewText[i];

            if (i != (numberOfWords - 1))
                newText += " ";
        }

        result = newText;

        return result;
    }

    static void Main()
    {
        Console.WriteLine(LetterCapitalize(Console.ReadLine()));
    }
}