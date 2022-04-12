using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

public class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void PlusMinus(List<int> arr)
    {
        float countPositives = arr.Count(x => x > 0);
        float countZeroes = arr.Count(x => x == 0);
        float countNegatives = arr.Count(x => x < 0);

        Console.WriteLine((countPositives / arr.Count()).ToString("0.000000"));
        Console.WriteLine((countNegatives / arr.Count()).ToString("0.000000"));
        Console.WriteLine((countZeroes / arr.Count()).ToString("0.000000"));
        Console.ReadLine();
    }

    public static void MiniMaxSum(List<int> arr)
    {
        Int64 sumHighest = arr.OrderBy(x => x).Take(4).Sum(x => (long)x);
        Int64 sumLowest = arr.OrderByDescending(x => x).Take(4).Sum(x => (long)x);
        Console.WriteLine("{0} {1}", sumHighest, sumLowest);
        Console.ReadLine();
    }

    public static string TimeConversion(string s)
    {
        DateTime hour = Convert.ToDateTime(s.Substring(0, 8));
        bool isAM = s.Substring(8, 2) == "AM";
        DateTime hour24Format = isAM ? hour : hour.AddHours(12);

        if (hour.Hour >= 12)
        {
            if (isAM)
            {
                hour24Format = hour.AddHours(-12);
            }
            else
            {
                hour24Format = hour24Format.AddHours(12);
            }
        }

        return hour24Format.TimeOfDay.ToString();
    }

    public static void FizzBuzz(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            string checkFizzBuzz = i % 3 == 0 && i % 5 == 0 ? "FizzBuzz" : i.ToString();
            checkFizzBuzz = i % 3 == 0 && checkFizzBuzz != "FizzBuzz" ? "Fizz" : checkFizzBuzz;
            checkFizzBuzz = i % 5 == 0 && checkFizzBuzz != "Fizz" && checkFizzBuzz != "FizzBuzz" ? "Buzz" : checkFizzBuzz;

            switch (checkFizzBuzz)
            {
                case "FizzBuzz":
                    Console.WriteLine(checkFizzBuzz);
                    break;
                case "Fizz":
                    Console.WriteLine(checkFizzBuzz);
                    break;
                case "Buzz":
                    Console.WriteLine(checkFizzBuzz);
                    break;
                default:
                    Console.WriteLine(i.ToString());
                    break;
            }
        }
    }

    public static int FindMedian(List<int> arr)
    {
        List<int> orderedList = arr.OrderBy(x => x).ToList();
        int mediumNumber = (orderedList.Count / 2) - 1;
        int outputMember = orderedList.GetRange(mediumNumber, 1).FirstOrDefault();
        return mediumNumber;
    }

    public static int Lonelyinteger(List<int> a)
    {
        return a.Where(x => a.Count(y => y == x) == 1).FirstOrDefault();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
        int result = Result.Lonelyinteger(a);
    }
}