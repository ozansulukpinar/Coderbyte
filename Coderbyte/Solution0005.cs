/*
Have the function SimpleAdding(num) add up all the numbers from 1 to num. For example: if the input is 
4 then your program should return 10 because 1 + 2 + 3 + 4 = 10. For the test cases, the parameter num will 
be any number from 1 to 1000.
*/

using System;

public class Solution0005
{
    public static int SimpleAdding(int number)
    {
        int result = 0;

        int sum = (number * (number + 1)) / 2;

        result = sum;

        return result;
    }

    static void Main()
    {
        Console.WriteLine(SimpleAdding(Console.ReadLine()));
    }
}