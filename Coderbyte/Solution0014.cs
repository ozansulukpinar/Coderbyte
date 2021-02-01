/*
Have the function ExOh(str) take the str parameter being passed and return the string true if there is 
an equal number of x's and o's, otherwise return the string false. Only these two letters will be entered 
in the string, no punctuation or numbers. For example: if str is "xooxxxxooxo" then the output should return 
false because there are 6 x's and 5 o's.
*/

using System;
using System.Text;

public class Solution0014
{
    public static bool ExOh(string text)
    {
        bool result = false;

        text = text.ToLower();

        int numberOfX = 0;
        int numberOfO = 0;

        //ASCII codes
        byte[] bytesOfArray = Encoding.ASCII.GetBytes(text);

        foreach (byte item in bytesOfArray)
        {
            if (item == 111)
                numberOfO++;

            if (item == 120)
                numberOfX++;
        }

        if (numberOfO == numberOfX)
            result = true;

        return result;
    }

    static void Main()
    {
        Console.WriteLine(ExOh(Console.ReadLine()));
    }
}