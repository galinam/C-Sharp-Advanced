using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StartUp
{
    //static void MockInput()
    //{
    //    var reader = new StringReader("ABBAA6BA7");  //пренасочваме входа на конзолата да чете от тук
    //    Console.SetIn(reader);
    //}

    static string GetCypherLength(string encryptedMess)
    {
        string result = "";
        for (int i = encryptedMess.Length - 1; Char.IsDigit(encryptedMess[i]); i--)
        {
            result = encryptedMess[i] + result;
        }

        return result;
    }

    static string GetEncodedPart(string message, int cypherLength)
    {
        var length = message.Length - cypherLength;
        return message.Substring(0, length);
    }

    static string GetCypher(string encodedMessWithCypher, int cypherLength)
    {
        var start = encodedMessWithCypher.Length - cypherLength;
        return encodedMessWithCypher.Substring(start);
    }

    static string GetEncryptedPart(string encodedMessWithCypher, int cypherLength)
    {
        var length = encodedMessWithCypher.Length - cypherLength;
        return encodedMessWithCypher.Substring(0, length);
    }

    static string Decode(string encoded)
    {
        var result = "";

        for (int i = 0; i < encoded.Length; i++)
        {
            var currentAmount = "";

            while (Char.IsDigit(encoded[i]))
            {
                currentAmount += encoded[i];
                i++;
            }

            var symbolToRepeat = encoded[i];
            if (String.IsNullOrEmpty(currentAmount))
            {
                currentAmount = "1";
            }
            result += new String(symbolToRepeat, int.Parse(currentAmount));

        }

        return result;
    }

    static int CodeOf(char ch)
    {
        return ch - 'A';
    }

    static char CharOf(int code)
    {
        return (char)(code + 'A');
    }

    static string Decrypt(string encrypted, string cypher)
    {
        var result = encrypted.ToCharArray();
        var length = Math.Max(encrypted.Length, cypher.Length);

        for (int i = 0; i < length; i++)
        {
            var code1 = CodeOf(result[i % result.Length]);
            var code2 = CodeOf(cypher[i % cypher.Length]);

            var xor = code1 ^ code2;

            result[i % result.Length] = CharOf(xor);
        }

        return String.Join("", result);
    }

    static void Main()
    {
        //MockInput();

        string encryptedMessage = Console.ReadLine();
        var cypherLengthString = GetCypherLength(encryptedMessage);
        var encodedPart = GetEncodedPart(encryptedMessage, cypherLengthString.Length);
        //Console.WriteLine(encodedPart);

        var decoded = Decode(encodedPart);
        //Console.WriteLine(decoded);

        var cypherLength = int.Parse(cypherLengthString);
        var encryptedPart = GetEncryptedPart(decoded, cypherLength);
        var cypher = GetCypher(decoded, cypherLength);

        //Console.WriteLine(encryptedPart);
        //Console.WriteLine(cypher);

        var decrypted = Decrypt(encryptedPart, cypher);
        Console.WriteLine(decrypted);

    }
}

/*
static void InfiniteArrayPrint()
{
    string word1 = "abcd";
    string word2 = "abcdefghijklmn";

    var i = 0;

    while (true)
    {
        Console.WriteLine(word1[i % word1.Length]);
        Console.WriteLine(word2[i % word2.Length]);
    }
}
*/