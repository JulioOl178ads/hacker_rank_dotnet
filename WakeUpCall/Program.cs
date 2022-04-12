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

    internal static int DiagonalDifference(List<List<int>> arr)
    {
        var matrix = arr.ToArray();
        int arrayWidth = matrix.GetLength(0);        
        int sumUpDown = 0;
        int sumDownUp = 0;

        for (int x = 0; x < arrayWidth; x++)
        {
            sumUpDown += matrix[x][x];
        }
        
        for (int x = arrayWidth - 1, y = 0; x >= 0; x--, y++)
        {            
            sumDownUp += matrix[x][y];            
        }

        return Math.Abs(sumUpDown - sumDownUp);

    }

    public static List<int> CountingSort(List<int> arr)
    {
        Dictionary<int, int> dictOut = new Dictionary<int, int>();
        int i = 0;

        foreach (var item in arr)
        {
            dictOut.Add(i, 0);
            i++;
        }

        arr.ForEach(x => dictOut[x] += 1);
        
        return dictOut.Values.ToList();
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        int n = Convert.ToInt32("100".Trim());

        List<int> arr = "63 25 73 1 98 73 56 84 86 57 16 83 8 25 81 56 9 53 98 67 99 12 83 89 80 91 39 86 76 85 74 39 25 90 59 10 94 32 44 3 89 30 27 79 46 96 27 32 18 21 92 69 81 40 40 34 68 78 24 87 42 69 23 41 78 22 6 90 99 89 50 30 20 1 43 3 70 95 33 46 44 9 69 48 33 60 65 16 82 67 61 32 21 79 75 75 13 87 70 33".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        List<int> result = Result.CountingSort(arr);

    }
}