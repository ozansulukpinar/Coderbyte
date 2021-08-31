/*
Have the function FirstReverse(str) take the str parameter being passed and 
return the string in reversed order. For example: if the input string is "Hello World and Coders" then your 
program should return the string sredoC dna dlroW olleH.
*/

using System;

public class Solution0001
{
    public static string FirstReverse(string text)
    {
        char[] letterArray = text.ToCharArray();

        Array.Reverse(letterArray);

        string result = new string(letterArray);

        return result;
    }

    static void Main()
    {
        Console.WriteLine(FirstReverse(Console.ReadLine()));
    }
}
