﻿using System;
using System.Collections.Generic;
using System.Text;
using Assignment3.Enemies;
using Assignment3.Interfaces;

namespace Assignment3
{
    class GameMode
    {
        static Player player = new Player();
        static List<Monster> listOfMonsters = new List<Monster>{   new Troll(), new GiantSpider(), new NinjaThief() };

        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome!");
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            player.Name = name;

            Menu();

        }


         public static void Menu()
        {
            bool keepGoing = true;
            
            

            while (keepGoing)
            {
                List<Monster> listOfMonsters = new List<Monster> { new Troll(), new GiantSpider(), new NinjaThief() };
                Console.WriteLine("1. Go adventuring");
                Console.WriteLine("2. Show details about your character");
                Console.WriteLine("3. Exit game");
                string choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        // fixa så det blir en ny lista med monster efter en fight där monstret dog
                        PlayGame(Utility.RandomMonster(listOfMonsters));
                        
                        if (player.Hp <= 0 || player.Level == 10)
                        {
                            ExitGame();
                            keepGoing = false;
                        }
                        break;
                    case "2":
                        CharacterDetails();
                        break;
                    case "3":
                        ExitGame();
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("Wrong input, try again.");
                        break;
                }



            }


        }

        public static void PlayGame(Monster monster)
        {
            int chance = Utility.RandomNumber(1,11);
            if (chance == 1)
            {
                Console.WriteLine("There´s nothing but swaying grass as far as the eye can see.");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }
            else
            {
                BattleMode(monster);
                
            }

        }

        public static void BattleMode(Monster monster)
        {

            bool keepFighting = true;

            while (keepFighting)
            {
                Console.WriteLine($"A {monster.Name} blocks your way. You have to fight to get past it!");
                monster.TakeDamage(Utility.RandomNumber(1,10));
                player.TakeDamage(Utility.RandomNumber(1,10));
                //player.TakeDamage(2);

                if (monster.Hp <= 0)
                {
                    Console.WriteLine($"You killed the monster! You earned {monster.ExpWhenKilled} exp points!");
                    player.Exp += monster.ExpWhenKilled;
                    Console.WriteLine($"You are level {player.Level}. You have {player.Exp} exp and {player.Hp} health points.");
                     
                    keepFighting = false;
                }
                else if (player.Hp <= 0)
                {
                    Console.WriteLine($"You were killed!");
                    keepFighting = false;
                    break;
                }

                if (player.Level == 10)
                {
                    Console.WriteLine("Congratulations! You reached level 10 and won the game!");
                    keepFighting = false;
                }

                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                Console.Clear();

            }

        }

        public static void CharacterDetails()
        {
            player.CharacterDetails();

        }
        public static void ExitGame()
        {
            Console.WriteLine("Thanks for playing!");

        }



    }
}