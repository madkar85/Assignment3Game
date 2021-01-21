using System;
using System.Collections.Generic;
using Assignment3.Enemies;

namespace Assignment3
{
    class Utility
    {

        private static readonly Random random = new Random();

        public static Monster RandomMonster(List<Monster> listOfMonsters)
        {
            int rand = random.Next(listOfMonsters.Count);

            return listOfMonsters[rand];
        }
        

        public static int RandomNumber(int x, int y)
        {               
            int rand = random.Next(x, y);

            return rand;
        }
    }
}
