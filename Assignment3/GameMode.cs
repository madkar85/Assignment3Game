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
            Console.WriteLine("* * * * * * * * * * * *");
            Console.WriteLine("* Hello and welcome!");
            Console.WriteLine("* Please enter your name: ");
            string name = Console.ReadLine();
            player.Name = name;
            Console.WriteLine($"* Let´s start the game, {player.Name}!");
            Console.WriteLine("* * * * * * * * * * * * *");

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
                Console.WriteLine("3. Go to Shop");
                Console.WriteLine("4. Exit game");
                string choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        
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
                        Shop.ShopMenu(player);
                        break;
                    case "4":
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
            int direction = Utility.RandomNumber(1, 3);
            int chance = Utility.RandomNumber(1,11);
            if (chance == 1)
            {
                if(direction == 1)
                {
                    Console.WriteLine("There´s only an old, dense forest. It looks really difficult to get through there.");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }
                else 
                {
                    Console.WriteLine("There´s nothing here, only green fields as far as you can see. Maybe a dark mountain far away in the distant.");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                } 

            }
            else
            {
                BattleMode(monster);
                
            }

        }

        public static void BattleMode(Monster monster)
        {
            monster.SetMonsterToughness(player);
            bool keepFighting = true;

            while (keepFighting)
            {
               
                Console.WriteLine($"A {monster.Name} blocks your way. You have to fight to get past it!");
                monster.Noice(monster.Sound);
                monster.TakeDamage(Utility.RandomNumber(1,11), player);               
                if (monster.Hp <= 0)
                {
                    monster.IsDead(player);
                     
                    keepFighting = false;
                }
                else
                {
                    player.TakeDamage(Utility.RandomNumber(1, 11));
                    if (player.Hp <= 0)
                    {
                        player.IsDead();
                        keepFighting = false;
                        break;
                    }

                    if (player.Level == 10)
                    {
                        Console.WriteLine("Congratulations! You reached level 10 and won the game!");
                        keepFighting = false;
                    }
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
