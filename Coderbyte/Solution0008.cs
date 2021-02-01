/*
Have the function CheckNums(num1,num2) take both parameters being passed and return the string true if 
num2 is greater than num1, otherwise return the string false. If the parameter values are equal to each other 
then return the string -1.
*/

using System;

public class Solution0008
{
    public static dynamic CheckNums(int number1, int number2)
    {
        bool result = false;

        if (number2 > number1)
        {
            result = true;
            return result;
        }
        else if (number1 > number2)
        {
            return result;
        }

        string stringResult = "-1";
        return stringResult;
    }

    static void Main()
    {
        Console.WriteLine(CheckNums(Console.ReadLine()));
    }
}