using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Assignment3.Interfaces;

namespace Assignment3.Enemies
{
    class Troll : Monster, IMonster
    {
       // private string name = "Troll";
       // private int expWhenKilled = 35;
        //private int hp = 20;

        public Troll()
        {
            this.Name = "Troll";
            this.ExpWhenKilled = 1;
            this.Hp = 20;
        }

        /* public void TakeDamage(int damage)
        {
            this.Hp -= damage;

            Console.WriteLine($"You hit the monster, dealing {damage} damage");
            Console.WriteLine(Hp);
        }*/

        public void TakeDamage(int damage)
        {
            this.Hp -= damage;

            Console.WriteLine($"You hit the monster, dealing {damage} damage");
            Console.WriteLine(Hp);
        }

        
    }
}
