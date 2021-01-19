using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Security;
using System.Text;


namespace Assignment3
{
    class Player
    {

        private string name;
        private int level;
        private int exp;
        private int hp = 400;

        // Level 1-10. Ska bli svårare att level up ju högre level man kommer till.
        // När man level upp, skriv ut typ You leveled up! You are now level xx, with xx exp and xx hp.
        //Level 1 : 20 exp
        //Level 2:  40 exp;
        //Level 3 : 60 exp
        //Level 4 : 80 exp
        //Level 5 : 100 exp
        //Level 6 : 120 exp
        //Level 7 : 140 exp
        //Level 8 : 160 exp
        //Level 9 : 180 exp
        //Level 10: 200 exp

        public void TakeDamage(int damage)
        {

            this.Hp -= damage;

            Console.WriteLine($"The monster hit you, dealing {damage} damage");
            Console.WriteLine($"{Name} hp: {Hp}");

           
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
        public int Exp {
            get => exp;
            set {
                exp = value;
                this.Level = value / 10;
            }
        }
        public int Hp { get => hp; set => hp = value; }
    }
}
