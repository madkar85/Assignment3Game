using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3.Enemies
{
    class Monster
    {

        private string name;
        private int expWhenKilled;
        private int hp;

        public string Name { get => name; set => name = value; }
        public int ExpWhenKilled { get => expWhenKilled; set => expWhenKilled = value; }
        public int Hp { get => hp; set => hp = value; }


        public void TakeDamage(int damage)
        {
            this.Hp -= damage;

            Console.WriteLine($"You hit the monster, dealing {damage} damage");
            Console.WriteLine(Hp);

            /*if(Hp <= 0)
            {
                Console.WriteLine($"You killed the monster! You earned {ExpWhenKilled} exp points!");
                
            }*/
        }



    }
}
