﻿using System;

namespace RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lostGames = double.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double BroakenHeadSets = 0;
            double BroakenMouses = 0;
            double BroakenKeyboards = 0;
            double BroakenDisplays = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    BroakenHeadSets++;
                }
                if (i % 3 == 0)
                {
                    BroakenMouses++;
                }
                if (i % 6 == 0)
                {
                    BroakenKeyboards++;
                }
                if (i % 12 == 0)
                {
                    BroakenDisplays++;
                }
                
            }double totalPriceHeadSets = BroakenHeadSets * headsetPrice;
            double totalPriceMouses = BroakenMouses * mousePrice;
            double totalPriceKeyboards = BroakenKeyboards * keyboardPrice;
            double totalPriceDisplays = BroakenDisplays * displayPrice;

            double totalCost = totalPriceHeadSets + totalPriceMouses + totalPriceKeyboards + totalPriceDisplays;

                Console.WriteLine($"Rage expenses: {totalCost:F2} lv.");
        }
    }
}
