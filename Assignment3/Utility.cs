using System;
using System.Collections.Generic;
using System.Text;
using Assignment3.Enemies;

namespace Assignment3
{
    class Utility
    {
        


        public static Monster RandomMonster(List<Monster> listOfMonsters)
        {

            Random random = new Random();
            int rand = random.Next(listOfMonsters.Count);

            return listOfMonsters[rand];
           

        }
        

        public static int RandomNumber(int x, int y)
        {
            Random random = new Random();
            int rand = random.Next(x, y);

            return rand;
        }
    }
}
