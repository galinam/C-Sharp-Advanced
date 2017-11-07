/* Telerik Academy Season 2016-2017 / C# Advanced Exam - 31 May 2016 / Task1.Messages
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Program
{
    static BigInteger ConvertToNumber(string str, string[] digitGeorgeTheGreat)
    {
        BigInteger result = 0;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < str.Length - 2; i+=3)
        {
            string strDigit = str.Substring(i, 3);
            for (int j = 0; j < 10; j++)
            {
                if (strDigit == digitGeorgeTheGreat[j])
                {
                    sb.Append(j);
                }
            }
        }

        string sbStr = sb.ToString();
        result = BigInteger.Parse(sbStr);
        return result;
    }

    static string ConvertToGeorgeTheGreat(BigInteger number, string[] digitGeorgeTheGreat)
    {
        string result = "";
        StringBuilder sb = new StringBuilder();
        string[] code = { "0","1","2","3","4","5","6","7","8","9"};
        string digits = number.ToString();
        for (int i = 0; i < digits.Length; i++)
        {
            for (int j = 0; j < code.Length; j++)
            {
                if (digits[i].ToString() == code[j])
                {
                    sb.Append(digitGeorgeTheGreat[j]);
                }
            }
        }

        result = sb.ToString();
        return result;
    }
    static void Main()
    {
        string firstStr = Console.ReadLine();
        char sign = char.Parse(Console.ReadLine());
        string secondStr = Console.ReadLine();

        string[] digitGeorgeTheGreat = 
        {
            "cad", 
            "xoz",
            "nop",
            "cyk",
            "min",
            "mar",
            "kon",
            "iva",
            "ogi",
            "yan"
        };

        BigInteger result = 0;
        if (sign == '-')
        {
            result = ConvertToNumber(firstStr, digitGeorgeTheGreat) - ConvertToNumber(secondStr, digitGeorgeTheGreat);
        }
        else if (sign == '+')
        {
            result = ConvertToNumber(firstStr, digitGeorgeTheGreat) + ConvertToNumber(secondStr, digitGeorgeTheGreat);
        }

        Console.WriteLine(ConvertToGeorgeTheGreat(result, digitGeorgeTheGreat));

    }
}