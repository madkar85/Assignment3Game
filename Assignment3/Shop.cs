using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Shop
    {

        public static void ShopMenu(Player player)
        {
            bool keepBuying = true;
            //while (keepBuying)
            //{
                Console.WriteLine("Welcome to the Shop!");
                Console.WriteLine("What would you like to buy?");
                Console.WriteLine($"You have {player.Gold} gold coins");
                Console.WriteLine("1. Attack charm. (+ 5 strength) - 100 gold");
                Console.WriteLine("2. Defense charm (+ 2 toughness) - 100 gold");
                Console.WriteLine("3. Exit shop");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        player.Strength += 5;
                        player.Gold -= 100;
                        break;
                    case "2":
                        player.Toughness += 2;
                        player.Gold -= 100;
                        break;
                    case "3":                       
                        keepBuying = false;
                        break;
                    default:
                        Console.WriteLine("Wrong input. Please try again.");
                        break;
                }

           // }

            GameMode.Menu();

        }


    }
}
