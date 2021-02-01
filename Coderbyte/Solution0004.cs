/*
Have the function LetterChanges(str) take the str parameter being passed and modify it using the following 
algorithm. Replace every letter in the string with the letter following it in the alphabet 
(ie. c becomes d, z becomes a). Then capitalize every vowel in this new string (a, e, i, o, u) and 
finally return this modified string.
*/

using System;
using System.Collections.Generic;
using System.Text;

public class Solution0004
{
    public static string LetterChanges(string text)
    {
        string result;

        byte[] asciiBytes = Encoding.ASCII.GetBytes(text);

        /*
        ASCII codes
        a,e,i,o,u --> 97,101,105,111,117
        A,E,I,O,U --> 65,69,73,79,85
        space --> 32
        a,A --> 97,65
        z,Z --> 122,90
        */

        List<int> integersOfNewText = new List<int>();

        foreach (byte item in asciiBytes)
        {
            if ((65 <= item && item <= 90) || (97 <= item && item <= 122))
            {
                if (item == 122 || item == 90)
                {
                    integersOfNewText.Add((item - 25));
                    continue;
                }

                if (item == 97 || item == 101 || item == 105 || item == 111 || item == 117)
                {
                    integersOfNewText.Add((item - 32));
                    continue;
                }

                integersOfNewText.Add((item + 1));
            }

            if (item == 32)
                integersOfNewText.Add(item);
        }

        List<char> listOfNewText = new List<char>();

        foreach (int element in integersOfNewText)
        {
            char character = (char)element;
            listOfNewText.Add(character);
        }

        char[] arrayOfNewText = listOfNewText.ToArray();

        string newText = new String(arrayOfNewText);

        result = newText;

        return result;
    }

    static void Main()
    {
        Console.WriteLine(LetterChanges(Console.ReadLine()));
    }
}