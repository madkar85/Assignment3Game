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
        private int gold;
        private string sound;

        public string Name { get => name; set => name = value; }
        public int ExpWhenKilled { get => expWhenKilled; set => expWhenKilled = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Gold { get => gold; set => gold = value; }
        public string Sound { get => sound; set => sound = value; }

        public virtual void TakeDamage(int damage, Player player)
        {
            if(player.Strength > 0)
            {
                damage = damage + player.Strength;
            }
            this.Hp -= damage;

            if(damage <= 0)
            {
                damage = 0;
            }

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
                Console.WriteLine($"* You killed the monster! You earned {this.ExpWhenKilled} exp points! *");
                player.Exp += this.ExpWhenKilled;
                player.Gold += this.Gold;
                player.CheckLevel(player);
                //Console.WriteLine($"You are level {player.Level}. You have {player.Exp} exp, {player.Hp} health points and {player.Gold} gold coins.");

               //keepFighting = false;
            }
        }

        public virtual void SetMonsterToughness(Player player)
        {
            
            if(player.Level == 1)
            {
                this.Hp += 3;
                this.ExpWhenKilled -= 2;
            }
            else if(player.Level == 2)
            {
                this.Hp += 6;
                this.ExpWhenKilled -= 2;
            }
            else if(player.Level == 3)
            {
                this.Hp += 8;
                this.ExpWhenKilled -= 2;
            }
            else if (player.Level >= 4 || player.Level == 5)
            {
                this.Hp += 10;
                this.ExpWhenKilled -= 2;
            }                      
            else if (player.Level >= 6 || player.Level == 8)
            {
                this.Hp += 12;
                this.ExpWhenKilled -= 2;
            }         
            else if (player.Level >= 9)
            {
                this.Hp += 14;
                this.ExpWhenKilled -= 2;
            }

        }

        public virtual void Noice(string sound)
        {
            Console.WriteLine($"* {this.Sound} *");
        }

    }
}
