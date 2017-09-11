//namespace NumberAsArray
//{
//    using System;
//    class Program
//    {
//        static void Main()
//        {
//            // Start Up
//            var lenghts = Console.ReadLine();// this is unnecessarily

//            var shortNumbers = Console.ReadLine().Split(' ');
//            var longNumbers = Console.ReadLine().Split(' ');
//            string[] xchngString;

//            int shortNumberLength = shortNumbers.Length;
//            int longNumberLength = longNumbers.Length;
//            char zeroCode = ('0');

//            //this if always set shortNumbers be shorter than longNumbers
//            if (shortNumberLength > longNumberLength)
//            {
//                xchngString = shortNumbers;
//                shortNumbers = longNumbers;
//                longNumbers = xchngString;
//                shortNumberLength = shortNumbers.Length;
//                longNumberLength = longNumbers.Length;
//            }

//            int[] result = new int[longNumberLength + 1];

//            for (int i = 0; i < longNumberLength; i++)
//            {
//                result[i] += longNumbers[i][0] - zeroCode;
//                if (i < shortNumberLength)
//                {
//                    result[i] += shortNumbers[i][0] - zeroCode;
//                }
//                BiggerFromTen(result, i);
//            }

//            // Print
//            Console.WriteLine(string.Join(" ", result).TrimEnd('0', ' '));

//        }

//        //This Method normalize a digits in arr
//        static void BiggerFromTen(int[] arr, int pos)
//        {
//            if (arr[pos] > 9)
//            {
//                arr[pos] %= 10;
//                arr[pos + 1]++;
//            }
//        }
//    }
//}






using System; // my solution in way i understand the task -> fixed the bug 100/100
class Program
{
    static int?[] SumNumbersAsArrays(int?[] firstNumArr, int?[] secondNumArr)
    {
        int?[] sumArray;
        int smallerLength = 0;
        int biggerLength = 0;
        int?[] biggerNumArr;

        if (firstNumArr.Length < secondNumArr.Length)
        {
            sumArray = new int?[secondNumArr.Length + 1];
            smallerLength = firstNumArr.Length;
            biggerLength = secondNumArr.Length;
            biggerNumArr = secondNumArr;

            sumArray[sumArray.Length - 1] = null;
        }
        else
        {
            sumArray = new int?[firstNumArr.Length + 1];
            smallerLength = secondNumArr.Length;
            biggerLength = firstNumArr.Length;
            biggerNumArr = firstNumArr;

            sumArray[sumArray.Length - 1] = null;
        }


        int? add = 0;
        int? temptSum = 0;
        for (int i = 0, j = 0; i < smallerLength; i++, j++)
        {
            temptSum = firstNumArr[i] + secondNumArr[i];
            sumArray[j] = (temptSum + add);

            if (((temptSum + add) > 9) & (i == smallerLength - 1))
            {
                if (sumArray[j + 1] == null)
                {
                    sumArray[j + 1] = add;
                }
                else sumArray[j + 1] += add;
            }
            
            if (sumArray[i] > 9)
            {
                add = sumArray[j] / 10;
                sumArray[j] = sumArray[j] % 10;
            }
            else add = 0;
        }

        if (smallerLength != biggerLength)
        {
            for (int k = smallerLength; k < biggerLength; k++)
            {

                sumArray[k] = biggerNumArr[k] + add;
                if (sumArray[k] > 9)
                {
                    add = sumArray[k] / 10;
                    sumArray[k] = sumArray[k] % 10;
                }
                else add = 0;

                if ((sumArray[k + 1] == null) & (add != 0))
                {
                    sumArray[k + 1] = add;
                }
                else sumArray[k + 1] += add;
            }
        }


        return sumArray;
    }

    static void Main()
    {
        string strSizesOfArrs = Console.ReadLine();
        string[] sizesOfArrs = strSizesOfArrs.Split(' ');
        string fNumStr = Console.ReadLine();
        string sNumStr = Console.ReadLine();
        string[] fNum = fNumStr.Split(' ');
        string[] sNum = sNumStr.Split(' ');

        int?[] firstNumArr = new int?[int.Parse(sizesOfArrs[0])];
        int?[] secondNumArr = new int?[int.Parse(sizesOfArrs[1])];

        for (int i = 0; i < firstNumArr.Length; i++)
        {
            firstNumArr[i] = int.Parse(fNum[i]);
        }

        for (int i = 0; i < secondNumArr.Length; i++)
        {
            secondNumArr[i] = int.Parse(sNum[i]);
        }
        //Console.WriteLine(String.Join("",firstNumArr));
        //Console.WriteLine(String.Join("",secondNumArr));
        Console.WriteLine(String.Join(" ", SumNumbersAsArrays(firstNumArr, secondNumArr)));
        //Console.WriteLine(5 / 10);
    }
}