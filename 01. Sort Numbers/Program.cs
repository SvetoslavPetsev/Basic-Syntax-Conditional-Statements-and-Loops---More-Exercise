using System;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            int big = 0;
            int mid = 0;
            int lid = 0;
            if (x > y && x > z)
            {
                big = x;
                if (y > z)
                {
                    mid = y;
                    lid = z;
                }
                else
                {
                    mid = z;
                    lid = y;
                }
            }
            else if (y > x && y > z)
            {
                big = y;
                if (x > z)
                {
                    mid = x;
                    lid = z;
                }
                else
                {
                    mid = z;
                    lid = x;
                }
            }
            else if (z > x && z > y)
            {
                big = z;
                if (x > y)
                {
                    mid = x;
                    lid = y;
                }
                else
                {
                    mid = y;
                    lid = x;
                }
            }
            Console.WriteLine(big);
            Console.WriteLine(mid);
            Console.WriteLine(lid);
        }
    }
}
