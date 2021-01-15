using Assignment3.Enemies;
using System;
using System.ComponentModel.Design;


namespace Assignment3
{
    class Program
    {

        static Player player = new Player();


        static void Main(string[] args)
        {   
            Welcome();
            
        }


        private static void Welcome()
        {
            Console.WriteLine("Hello and welcome!");
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            player.Name = name;
            
            Menu();

        }


        private static void Menu()
        {
            bool keepGoing = true;
            Troll troll = new Troll();

            while (keepGoing)
            {
                Console.WriteLine("1. Go adventuring");
                Console.WriteLine("2. Show details about your character");
                Console.WriteLine("3. Exit game");
                string choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        PlayGame(troll);
                        if (player.Hp <= 0 || player.Level == 1)
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

        private static void PlayGame(Monster monster)
        {
            var rand = new Random();
            int chance = rand.Next(1, 11);
            if(chance == 1)
            {
                Console.WriteLine("There´s nothing but swaying grass as far as the eye can see.");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }
            else
            {
                BattleMode(monster);
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }
                    
        }

        private static void BattleMode(Monster monster)
        {
            Random rand = new Random();
                        
            Console.WriteLine($"A {monster.Name} blocks your way. You have to fight to get past it!");
            monster.TakeDamage(rand.Next(1,9));
            //monster.TakeDamage(10);
            player.TakeDamage(rand.Next(1,7));
            //player.TakeDamage(2);


            if (monster.Hp <= 0)
            {
                Console.WriteLine($"You killed the monster! You earned {monster.ExpWhenKilled} exp points!");
                player.Exp += monster.ExpWhenKilled;
                Console.WriteLine(player.Exp);
                if(player.Exp == 35)
                {
                    player.Level = 1;
                }
             }
            else if (player.Hp <= 0)
            {
                Console.WriteLine($"You were killed!");
            }
            
            if(player.Level == 1)
            {
                Console.WriteLine("Congratulations! You reached level 10 and won the game!");
            }

        }

        private static void CharacterDetails()
        {
            player.CharacterDetails();

        }
        private static void ExitGame()
        {
            Console.WriteLine("Thanks for playing!");

        }
    }
}
