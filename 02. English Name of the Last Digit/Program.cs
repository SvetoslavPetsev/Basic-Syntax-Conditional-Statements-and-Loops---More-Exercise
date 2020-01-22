using System;

namespace _02._English_Name_of_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int lenght = number.Length;
            char theSimbol = ' ';
            for (int i = 0; i < lenght; i++)
            {
                char simbol = number[i];
                if (i == lenght -1)
                {
                    theSimbol = simbol;
                    break;
                }
            }
            int lastNumber = (int)Char.GetNumericValue(theSimbol);
            string[] num = new string[10];
            num[0] = "zero";
            num[1] = "one";
            num[2] = "two";
            num[3] = "three";
            num[4] = "four";
            num[5] = "five";
            num[6] = "six";
            num[7] = "seven";
            num[8] = "eight";
            num[9] = "nine";
            for (int j = 0; j < 10; j++)
            {
                if (lastNumber == j)
                {
                    Console.WriteLine(num[j]);
                }
            }
        }
    }
}
