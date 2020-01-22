using System;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int nubersimbols = int.Parse(Console.ReadLine());

            string[] two = { "a", "b", "c" };
            string[] three = { "d", "e", "f" };
            string[] four = { "g", "h", "i" };
            string[] five = { "j", "k", "l" };
            string[] six = { "m", "n", "o" };
            string[] seven = { "p", "q", "r", "s" };
            string[] eight = { "t", "u", "v" };
            string[] nine = { "w", "x", "y", "z" };

            string[] massage = new string[nubersimbols];
            int counter = 0;
            char firstSimbol = ' ';

            for (int f = 0; f < nubersimbols; f++)
            {
                string input = Console.ReadLine();
                for (int i = 0; i < input.Length; i++)
                {
                    firstSimbol = input[0];
                }
                if (firstSimbol == '1')
                {
                    for (int k = 0; k < input.Length; k++)
                    {
                       massage[counter] = "1";
                       counter++;
                    }
                }
                else if (firstSimbol == '2')
                {
                    massage[counter] = two[input.Length - 1];
                    counter++;
                }
                else if (firstSimbol == '3')
                {
                    massage[counter] = three[input.Length - 1];
                    counter++;
                }
                else if (firstSimbol == '4')
                {
                    massage[counter] = four[input.Length - 1];
                    counter++;
                }
                else if (firstSimbol == '5')
                {
                    massage[counter] = five[input.Length - 1];
                    counter++;
                }
                else if (firstSimbol == '6')
                {
                    massage[counter] = six[input.Length - 1];
                    counter++;
                }
                else if (firstSimbol == '7')
                {
                    massage[counter] = seven[input.Length - 1];
                    counter++;
                }
                else if (firstSimbol == '8')
                {
                    massage[counter] = eight[input.Length - 1];
                    counter++;
                }
                else if (firstSimbol == '9')
                {
                    massage[counter] = nine[input.Length - 1];
                    counter++;
                }
                else if (firstSimbol == '0')
                {
                    for (int k = 0; k < input.Length; k++)
                    {
                        massage[counter] = " ";
                        counter++;
                    }
                }
            }
            for (int i = 0; i < nubersimbols; i++)
            {
                Console.Write(massage[i]);
            }
        }
    }
}

