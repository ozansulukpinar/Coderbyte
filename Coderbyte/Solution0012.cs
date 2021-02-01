/*
Have the function VowelCount(str) take the str string parameter being passed and return the number of 
vowels the string contains (ie. "All cows eat grass and moo" would return 8). Do not count y as a vowel for 
this challenge.
*/

using System;
using System.Text;
using System.Collections.Generic;

public class Solution0012
{
    public static int VowelCount(string text)
    {
        int result = 0;

        byte[] bytesOfText = Encoding.ASCII.GetBytes(text);

        //a,e,i,o,u,A,E,I,O,U
        List<int> vowelsOfList = new List<int>() { 97, 101, 105, 111, 117, 65, 69, 73, 79, 85 };

        foreach (byte item in bytesOfText)
        {
            if (vowelsOfList.Contains(item))
                result++;
        }

        return result;
    }

    static void Main()
    {
        Console.WriteLine(VowelCount(Console.ReadLine()));
    }
}