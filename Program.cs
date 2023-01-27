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
using System.Data;
using System.Configuration;
using System.Net;

class Result
{

    /*
     * Complete the 'simpleArraySum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY ar as parameter.
     */

    public static int simpleArraySum(int[] List)
    {
        int totalsum = 0;
        int listlength = List.Length;
        int listlengthsave = listlength;
        --listlengthsave;
        do { totalsum = totalsum + List[listlengthsave]; --listlengthsave; }
        while (listlengthsave > 0);

        return totalsum;

    }

}

class Solution
{
    static void Main(string[] args)
    {
        Console.ReadLine();
        var ar_temp = Console.ReadLine().Split(' ');
        var ar = Array.ConvertAll(ar_temp, int.Parse);
        Console.WriteLine(ar.Sum());
        int result = Result.simpleArraySum(ar);
    }
}
