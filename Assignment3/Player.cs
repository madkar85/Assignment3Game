using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;

namespace Assignment3
{
    class Player
    {

        private string name;
        private int level;
        private int exp;
        private int hp = 200;

        // Level 1-10. Ska bli svårare att level up ju högre level man kommer till.
        // När man level upp, skriv ut typ You leveled up! You are now level xx, with xx exp and xx hp.
        //Level 1 : 30 exp
        //Level 2:  90 exp;
        //Level 3 : 180 exp
        //Level 4 : 300 exp
        //Level 5 : 450 exp
        //Level 6 : 630 exp
        //Level 7 : 840 exp
        //Level 8: 1080 exp
        //Level 9: 1350 exp
        //Level 10: 1650 exp

        public void TakeDamage(int damage)
        {

            this.Hp -= damage;

            Console.WriteLine($"The monster hit you, dealing {damage} damage");
            Console.WriteLine(Hp);

           
        }

        public void CheckLevel(int exp)
        {
            if(exp == 10)
            {
                level = 10;
            }
            else if (exp == 9)
            {
                level = 9;
            }
            else if (exp == 8)
            {
                level = 8;
            }
            else if (exp == 7)
            {
                level = 7;
            }
            else if (exp == 6)
            {
                level = 6;
            }
            else if (exp == 5)
            {
                level = 5;

            }
            else if (exp == 4)
            {
                level = 4;
            }
            else if (exp == 3)
            {
                level = 3;
            }
            else if (exp == 2)
            {
                level = 2;
            }
            else if (exp == 1)
            {
                level = 1;
            }
        }

        public void CharacterDetails()
        {
            Console.WriteLine($"Players name = {this.name}");
            Console.WriteLine($"Level: {this.level}");
            Console.WriteLine($"Experience points: {this.exp}");
            Console.WriteLine($"Health points: {this.hp}");

        }
        



        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public int Exp { get => exp; set => exp = value; }
        public int Hp { get => hp; set => hp = value; }
    }
}
