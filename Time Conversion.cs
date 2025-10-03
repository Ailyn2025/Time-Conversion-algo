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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
    // Extract the AM/PM part
    string period = s.Substring(s.Length - 2);
    // Extract the time part without AM/PM
    string time = s.Substring(0, s.Length - 2);
    // Parse the time components
    string[] parts = time.Split(':');
    int hour = int.Parse(parts[0]);
    string minute = parts[1];
    string second = parts[2];
    if (period == "AM")
    {
       
        if (hour == 12)
        {
            hour = 0;
        }
    }
    else 
    {
       
        if (hour != 12)
        {
            hour += 12;
        }
    }
    
    string hourStr = hour.ToString("D2");
    return $"{hourStr}:{minute}:{second}";
}
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
