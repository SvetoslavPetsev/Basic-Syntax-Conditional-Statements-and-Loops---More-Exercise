using System;

namespace _04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputName = Console.ReadLine();
            string revurse = "";
            for (int i = inputName.Length - 1; i >= 0; i--)
            {
                revurse += inputName[i];
            }
            Console.WriteLine(revurse);
        }
    }
}
