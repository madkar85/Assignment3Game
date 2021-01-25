using System;
using System.Collections.Generic;
using Assignment3.Enemies;

namespace Assignment3
{
    class Utility
    {
        
        private static readonly Random random = new Random();

        //slumpar fram ett monster
        public static Monster RandomMonster(List<Monster> listOfMonsters)
        {
            int rand = random.Next(listOfMonsters.Count);

            return listOfMonsters[rand];
        }
        
        //slumpar fram en siffra
        public static int RandomNumber(int x, int y)
        {               
            int rand = random.Next(x, y);

            return rand;
        }
    }
}
