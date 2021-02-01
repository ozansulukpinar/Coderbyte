/*
Have the function TimeConvert(num) take the num parameter being passed and return the number of hours 
and minutes the parameter converts to (ie. if num = 63 then the output should be 1:3). Separate the number 
of hours and minutes with a colon.
*/

using System;

public class Solution0009
{
    public static string TimeConvert(int number)
    {
        string result = "";

        int hour = number / 60;

        int minute = number - (hour * 60);

        result = hour + ":" + minute;

        return result;
    }

    static void Main()
    {
        Console.WriteLine(TimeConvert(Console.ReadLine()));
    }
}