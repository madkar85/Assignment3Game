using System;
using System.Collections.Generic;
using System.Text;
using Assignment3.Interfaces;

namespace Assignment3.Enemies
{
    class Monster : IMonster
    {

        private string name;
        private int expWhenKilled;
        private int hp;

        public string Name { get => name; set => name = value; }
        public int ExpWhenKilled { get => expWhenKilled; set => expWhenKilled = value; }
        public int Hp { get => hp; set => hp = value; }


       public virtual void TakeDamage(int damage)
        {
            this.Hp -= damage;

            if (Hp <= 0)
            {
                this.Hp = 0;
            }

            Console.WriteLine($"You hit the monster, dealing {damage} damage");           
            Console.WriteLine($"{Name} hp: {Hp}");


        } 

        public virtual void IsDead(Player player)
        {
            if (this.Hp <= 0)
            {
                Console.WriteLine($"You killed the monster! You earned {this.ExpWhenKilled} exp points!");
                player.Exp += this.ExpWhenKilled;
                Console.WriteLine($"You are level {player.Level}. You have {player.Exp} exp and {player.Hp} health points.");

               //keepFighting = false;
            }
        }

        public virtual void SetMonsterToughness(Player player)
        {
            
            if(player.Level == 1)
            {
                this.Hp += 5;
                this.ExpWhenKilled -= 2;
            }
        }

    }
}
