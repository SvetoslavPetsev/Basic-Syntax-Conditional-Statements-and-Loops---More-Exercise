using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal ballance = decimal.Parse(Console.ReadLine());
            decimal currentballance = ballance;
            decimal gamePrice = 0;
            while (true)
            {
                string gameName = Console.ReadLine();
                if (gameName == "Game Time")
                {
                    break;
                }
                if (gameName != "OutFall 4" &&
                    gameName != "CS: OG" &&
                    gameName != "Zplinter Zell" &&
                    gameName != "Honored 2" &&
                    gameName != "RoverWatch" &&
                    gameName != "RoverWatch Origins Edition")
                {
                    Console.WriteLine("Not Found");
                    continue;
                }
                else if (gameName == "OutFall 4")
                {
                    gamePrice = 39.99m;
                }
                else if (gameName == "CS: OG")
                {
                    gamePrice = 15.99m;
                }
                else if (gameName == "Zplinter Zell")
                {
                    gamePrice = 19.99m;
                }
                else if (gameName == "Honored 2")
                {
                    gamePrice = 59.99m;
                }
                else if (gameName == "RoverWatch")
                {
                    gamePrice = 29.99m;
                }
                else if (gameName == "RoverWatch Origins Edition")
                {
                    gamePrice = 39.99m;
                }
                if (gamePrice > currentballance)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }
                else
                {
                    currentballance -= gamePrice;
                    Console.WriteLine($"Bought {gameName}");
                }
                if (currentballance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }
            decimal allSpend = ballance - currentballance;
            Console.WriteLine($"Total spent: ${allSpend:F2}. Remaining: ${(ballance - allSpend):F2}");
        }
    }
}
