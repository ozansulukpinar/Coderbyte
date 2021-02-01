/*
Have the function ABCheck(str) take the str parameter being passed and return the string true if the 
characters a and b are separated by exactly 3 places anywhere in the string at least once (ie. "lane borrowed" 
would result in true because there is exactly three characters between a and b). Otherwise return the string 
false.
*/

using System;
using System.Text;
using System.Collections.Generic;

public class Solution0011
{
    public static string ABCheck(string text)
    {
        string result = "false";

        text = text.ToLower();

        byte[] bytesOfText = Encoding.ASCII.GetBytes(text);

        int lengthOfArray = bytesOfText.Length;

        List<int> abList = new List<int>();

        //ASCII codes
        //a,b
        //97,98

        for (int k = 0; k < lengthOfArray; k++)
        {
            if ((bytesOfText[k] == 97) || (bytesOfText[k] == 98))
                abList.Add(k);
        }

        int lengthOfList = abList.Count;
        int extractionResult = 0;

        if (lengthOfList > 1)
        {
            for (int l = (lengthOfList - 1); l >= 0; l--)
            {
                for (int m = (lengthOfList - 2); m >= 0; m--)
                {
                    extractionResult = abList[l] - abList[m];
                    if (extractionResult == 4)
                    {
                        result = "true";
                        break;
                    }
                }

                if (result == "true")
                    break;
            }
        }

        return result;
    }

    static void Main()
    {
        Console.WriteLine(ABCheck(Console.ReadLine()));
    }
}