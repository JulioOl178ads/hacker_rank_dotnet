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

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        float countPositives = arr.Count(x => x > 0);
        float countZeroes = arr.Count(x => x == 0);
        float countNegatives = arr.Count(x => x < 0);

        Console.WriteLine((countPositives / arr.Count()).ToString("0.000000"));
        Console.WriteLine((countNegatives / arr.Count()).ToString("0.000000"));
        Console.WriteLine((countZeroes / arr.Count()).ToString("0.000000"));
        Console.ReadLine();
    }

    public static void miniMaxSum(List<int> arr)
    {
        Int64 sumHighest = arr.OrderBy(x => x).Take(4).Sum(x => (long)x);
        Int64 sumLowest = arr.OrderByDescending(x => x).Take(4).Sum(x => (long)x);
        Console.WriteLine("{0} {1}", sumHighest, sumLowest);
        Console.ReadLine();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        var arr = "256741038 623958417 467905213 714532089 938071625".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        Result.miniMaxSum(arr);
    }
}
