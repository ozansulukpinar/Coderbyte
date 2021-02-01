/*
Have the function FirstFactorial(num) take the num parameter being passed and return the factorial of 
it (e.g. if num = 4, return (4 * 3 * 2 * 1)). For the test cases, the range will be between 1 and 18 and the 
input will always be an integer.
*/

using System;

public class Solution0002
{
    public static int FirstFactorial(int number)
    {
        int result = 1;

        for (int i = number; i > 0; i--)
        {
            result *= i;
        }

        return result;
    }

    static void Main()
    {
        Console.WriteLine(FirstFactorial(Console.ReadLine()));
    }
}