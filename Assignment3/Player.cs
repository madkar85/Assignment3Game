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
