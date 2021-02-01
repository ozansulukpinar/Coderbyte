/*
Find Intersection
Have the function FindIntersection(strArr) read the array of strings stored in strArr which will contain 2 elements: the first element will represent a list of comma-separated numbers sorted in ascending order, the second element will represent a second list of comma-separated numbers (also sorted). Your goal is to return a comma-separated string containing the numbers that occur in elements of strArr in sorted order. If there is no intersection, return the string false.
Examples
Input: new string[] {"1, 3, 4, 7, 13", "1, 2, 4, 13, 15"}
Output: 1,4,13
*/

using System;
using System.Collections.Generic;

public class Solution0000
{
    public static List<string> FindIntersection(string[] strArr)
    {
        List<string> result = new List<string>() { "false" };

        List<string> intersectionValues = new List<string>();

        string[] valuesOfFirstElement = strArr[0].Split(",");
        string[] valuesOfSecondElement = strArr[1].Split(",");

        foreach (string item in valuesOfFirstElement)
        {
            foreach (string element in valuesOfSecondElement)
            {
                if (item == element)
                    intersectionValues.Add(element);
            }
        }

        if (intersectionValues.Count != 0)
            result = intersectionValues;

        return result;
    }

    static void Main()
    {
        List<string> result = FindIntersection(Console.ReadLine());

        int length = result.Count;

        for (int i = 0; i < length; i++)
        {
            Console.Write(result[i]);
            if (i != (length - 1))
                Console.Write(",");
        }
    }
}