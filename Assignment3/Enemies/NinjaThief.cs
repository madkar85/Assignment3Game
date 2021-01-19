using System;
using System.Collections.Generic;
using System.Text;
using Assignment3.Interfaces;

namespace Assignment3.Enemies
{
    class NinjaThief : Monster
    {

        public NinjaThief()
        {
            this.Name = "Ninja Thief";
            this.ExpWhenKilled = 10;
            this.Hp = 35;
        }

        /*public override void TakeDamage(int damage)
        {
            this.Hp -= damage;

            Console.WriteLine($"You hit the monster, dealing {damage} damage");
            Console.WriteLine(Hp);
        }*/
        
    }
}
