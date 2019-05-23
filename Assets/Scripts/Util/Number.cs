using UnityEngine;
using System;

public class Number
{
    private static string[] prefix = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n" };
    private const int kPrecision = 3;
    private const double kStarUnit = 100000;

    public static string Converter(double value)
    {
        int index = -1;
        int isNegative = 1;
        string addPrecision = new string('#', kPrecision);
        double precisionValue = Mathf.Pow(10, kPrecision);

        if (value < 0)
        {
            isNegative = -1;
            value = value * isNegative;
        }
        else
        {
            isNegative = 1;
        }

        if (value < 1000d || value < kStarUnit)
        {
            return (Math.Floor(value * isNegative * precisionValue) / precisionValue).ToString("#,#." + addPrecision);
        }

        while (value >= 1000d)
        {
            if (index >= prefix.Length - 1)
            {
                break;
            }

            value = value / 1000d;
            index++;
        }
        return (Math.Floor(value * isNegative * precisionValue) / precisionValue).ToString("#,#." + addPrecision) + " " + prefix[index];
    }
}
