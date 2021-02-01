/*
Have the function AlphabetSoup(str) take the str string parameter being passed and return the string with 
the letters in alphabetical order (ie. hello becomes ehllo). Assume numbers and punctuation symbols will not 
be included in the string.
*/

using System;
using System.Text;

public class Solution0010
{
    public static string AlphabetSoup(string text)
    {
        string result;

        text = text.ToLower();

        byte[] bytesOfText = Encoding.ASCII.GetBytes(text);

        int lengthOfText = bytesOfText.Length;
        char[] charsOfText = new char[lengthOfText];

        Array.Sort(bytesOfText);

        for (int i = 0; i < lengthOfText; i++)
        {
            charsOfText[i] = (char)bytesOfText[i];
        }

        string newText = new string(charsOfText);

        result = newText;

        return result;
    }

    static void Main()
    {
        Console.WriteLine(AlphabetSoup(Console.ReadLine()));
    }
}