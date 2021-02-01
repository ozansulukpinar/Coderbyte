/*
Have the function FirstReverse(str) take the str parameter being passed and 
return the string in reversed order. For example: if the input string is "Hello World and Coders" then your 
program should return the string sredoC dna dlroW olleH.
*/

using System;
using System.Linq;
using System.Collections.Generic;

public class Solution0001
{
    public static string FirstReverse(string text)
    {
        string result;

        string reversedText = "";

        char[] arrayOfText = text.ToArray();

        List<char> elements = new List<char>();

        foreach (var item in arrayOfText)
        {
            elements.Add(item);
        }

        int numberOfElements = elements.Count;

        for (int l = (numberOfElements - 1); l >= 0; l--)
        {
            reversedText += elements[l];
        }

        result = reversedText;

        return result;
    }

    static void Main()
    {
        Console.WriteLine(FirstReverse(Console.ReadLine()));
    }
}