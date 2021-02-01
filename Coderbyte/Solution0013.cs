/*
Have the function WordCount(str) take the str string parameter being passed and return the number of 
words the string contains (e.g. "Never eat shredded wheat or cake" would return 6). Words will be separated 
by single spaces.
*/

using System;

public class Solution0013
{
    public static int WordCount(string text)
    {
        int result = 0;

        string[] arrayOfText = text.Split(" ");

        result = arrayOfText.Length;

        return result;
    }

    static void Main()
    {
        Console.WriteLine(WordCount(Console.ReadLine()));
    }
}