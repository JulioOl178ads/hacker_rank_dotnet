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

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //string s = Console.ReadLine();
        string s = "12:45:54PM";
        //string s = "12:01:00AM";
        string result = Result.TimeConversion(s);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}