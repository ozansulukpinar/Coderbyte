/*
Have the function SimpleSymbols(str) take the str parameter being passed and determine if it is an 
acceptable sequence by either returning the string true or false. The str parameter will be composed of + 
and = symbols with several letters between them (ie. ++d+===+c++==a) and for the string to be true each 
letter must be surrounded by a + symbol. So the string to the left would be false. The string will not be 
empty and will have at least one letter.
*/

using System;
using System.Text;
using System.Collections.Generic;

public class Solution0007
{
    public static string SimpleSymbols(string text)
    {
        string result = "false";

        text = text.ToLower();

        //ASCII table
        //a,z,+,=
        //97,122,43,61

        byte[] bytesOfText = Encoding.ASCII.GetBytes(text);

        int lengthOfBytes = bytesOfText.Length;

        List<int> indexesOfLetter = new List<int>();

        for (int k = 0; k < lengthOfBytes; k++)
        {
            if ((bytesOfText[k] != 43) && (bytesOfText[k] != 61))
                indexesOfLetter.Add(k);
        }

        if (indexesOfLetter.Count != 0)
        {
            foreach (int item in indexesOfLetter)
            {
                if (item == 0 || item == (lengthOfBytes - 1))
                {
                    result = "false";
                    break;
                }

                if (bytesOfText[(item - 1)] != 43 || bytesOfText[(item + 1)] != 43)
                {
                    result = "false";
                    break;
                }

                result = "true";
            }
        }

        return result;
    }

    static void Main()
    {
        Console.WriteLine(SimpleSymbols(Console.ReadLine()));
    }
}